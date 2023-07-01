using System;
using System.Reflection;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using static Hyundai_Car_DBMS.Extension;
using Excel = Microsoft.Office.Interop.Excel;

namespace Hyundai_Car_DBMS
{
    public partial class Hyundai_Car_DBMS_Form : Form
    {
        public Hyundai_Car_DBMS_Form()
        {
            InitializeComponent();
        }


        private void Hyundai_Car_DBMS_Form_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(DataDirectory)) { Directory.CreateDirectory(DataDirectory); }

            Cars = CarsFileName.Load<BindingList<Car>>();
            foreach (Car Car in Cars) { Car.Appointments.ListChanged += Appointments_ListChanged; }
            Cars.ListChanged += Cars_ListChanged;
            Cars_ListChanged(null, null);

            Persons = PersonsFileName.Load<BindingList<Person>>();
            Persons.ListChanged += Persons_ListChanged;
            if (Persons.Count < Enum.GetNames(typeof(DefaultPersonEnum)).Length)
            {
                Persons.Insert(0, DefaultPerson);
            }
            Persons_ListChanged(null, null);

            AppointmentLocationComboBox.Items.AddRange(Enum.GetNames(typeof(DefaultLocationEnum))); AppointmentLocationComboBox.Hide();
            CarTyreTypeComboBox.Items.AddRange(Enum.GetNames(typeof(TyreTypeEnum)));
            CarLeasingCompanyComboBox.Items.AddRange(Enum.GetNames(typeof(LeasingCompanyEnum)));
            CarViegnetteComboBox.Items.AddRange(Enum.GetNames(typeof(ViegnetteEnum)));

            foreach (var Title in Car.Titles) { CarListView.Columns.Add(Title); }
            foreach (var Title in Person.Titles) { PersonListView.Columns.Add(Title); }
            foreach (var Title in Appointment.Titles) { AppointmentListView.Columns.Add(Title); }

            CarListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            PersonListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AppointmentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Cars_ListChanged(object sender, ListChangedEventArgs e)
        {
            CarListView.Items.Clear();
            for (int i = 0; i < Cars.Count; i++)
            {
                Cars[i].UpdateAvailableAndSituation();
                CarListView.Items.Add(new ListViewItem(Cars[i].ToStringArray()));
                CarListView.Items[i].BackColor = Cars[i].Color;
            }
            AppointmentCarComboBox.Items.Clear();
            AppointmentCarComboBox.Items.AddRange(Cars.ToList().ConvertAll(Car => $"{Car.Plate}").ToArray());
        }


        private void Persons_ListChanged(object sender, EventArgs e)
        {
            PersonListView.Items.Clear();
            PersonListView.Items.AddRange(Persons.ToList().ConvertAll(Person => new ListViewItem(Person.ToStringArray())).ToArray());
            AppointmentPersonComboBox.Items.Clear();
            AppointmentPersonComboBox.Items.AddRange(Persons.ToList().ConvertAll(Person => $"{Person.Fullname}").ToArray());
        }

        private Car GetCar()
        {
            if (CarPlateTextBox.Text != "")
            {
                if (CarTyreTypeComboBox.SelectedIndex != -1)
                {
                    if (CarLeasingCompanyComboBox.SelectedIndex != -1)
                    {
                        if (CarViegnetteComboBox.SelectedIndex != -1)
                        {
                            Car Car = new Car(
                            CarPlateTextBox.Text,
                            (TyreTypeEnum)CarTyreTypeComboBox.SelectedIndex,
                            CarTUVDateDateTimePicker.Value,
                            (LeasingCompanyEnum)CarLeasingCompanyComboBox.SelectedIndex,
                            (ViegnetteEnum)CarViegnetteComboBox.SelectedIndex,
                            CarCommentRichTextBox.Text);
                            Car.Appointments.ListChanged += Appointments_ListChanged;
                            return Car;
                        }
                        else
                        {
                            MessageBox.Show("Viegnette is not entered");
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Leasing Company is not entered");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Tyre Type is not entered");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Plate is not entered");
                return null;
            }

        }

        private void Appointments_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (AppointmentCarComboBox.SelectedIndex != -1)
            {
                var Appointments = Cars[AppointmentCarComboBox.SelectedIndex].Appointments.ToList();
                AppointmentListView.Items.Clear();
                AppointmentListView.Items.AddRange(Appointments.ConvertAll(Appointment => new ListViewItem(Appointment.ToStringArray())).ToArray());

                if (Appointments.Count > 0)
                {
                    var LastAppointment = Appointments.Last();
                    AppointmentMonthCalendar.SelectionRange = new SelectionRange(LastAppointment.StartDateInformation.Time, LastAppointment.EndDateInformation.Time);
                }
                else
                {
                    AppointmentMonthCalendar.SelectionRange = new SelectionRange();
                }
            }
            else
            {
                AppointmentMonthCalendar.SelectionRange = new SelectionRange();
            }

            for (int i = 0; i < Cars.Count; i++)
            {
                Cars[i].UpdateAvailableAndSituation();
                CarListView.Items[i].SubItems[2].Text = Cars[i].Available.ToString();
                CarListView.Items[i].SubItems[3].Text = Cars[i].Situation;
                CarListView.Items[i].BackColor = Cars[i].Color;
            }
        }

        private Person GetPerson()
        {
            if (PersonNameTextBox.Text != "" && PersonSurnameTextBox.Text != "" && PersonPhoneNumberTextBox.Text != "")
            {
                var Person = new Person(PersonNameTextBox.Text, PersonSurnameTextBox.Text, PersonPhoneNumberTextBox.Text, PersonAddressRichTextBox.Text, PersonCommentRichTextBox.Text);
                if (Person.IsDefaultPerson())
                {
                    MessageBox.Show($"Person Name cannot be {DefaultPerson.Fullname}");
                    return null;
                }
                else
                {
                    return Person;
                }

            }
            else
            {
                MessageBox.Show(PersonNameTextBox.Text == "" ? "Name is not entered\n" : "" + PersonSurnameTextBox.Text == "" ? "Surname is not entered\n" : "" + PersonPhoneNumberTextBox.Text == "" ? "Phone Number is not entered\n" : "");
                return null;
            }
        }
        private DateTime GetDateTime(DateTime DateValue, DateTime TimeValue) => new DateTime(DateValue.Year,
                                                                                             DateValue.Month,
                                                                                             DateValue.Day,
                                                                                             TimeValue.Hour,
                                                                                             TimeValue.Minute,
                                                                                             TimeValue.Second,
                                                                                             TimeValue.Millisecond);
        private Appointment GetAppointment()
        {
            string Location;
            DateTime StartDateTime = GetDateTime(AppointmentStartDateDateTimePicker.Value, AppointmentStartTimeDateTimePicker.Value);
            DateTime EndDateTime = GetDateTime(AppointmentEndDateDateTimePicker.Value, AppointmentEndTimeDateTimePicker.Value);

            if (AppointmentPersonComboBox.SelectedIndex != -1)
            {
                if (Persons[AppointmentPersonComboBox.SelectedIndex].IsDefaultPerson())
                {
                    if (AppointmentLocationComboBox.SelectedIndex != -1)
                    {
                        var LocationEnum = (DefaultLocationEnum)AppointmentLocationComboBox.SelectedIndex;
                        if (LocationEnum == DefaultLocationEnum.Garage)
                        {
                            EndDateTime = new DateTime(StartDateTime.Year, StartDateTime.Month, StartDateTime.Day, StartDateTime.Hour, StartDateTime.Minute, StartDateTime.Second, StartDateTime.Millisecond + 1);
                        }
                        Location = LocationEnum.GetEnumName();
                    }
                    else
                    {
                        MessageBox.Show("Location is not selected");
                        return null;
                    }
                }
                else
                {
                    Location = AppointmentLocationTextBox.Text;
                }
            }
            else
            {
                MessageBox.Show("Person is not selected");
                return null;
            }


            if (StartDateTime < EndDateTime)
            {
                if (!float.TryParse(AppointmentStartDrivingDistanceTextBox.Text, out float StartDrivingDistance)) { MessageBox.Show("Start Driving Distance is not valid"); return null; }
                if (StartDrivingDistance < 0) { MessageBox.Show("Start Driving Distance is not valid"); return null; }

                if (!float.TryParse(AppointmentStartFuelTextBox.Text, out float StartFuel)) { MessageBox.Show("Start Fuel is not valid"); return null; }
                if (StartFuel < 0 || StartFuel > 100) { MessageBox.Show("Start Fuel is not valid"); return null; }

                if (!float.TryParse(AppointmentEndDrivingDistanceTextBox.Text, out float EndDrivingDistance)) { MessageBox.Show("End Driving Distance is not valid"); return null; }
                if (EndDrivingDistance < StartDrivingDistance) { MessageBox.Show("End Driving Distance is not valid"); return null; }

                if (!float.TryParse(AppointmentEndFuelTextBox.Text, out float EndFuel)) { MessageBox.Show("End Fuel is not valid"); return null; }
                if (EndFuel < 0 || EndFuel > 100) { MessageBox.Show("End Fuel is not valid"); return null; }

                return new Appointment(new DateInformation(StartDateTime, StartDrivingDistance, StartFuel), new DateInformation(EndDateTime, EndDrivingDistance, EndFuel), Persons[AppointmentPersonComboBox.SelectedIndex], Location, AppointmentCommentRichTextBox.Text);
            }
            else
            {
                MessageBox.Show("Start Date Time is later than End Date Time");
                return null;
            }
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            var NewCar = GetCar();
            if (NewCar != null)
            {
                Cars.Add(NewCar);
            }
        }

        private void PersonAddButton_Click(object sender, EventArgs e)
        {
            var NewPerson = GetPerson();
            if (NewPerson != null)
            {
                if (Persons.ToList().TrueForAll(Person => NewPerson != Person))
                {
                    Persons.Add(NewPerson);
                }
                else
                {
                    MessageBox.Show("Person is already in datebase");
                }

            }
        }


        private void AppointmentAddButton_Click(object sender, EventArgs e)
        {
            var NewAppointment = GetAppointment();
            if (NewAppointment != null)
            {
                if (AppointmentCarComboBox.SelectedIndex != -1)
                {
                    if (Cars[AppointmentCarComboBox.SelectedIndex].Appointments.ToList().TrueForAll(Appointment => !AreDatesInDates(NewAppointment.StartDateInformation.Time, NewAppointment.EndDateInformation.Time, Appointment.StartDateInformation.Time, Appointment.EndDateInformation.Time)))
                    {
                        Cars[AppointmentCarComboBox.SelectedIndex].Appointments.Add(NewAppointment);
                    }
                    else
                    {
                        MessageBox.Show("Dates are not empty");
                    }
                }
                else
                {
                    MessageBox.Show("Car is not selected");
                }
            }
        }

        private int CarListViewSelectedIndex
        {
            get
            {
                int CarListViewSelectedIndex = -1;
                if (CarListView.SelectedIndices.Count > 0)
                {
                    CarListViewSelectedIndex = CarListView.SelectedIndices[0];
                }
                return CarListViewSelectedIndex;
            }
        }

        private int PersonListViewSelectedIndex
        {
            get
            {
                int PersonListViewSelectedIndex = -1;
                if (PersonListView.SelectedIndices.Count > 0)
                {
                    PersonListViewSelectedIndex = PersonListView.SelectedIndices[0];
                    if (PersonListViewSelectedIndex != -1)
                    {
                        PersonAddressRichTextBox.Text = Enum.IsDefined(typeof(DefaultPersonEnum), PersonListViewSelectedIndex).ToString();

                        if (PersonListViewSelectedIndex < Enum.GetNames(typeof(DefaultPersonEnum)).Length)
                        {
                            PersonListViewSelectedIndex = -1;
                        }
                    }
                }
                return PersonListViewSelectedIndex;
            }
        }

        private int AppointmentListViewSelectedIndex
        {
            get
            {
                int AppointmentListViewSelectedIndex = -1;
                if (AppointmentListView.SelectedIndices.Count > 0)
                {
                    AppointmentListViewSelectedIndex = AppointmentListView.SelectedIndices[0];
                }
                return AppointmentListViewSelectedIndex;
            }
        }

        private void CarDeleteButton_Click(object sender, EventArgs e)
        {
            int CarListViewSelectedIndexLocale = CarListViewSelectedIndex;
            if (CarListViewSelectedIndexLocale != -1)
            {
                Cars.RemoveAt(CarListViewSelectedIndexLocale);
            }
        }

        private void PersonDeleteButton_Click(object sender, EventArgs e)
        {
            int PersonListViewSelectedIndexLocale = PersonListViewSelectedIndex;
            if (PersonListViewSelectedIndexLocale != -1)
            {
                Persons.RemoveAt(PersonListViewSelectedIndexLocale);
            }
        }

        private void AppointmentDeleteButton_Click(object sender, EventArgs e)
        {
            int AppointmentListViewSelectedIndexLocale = AppointmentListViewSelectedIndex;
            if (AppointmentListViewSelectedIndexLocale != -1)
            {
                if (AppointmentCarComboBox.SelectedIndex != -1)
                {
                    Cars[AppointmentCarComboBox.SelectedIndex].Appointments.RemoveAt(AppointmentCarComboBox.SelectedIndex);
                }
            }
        }

        private void CarChangeButton_Click(object sender, EventArgs e)
        {
            int CarListViewSelectedIndexLocale = CarListViewSelectedIndex;
            if (CarListViewSelectedIndexLocale != -1)
            {
                var Car = GetCar();
                if (Car != null)
                {
                    Cars[CarListViewSelectedIndex] = Car;
                }
            }
        }

        private void PersonChangeButton_Click(object sender, EventArgs e)
        {
            int PersonListViewSelectedIndexLocale = PersonListViewSelectedIndex;
            if (PersonListViewSelectedIndexLocale != -1)
            {
                var Person = GetPerson();
                if (Person != null)
                {
                    Persons[PersonListViewSelectedIndex] = Person;
                }
            }
        }

        private void AppointmentChangeButton_Click(object sender, EventArgs e)
        {
            int AppointmentListViewSelectedIndexLocale = AppointmentListViewSelectedIndex;
            if (AppointmentListViewSelectedIndexLocale != -1)
            {
                var NewAppointment = GetAppointment();
                if (NewAppointment != null)
                {
                    if (AppointmentCarComboBox.SelectedIndex != -1)
                    {
                        var OtherAppointments = Cars[AppointmentCarComboBox.SelectedIndex].Appointments.ToList();
                        OtherAppointments.RemoveAt(AppointmentListViewSelectedIndexLocale);
                        if (OtherAppointments.TrueForAll(Appointment => !AreDatesInDates(NewAppointment.StartDateInformation.Time, NewAppointment.EndDateInformation.Time, Appointment.StartDateInformation.Time, Appointment.EndDateInformation.Time)))
                        {
                            Cars[AppointmentCarComboBox.SelectedIndex].Appointments.Add(NewAppointment);
                        }
                        else
                        {
                            MessageBox.Show("Dates are not empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Car is not selected");
                    }
                }
            }
        }

        private void Hyundai_Car_DBMS_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cars.Save(CarsFileName);
            Persons.Save(PersonsFileName);

            var ExcelFileName = Path.Combine(DataDirectory, "Car_Database");

            Excel.Application Application = new Excel.Application();

            if (Application == null)
            {
                MessageBox.Show("Excel is not properly installed");
                return;
            }

            Workbook WorkBook = Application.Workbooks.Add(Missing.Value);
            Worksheet WorkSheet;

            WorkSheet = WorkBook.Worksheets.get_Item(1);
            WorkSheet.Name = "Persons";
            for (int c = 0; c < Person.Titles.Length; c++)
            {
                WorkSheet.Cells[1, 1 + c] = Person.Titles[c];
            }
            for (int r = 0; r < Persons.Count; r++)
            {
                var PersonStringArray = Persons[r].ToStringArray();
                for (int c = 0; c < PersonStringArray.Length; c++)
                {
                    WorkSheet.Cells[2 + r, 1 + c] = PersonStringArray[c];
                }
            }

            WorkSheet = WorkBook.Worksheets.Add(Missing.Value, Missing.Value, 1, Missing.Value);
            WorkSheet.Name = "Cars";
            for (int c = 0; c < Car.Titles.Length; c++)
            {
                WorkSheet.Cells[1, 1 + c] = Car.Titles[c];
            }
            for (int r = 0; r < Cars.Count; r++)
            {
                var CarStringArray = Cars[r].ToStringArray();
                for (int c = 0; c < CarStringArray.Length; c++)
                {
                    WorkSheet.Cells[2 + r, 1 + c] = CarStringArray[c];
                }
            }

            for (int i = 0; i < Cars.Count; i++)
            {
                WorkSheet = WorkBook.Worksheets.Add(Missing.Value, Missing.Value, 1, Missing.Value);
                WorkSheet.Name = Cars[i].Plate;

                for (int c = 0; c < Appointment.Titles.Length; c++)
                {
                    WorkSheet.Cells[1, 1 + c] = Appointment.Titles[c];
                }
                for (int r = 0; r < Cars[i].Appointments.Count; r++)
                {
                    var AppointmentStringArray = Cars[i].Appointments[r].ToStringArray();
                    for (int c = 0; c < AppointmentStringArray.Length; c++)
                    {
                        WorkSheet.Cells[2 + r, 1 + c] = AppointmentStringArray[c];
                    }
                }
            }

            try
            {
                WorkBook.SaveAs(ExcelFileName, XlFileFormat.xlWorkbookDefault, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlExclusive, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                WorkBook.Close(true, Missing.Value, Missing.Value);
                Application.Quit();
            }
            catch { }            

            Marshal.ReleaseComObject(WorkSheet);
            Marshal.ReleaseComObject(WorkBook);
            Marshal.ReleaseComObject(Application);
        }

        private void AppointmentCarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Appointments_ListChanged(null, null);
        }

        private void AppointmentPersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AppointmentPersonComboBox.SelectedIndex != -1)
            {
                if (Persons[AppointmentPersonComboBox.SelectedIndex].IsDefaultPerson())
                {
                    AppointmentLocationComboBox.Show();
                }
                else
                {
                    AppointmentLocationComboBox.Hide();
                    AppointmentLocationComboBox.SelectedIndex = -1;
                }
            }
        }

        private void AppointmentLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AppointmentLocationComboBox.SelectedIndex == ((int)DefaultLocationEnum.Garage))
            {
                AppointmentEndLabel.Hide();
                AppointmentEndDateDateTimePicker.Hide();
                AppointmentEndTimeDateTimePicker.Hide();
            }
            else
            {
                AppointmentEndLabel.Show();
                AppointmentEndDateDateTimePicker.Show();
                AppointmentEndTimeDateTimePicker.Show();
            }
        }

        private void CarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CarListViewSelectedIndexLocale = CarListViewSelectedIndex;
            if (CarListViewSelectedIndexLocale != -1)
            {
                var Car = Cars[CarListViewSelectedIndexLocale];
                CarPlateTextBox.Text = Car.Plate;
                CarTyreTypeComboBox.SelectedIndex = (int)Car.TyreType;
                CarTUVDateDateTimePicker.Value = Car.TUVDate;
                CarLeasingCompanyComboBox.SelectedIndex = (int)Car.LeasingCompany;
                CarViegnetteComboBox.SelectedIndex = (int)Car.Viegnette;
                CarCommentRichTextBox.Text = Car.Comment;
            }
        }

        private void PersonListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int PersonListViewSelectedIndexLocale = PersonListViewSelectedIndex;
            if (PersonListViewSelectedIndexLocale != -1)
            {
                var Person = Persons[PersonListViewSelectedIndexLocale];
                PersonNameTextBox.Text = Person.Name;
                PersonSurnameTextBox.Text = Person.Surname;
                PersonPhoneNumberTextBox.Text = Person.PhoneNumber;
                PersonAddressRichTextBox.Text = Person.Address;
                PersonCommentRichTextBox.Text = Person.Comment;
            }
        }

        private void AppointmentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AppointmentListViewSelectedIndexLocale = AppointmentListViewSelectedIndex;
            if (AppointmentListViewSelectedIndexLocale != -1)
            {
                var Appointment = Cars[AppointmentCarComboBox.SelectedIndex].Appointments[AppointmentListViewSelectedIndexLocale];

                AppointmentStartDateDateTimePicker.Value = Appointment.StartDateInformation.Time;
                AppointmentStartTimeDateTimePicker.Value = Appointment.StartDateInformation.Time;
                AppointmentEndDateDateTimePicker.Value = Appointment.EndDateInformation.Time;
                AppointmentEndTimeDateTimePicker.Value = Appointment.EndDateInformation.Time;
                AppointmentStartDrivingDistanceTextBox.Text = Appointment.StartDateInformation.DrivingDistance.ToString();
                AppointmentEndDrivingDistanceTextBox.Text = Appointment.EndDateInformation.DrivingDistance.ToString();
                AppointmentStartFuelTextBox.Text = Appointment.StartDateInformation.Fuel.ToString();
                AppointmentEndFuelTextBox.Text = Appointment.EndDateInformation.Fuel.ToString();
                AppointmentPersonComboBox.SelectedIndex = Persons.ToList().FindIndex(Person => { return Person == Appointment.Person; });
                AppointmentLocationTextBox.Text = Appointment.Location;
                AppointmentCommentRichTextBox.Text = Appointment.Comment;
                AppointmentMonthCalendar.SelectionRange = new SelectionRange(Appointment.StartDateInformation.Time, Appointment.EndDateInformation.Time);
            }
            else
            {
                AppointmentMonthCalendar.SelectionRange = new SelectionRange();
            }
        }
    }

    public static class Extension
    {
        public enum DefaultPersonEnum
        {
            Hyundai
        };

        public enum DefaultLocationEnum
        {
            Garage,
            Service
        };

        public enum TyreTypeEnum
        {
            Winter,
            Summer
        };

        public enum LeasingCompanyEnum
        {
            Autoever,
            EUQC,
            HMETC
        };

        public enum ViegnetteEnum
        {
            Available,
            Unavailable
        };

        public static string GetEnumName<T>(this T Enum_Instance) => Enum.GetName(typeof(T), Enum_Instance);
        public static bool IsDefaultPerson(this Person Person_Instance) => Person_Instance.Name.Contains(DefaultPerson.Name);

        public static string DataDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DataFolderName);
        public static string DataFolderName = DefaultPersonEnum.Hyundai.GetEnumName() + "_Car_DBMS";

        public static string CarsFileName = Path.Combine(DataDirectory, nameof(Cars) + ".xml");
        public static BindingList<Car> cars = new BindingList<Car>() { };
        public static BindingList<Car> Cars
        {
            get => cars;

            set
            {
                cars.Clear();
                foreach (var car in value)
                {
                    cars.Add(car);
                }
            }
        }

        public static string PersonsFileName = Path.Combine(DataDirectory, nameof(Persons) + ".xml");

        public static BindingList<Person> persons = new BindingList<Person>() { RaiseListChangedEvents = true };
        public static BindingList<Person> Persons
        {
            get => persons;

            set
            {
                foreach (var person in value)
                {
                    persons.Add(person);
                }
            }
        }

        public static Person DefaultPerson => new Person(DefaultPersonEnum.Hyundai.GetEnumName(), "", "", "", "");

        public static string[] DefaultLocations = Enum.GetNames(typeof(DefaultLocationEnum));

        public static void Save(this object Object, string Filename)
        {
            if (!File.Exists(Filename)) { File.Create(Filename).Close(); }
            using (XmlWriter XmlWriter = XmlWriter.Create(Filename, new XmlWriterSettings() { Indent = true }))
            {
                new XmlSerializer(Object.GetType()).Serialize(XmlWriter, Object);
            }
        }

        public static T Load<T>(this string Filename)
        {
            T Object;
            if (!File.Exists(Filename)) { Object = Activator.CreateInstance<T>(); Object.Save(Filename); }

            using (XmlReader XmlReader = XmlReader.Create(Filename))
            {
                Object = (T)(new XmlSerializer(typeof(T)).Deserialize(XmlReader));
            }
            return Object;

        }

        public static bool AreDatesInDates(DateTime StartDateTime1, DateTime EndDateTime1, DateTime StartDateTime2, DateTime EndDateTime2)
        {
            return StartDateTime1.IsDateBetween(StartDateTime2, EndDateTime2) || StartDateTime1.IsDateBetween(StartDateTime2, EndDateTime2);
        }

        public static bool IsDateBetween(this DateTime Date, DateTime StartDateTime, DateTime EndDateTime)
        {
            return StartDateTime < Date && Date < EndDateTime;
        }

        public static string GeneralDateTimeStringFormat = "MM/dd/yyyy HH:mm:ss";
    }

    public class Car
    {
        public string Plate;
        public TyreTypeEnum TyreType;
        public DateTime TUVDate;
        public LeasingCompanyEnum LeasingCompany;
        public ViegnetteEnum Viegnette;
        public string Comment;
        public BindingList<Appointment> Appointments;

        [XmlIgnore]
        public bool Available { get; private set; }
        [XmlIgnore]
        public Color Color { get; private set; }
        [XmlIgnore]
        public string Situation { get; private set; }

        public void UpdateAvailableAndSituation()
        {
            var Count = Appointments.Count;
            if (Count == 0)
            {
                Available = false;
                Situation = "There is no information";
            }
            else
            {
                var CurrentDate = DateTime.Now;
                var CurrentAppointment = Appointments.ToList().Find(Appointment => CurrentDate.IsDateBetween(Appointment.StartDateInformation.Time, Appointment.EndDateInformation.Time));

                if (CurrentAppointment != null)
                {
                    if (CurrentAppointment.Person.IsDefaultPerson() && CurrentAppointment.Location == DefaultLocationEnum.Garage.GetEnumName())
                    {
                        Available = true;
                        Color = Color.Green;
                        Situation = $"Car is at {DefaultLocationEnum.Garage.GetEnumName()}";
                    }
                    else if (CurrentAppointment.Person.IsDefaultPerson() && CurrentAppointment.Location == DefaultLocationEnum.Service.GetEnumName())
                    {
                        Available = false;
                        Color = Color.Red;
                        Situation = $"Car is at {DefaultLocationEnum.Service.GetEnumName()} until {CurrentAppointment.EndDateInformation.Time.ToString(GeneralDateTimeStringFormat)}";
                    }
                    else
                    {
                        Available = false;
                        Color = Color.Red;
                        Situation = $"Car stays with {CurrentAppointment.Person.Fullname} until {CurrentAppointment.EndDateInformation.Time.ToString(GeneralDateTimeStringFormat)}";
                    }
                }
                else
                {
                    var LastAppointment = Appointments.ToList().Find(Appointment => Appointment.EndDateInformation.Time < CurrentDate);
                    if (LastAppointment != null)
                    {
                        if (LastAppointment.Person.IsDefaultPerson() && LastAppointment.Location == DefaultLocationEnum.Garage.GetEnumName())
                        {
                            Available = true;
                            Color = Color.Green;
                            Situation = $"Car is at {DefaultLocationEnum.Garage.GetEnumName()}";
                        }
                        else
                        {
                            var TimeDifference = CurrentDate - LastAppointment.EndDateInformation.Time;

                            string TimeString = "";
                            if (TimeDifference.Days == 0)
                            {
                                TimeString = TimeDifference.TotalHours.ToString("0.00") + " hour" + ((TimeDifference.TotalHours > 1) ? "s" : "");
                            }
                            else
                            {
                                TimeString = $"{TimeDifference.Days} day{ ((TimeDifference.Days > 1) ? "s" : "")} { TimeDifference.Hours} hour{((TimeDifference.Hours > 1) ? "s" : "")}";
                            }

                            if (LastAppointment.Person.IsDefaultPerson() && LastAppointment.Location == DefaultLocationEnum.Service.GetEnumName())
                            {
                                Available = false;
                                Color = Color.Yellow;
                                Situation = $"Car is ready for {TimeString} at {DefaultLocationEnum.Service.GetEnumName()}";
                            }
                            else
                            {
                                Available = false;
                                Color = Color.Orange;
                                Situation = $"Car should be brought by {LastAppointment.Person.Fullname} for {TimeString}";
                            }
                        }
                    }
                    else
                    {
                        Available = false;
                        Color = Color.White;
                        Situation = $"There is no information";
                    }
                }
            }
        }

        public Car() : this("", TyreTypeEnum.Summer, DateTime.Now, LeasingCompanyEnum.Autoever, ViegnetteEnum.Unavailable, "") { }

        public Car(string Plate, TyreTypeEnum TyreType, DateTime TUVDate, LeasingCompanyEnum LeasingCompany, ViegnetteEnum Viegnette, string Comment)
        {
            this.Plate = Plate;
            this.TyreType = TyreType;
            this.TUVDate = TUVDate;
            this.LeasingCompany = LeasingCompany;
            this.Viegnette = Viegnette;
            this.Comment = Comment;
            this.Appointments = new BindingList<Appointment>();
        }

        public static string[] Titles = new string[]
        {
            "Plate",
            "Tyre Type",
            "TUV Date",
            "Leasing Company",
            "Viegnette",
            "Comment",
            "Available",
            "Situation"
        };

        public string[] ToStringArray() => new string[]
        {
            this.Plate,
            this.TyreType.ToString(),
            this.TUVDate.ToString(GeneralDateTimeStringFormat),
            this.LeasingCompany.ToString(),
            this.Viegnette.ToString(),
            this.Comment,
            this.Available.ToString(),
            this.Situation
        };
    }

    public class Person
    {
        public string Fullname => Name + " " + Surname;
        public string Name;
        public string Surname;
        public string PhoneNumber;
        public string Address;
        public string Comment;

        public Person() : this("", "", "", "", "") { }

        public Person(string Name, string Surname, string PhoneNumber, string Address, string Comment)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Comment = Comment;
        }

        public static bool operator ==(Person Person1, Person Person2) =>
            Person1?.Name == Person2?.Name &&
            Person1?.Surname == Person2?.Surname &&
            Person1?.PhoneNumber == Person2?.PhoneNumber;


        public static bool operator !=(Person Person1, Person Person2) => !(Person1 == Person2);

        public static string[] Titles = new string[]
        {
            "Name",
            "Surname",
            "Phone Number",
            "Address",
            "Comment"
        };

        public string[] ToStringArray() => new string[]
        {
            this.Name,
            this.Surname,
            this.PhoneNumber,
            this.Address,
            this.Comment
        };
    }

    public class DateInformation
    {
        public DateTime Time;
        public float DrivingDistance;
        public float Fuel;

        public DateInformation() : this(DateTime.MinValue, 0, 0) { }

        public DateInformation(DateTime Time, float DrivingDistance, float Fuel)
        {
            this.Time = Time;
            this.DrivingDistance = DrivingDistance;
            this.Fuel = Fuel;
        }
    }
    public class Appointment
    {
        public DateInformation StartDateInformation;
        public DateInformation EndDateInformation;
        public Person Person;
        public string Location;
        public string Comment;

        public Appointment() : this(new DateInformation(), new DateInformation(), new Person(), "", "") { }

        public Appointment(DateInformation StartDateInformation, DateInformation EndDateInformation, Person Person, string Location, string Comment)
        {
            this.StartDateInformation = StartDateInformation;
            this.EndDateInformation = EndDateInformation;
            this.Person = Person;
            this.Location = Location;
            this.Comment = Comment;
        }

        public static string[] Titles = new string[]
        {
            "Start Date",
            "End Date",
            "Start DrivingDistance",
            "End DrivingDistance",
            "Start Fuel",
            "End Fuel",
            "Person Name",
            "Person Surname",
            "Person Phone Number",
            "Location",
            "Comment"
        };

        public string[] ToStringArray() => new string[]
        {
            this.StartDateInformation.Time.ToString(GeneralDateTimeStringFormat),
            this.EndDateInformation.Time.ToString(GeneralDateTimeStringFormat),
            this.StartDateInformation.DrivingDistance.ToString(),
            this.EndDateInformation.DrivingDistance.ToString(),
            this.StartDateInformation.Fuel.ToString(),
            this.EndDateInformation.Fuel.ToString(),
            this.Person.Name,
            this.Person.Surname,
            this.Person.PhoneNumber,
            this.Location,
            this.Comment
        };
    }
}