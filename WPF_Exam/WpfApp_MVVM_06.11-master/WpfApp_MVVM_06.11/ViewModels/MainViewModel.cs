using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp_MVVM_06._11.Commands;
using WpfApp_MVVM_06._11.Models;
using WpfApp_MVVM_06._11.Views;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;

namespace WpfApp_MVVM_06._11.ViewModels
{
    public class MainViewModel:ViewModel_Base
    {
        public ObservableCollection<SummaryModel> summaryModels { get; set; }

        private static readonly DependencyProperty SelectedSummaryItemProperty;

        private static readonly DependencyProperty VacancyProperty;
        private static readonly DependencyProperty FullNameProperty;
        private static readonly DependencyProperty AgeProperty;
        private static readonly DependencyProperty MaritalStatusProperty;
        private static readonly DependencyProperty AddressProperty;
        private static readonly DependencyProperty EmailProperty;
        private static readonly DependencyProperty ContactsProperty;
        private static readonly DependencyProperty EnglishProperty;
        private static readonly DependencyProperty ArmenianProperty;
        private static readonly DependencyProperty GermanProperty;
        private static readonly DependencyProperty SpanishProperty;
        private static readonly DependencyProperty JapaneseProperty;
        private static readonly DependencyProperty ArabicProperty;
        private static readonly DependencyProperty SwedishProperty;
        private static readonly DependencyProperty JavaProperty;
        private static readonly DependencyProperty JavaScriptProperty;
        private static readonly DependencyProperty CSharpProperty;
        private static readonly DependencyProperty PHPProperty;
        private static readonly DependencyProperty KotlinProperty;
        private static readonly DependencyProperty SwiftProperty;
        private static readonly DependencyProperty PythonProperty;
        private static readonly DependencyProperty TestingProperty;
        private static readonly DependencyProperty CloudServicesProperty;
        private static readonly DependencyProperty MobileDevelopmentProperty;
        private static readonly DependencyProperty ArchitecturalPatternsProperty;
        private static readonly DependencyProperty VersionControlSystemsProperty;
        private static readonly DependencyProperty DatabasesProperty;
        private static readonly DependencyProperty WebFrameworksProperty;
        private static readonly DependencyProperty TechnicalSkillsDevelopmentProperty;
        private static readonly DependencyProperty ProjectManagementProperty;
        private static readonly DependencyProperty LeadershipProperty;
        private static readonly DependencyProperty NewTechnologySpecializationProperty;
        private static readonly DependencyProperty BusinessAnalyticsSkillsDevelopmentProperty;
        private static readonly DependencyProperty MoreThan5YearsExperienceProperty;
        private static readonly DependencyProperty ThreeToFiveYearsExperienceProperty;
        private static readonly DependencyProperty OneToThreeYearsExperienceProperty;
        private static readonly DependencyProperty LessThanOneYearExperienceProperty;
        private static readonly DependencyProperty NoExperienceProperty;
        private static readonly DependencyProperty AdditionalInformationProperty;


        static MainViewModel()
        {
           VacancyProperty = DependencyProperty.Register("Vacancy", typeof(string), typeof(MainViewModel));
           FullNameProperty = DependencyProperty.Register("FullName", typeof(string), typeof(MainViewModel));
           MaritalStatusProperty = DependencyProperty.Register("MaritalStatus", typeof(string), typeof(MainViewModel));
           AddressProperty = DependencyProperty.Register("Address", typeof(string), typeof(MainViewModel));
           EmailProperty = DependencyProperty.Register("Email", typeof(string), typeof(MainViewModel));
           ContactsProperty = DependencyProperty.Register("Contacts", typeof(string), typeof(MainViewModel));
           AdditionalInformationProperty = DependencyProperty.Register("AdditionalInformation", typeof(string), typeof(MainViewModel));
           AgeProperty = DependencyProperty.Register("Age", typeof(int), typeof(MainViewModel));
           EnglishProperty = DependencyProperty.Register("English", typeof(bool), typeof(MainViewModel));
           ArmenianProperty = DependencyProperty.Register("Armenian", typeof(bool), typeof(MainViewModel));
           GermanProperty = DependencyProperty.Register("German", typeof(bool), typeof(MainViewModel));
           SpanishProperty = DependencyProperty.Register("Spanish", typeof(bool), typeof(MainViewModel));
           JapaneseProperty = DependencyProperty.Register("Japanese", typeof(bool), typeof(MainViewModel));
           ArabicProperty = DependencyProperty.Register("Arabic", typeof(bool), typeof(MainViewModel));
           SwedishProperty = DependencyProperty.Register("Swedish", typeof(bool), typeof(MainViewModel));
           JavaProperty = DependencyProperty.Register("Java", typeof(bool), typeof(MainViewModel));
           JavaScriptProperty = DependencyProperty.Register("JavaScript", typeof(bool), typeof(MainViewModel));
           CSharpProperty = DependencyProperty.Register("CSharp", typeof(bool), typeof(MainViewModel));
           PHPProperty = DependencyProperty.Register("PHP", typeof(bool), typeof(MainViewModel));
           KotlinProperty = DependencyProperty.Register("Kotlin", typeof(bool), typeof(MainViewModel));
           SwiftProperty = DependencyProperty.Register("Swift", typeof(bool), typeof(MainViewModel));
           PythonProperty = DependencyProperty.Register("Python", typeof(bool), typeof(MainViewModel));
           TestingProperty = DependencyProperty.Register("Testing", typeof(bool), typeof(MainViewModel));
           CloudServicesProperty = DependencyProperty.Register("CloudServices", typeof(bool), typeof(MainViewModel));
           MobileDevelopmentProperty = DependencyProperty.Register("MobileDevelopment", typeof(bool), typeof(MainViewModel));
           ArchitecturalPatternsProperty = DependencyProperty.Register("ArchitecturalPatterns", typeof(bool), typeof(MainViewModel));
           VersionControlSystemsProperty = DependencyProperty.Register("VersionControlSystems", typeof(bool), typeof(MainViewModel));
           DatabasesProperty = DependencyProperty.Register("Databases", typeof(bool), typeof(MainViewModel));
           WebFrameworksProperty = DependencyProperty.Register("WebFrameworks", typeof(bool), typeof(MainViewModel));
           TechnicalSkillsDevelopmentProperty = DependencyProperty.Register("TechnicalSkillsDevelopment", typeof(bool), typeof(MainViewModel));
           ProjectManagementProperty = DependencyProperty.Register("ProjectManagement", typeof(bool), typeof(MainViewModel));
           LeadershipProperty = DependencyProperty.Register("Leadership", typeof(bool), typeof(MainViewModel));
           NewTechnologySpecializationProperty = DependencyProperty.Register("NewTechnologySpecialization", typeof(bool), typeof(MainViewModel));
           BusinessAnalyticsSkillsDevelopmentProperty = DependencyProperty.Register("BusinessAnalyticsSkillsDevelopment", typeof(bool), typeof(MainViewModel));
           MoreThan5YearsExperienceProperty = DependencyProperty.Register("MoreThan5YearsExperience", typeof(bool), typeof(MainViewModel));
           ThreeToFiveYearsExperienceProperty = DependencyProperty.Register("ThreeToFiveYearsExperience", typeof(bool), typeof(MainViewModel));
           OneToThreeYearsExperienceProperty = DependencyProperty.Register("OneToThreeYearsExperience", typeof(bool), typeof(MainViewModel));
           LessThanOneYearExperienceProperty = DependencyProperty.Register("LessThanOneYearExperience", typeof(bool), typeof(MainViewModel));
           NoExperienceProperty = DependencyProperty.Register("NoExperience", typeof(bool), typeof(MainViewModel));
           SelectedSummaryItemProperty = DependencyProperty.Register("SelectedSummary", typeof(SummaryModel), typeof(MainViewModel));
        }

        public MainViewModel()
        {
            summaryModels = new ObservableCollection<SummaryModel>();
            summaryModels.Add(new SummaryModel("Front-End", "Petro", 19, "YourMaritalStatus", "YourAddress", "popov911petia@gmail.com", "06432732", true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,""));
            LoadData();
        }

        private void SaveData()
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(summaryModels);
                File.WriteAllText("SummaryData.json", jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists("SummaryData.json"))
                {
                    string jsonData = File.ReadAllText("SummaryData.json");
                    summaryModels = JsonConvert.DeserializeObject<ObservableCollection<SummaryModel>>(jsonData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private ICommand _addPhotoCommand;

        public ICommand AddPhotoCommand
        {
            get
            {
                if (_addPhotoCommand == null)
                {
                    _addPhotoCommand = new DelegatesCommand(ExecuteAddPhotoCommand);
                }
                return _addPhotoCommand;
            }
        }

        private void ExecuteAddPhotoCommand(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                // Здесь вы можете использовать imagePath или загрузить его в Image
                LoadImage(imagePath);
            }
        }

        private void LoadImage(string imagePath)
        {
            // Загрузка изображения в Image
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath);
            bitmap.EndInit();

        }
        public SummaryModel SelectedSummary
        {
            get { return (SummaryModel)GetValue(SelectedSummaryItemProperty); }
            set { SetValue(SelectedSummaryItemProperty, value); }
        }
        public string Vacancy
        {
            get { return (string)GetValue(VacancyProperty); }
            set { SetValue(VacancyProperty, value); }
        }

        public string FullName
        {
            get { return (string)GetValue(FullNameProperty); }
            set { SetValue(FullNameProperty, value); }
        }

        public string MaritalStatus
        {
            get { return (string)GetValue(MaritalStatusProperty); }
            set { SetValue(MaritalStatusProperty, value); }
        }

        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }
        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }
        public string Contacts
        {
            get { return (string)GetValue(ContactsProperty); }
            set { SetValue(ContactsProperty, value); }
        }

        public string AdditionalInformation 
        {
            get { return (string)GetValue(AdditionalInformationProperty); }
            set { SetValue(AdditionalInformationProperty, value); }
        }

        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }
        public bool English
        {
            get { return (bool)GetValue(EnglishProperty); }
            set { SetValue(EnglishProperty, value); }
        }
        public bool Armenian
        {
            get { return (bool)GetValue(ArmenianProperty); }
            set { SetValue(ArmenianProperty, value); }
        }
        public bool German
        {
            get { return (bool)GetValue(GermanProperty); }
            set { SetValue(GermanProperty, value); }
        }

        public bool Spanish
        {
            get { return (bool)GetValue(SpanishProperty); }
            set { SetValue(SpanishProperty, value); }
        }

        public bool Japanese
        {
            get { return (bool)GetValue(JapaneseProperty); }
            set { SetValue(JapaneseProperty, value); }
        }

        public bool Arabic
        {
            get { return (bool)GetValue(ArabicProperty); }
            set { SetValue(ArabicProperty, value); }
        }
    
        public bool Swedish
        {
            get { return (bool)GetValue(SwedishProperty); }
            set { SetValue(SwedishProperty, value); }
        }

        public bool Java 
        {
            get { return (bool)GetValue(JavaProperty); }
            set { SetValue(JavaProperty, value); }
        }

        public bool JavaScript
        {
            get { return (bool)GetValue(JavaScriptProperty); }
            set { SetValue(JavaScriptProperty, value); }
        }

        public bool CSharp
        {
            get { return (bool)GetValue(CSharpProperty); }
            set { SetValue(CSharpProperty, value); }
        }

        public bool PHP
        {
            get { return (bool)GetValue(PHPProperty); }
            set { SetValue(PHPProperty, value); }
        }

        public bool Kotlin
        {
            get { return (bool)GetValue(KotlinProperty); }
            set { SetValue(KotlinProperty, value); }
        }

        public bool Swift
        {
            get { return (bool)GetValue(SwiftProperty); }
            set { SetValue(SwiftProperty, value); }
        }

        public bool Python
        {
            get { return (bool)GetValue(PythonProperty); }
            set { SetValue(PythonProperty, value); }
        }

        public bool Testing
        {
            get { return (bool)GetValue(TestingProperty); }
            set { SetValue(TestingProperty, value); }
        }

        public bool CloudServices
        {
            get { return (bool)GetValue(CloudServicesProperty); }
            set { SetValue(CloudServicesProperty, value); }
        }

        public bool MobileDevelopment
        {
            get { return (bool)GetValue(MobileDevelopmentProperty); }
            set { SetValue(MobileDevelopmentProperty, value); }
        }

        public bool ArchitecturalPatterns
        {
            get { return (bool)GetValue(ArchitecturalPatternsProperty); }
            set { SetValue(ArchitecturalPatternsProperty, value); }
        }

        public bool VersionControlSystems
        {
            get { return (bool)GetValue(VersionControlSystemsProperty); }
            set { SetValue(VersionControlSystemsProperty, value); }
        }

        public bool Databases
        {
            get { return (bool)GetValue(DatabasesProperty); }
            set { SetValue(DatabasesProperty, value); }
        }

        public bool WebFrameworks
        {
            get { return (bool)GetValue(WebFrameworksProperty); }
            set { SetValue(WebFrameworksProperty, value); }
        }
        public bool TechnicalSkillsDevelopment
        {
            get { return (bool)GetValue(TechnicalSkillsDevelopmentProperty); }
            set { SetValue(TechnicalSkillsDevelopmentProperty, value); }
        }

        public bool ProjectManagement
        {
            get { return (bool)GetValue(ProjectManagementProperty); }
            set { SetValue(ProjectManagementProperty, value); }
        }

        public bool Leadership
        {
            get { return (bool)GetValue(LeadershipProperty); }
            set { SetValue(LeadershipProperty, value); }
        }

        public bool NewTechnologySpecialization
        {
            get { return (bool)GetValue(NewTechnologySpecializationProperty); }
            set { SetValue(NewTechnologySpecializationProperty, value); }
        }

        public bool BusinessAnalyticsSkillsDevelopment
        {
            get { return (bool)GetValue(BusinessAnalyticsSkillsDevelopmentProperty); }
            set { SetValue(BusinessAnalyticsSkillsDevelopmentProperty, value); }
        }

        public bool MoreThan5YearsExperience
        {
            get { return (bool)GetValue(MoreThan5YearsExperienceProperty); }
            set { SetValue(MoreThan5YearsExperienceProperty, value); }
        }

        public bool ThreeToFiveYearsExperience
        {
            get { return (bool)GetValue(ThreeToFiveYearsExperienceProperty); }
            set { SetValue(ThreeToFiveYearsExperienceProperty, value); }
        }

        public bool OneToThreeYearsExperience
        {
            get { return (bool)GetValue(OneToThreeYearsExperienceProperty); }
            set { SetValue(OneToThreeYearsExperienceProperty, value); }
        }

        public bool LessThanOneYearExperience
        {
            get { return (bool)GetValue(LessThanOneYearExperienceProperty); }
            set { SetValue(LessThanOneYearExperienceProperty, value); }
        }

        public bool NoExperience
        {
            get { return (bool)GetValue(NoExperienceProperty); }
            set { SetValue(NoExperienceProperty, value); }
        }

        DelegatesCommand showInformation;
        public ICommand ShowInformation
        {
            get
            {
                if (showInformation == null)
                    showInformation = new DelegatesCommand(ShowSummary, CanShowSummary);
                return showInformation;
            }
        }

        private bool _isPhotoLoaded;
        public bool IsPhotoLoaded
        {
            get { return _isPhotoLoaded; }
            set
            {
                if (_isPhotoLoaded != value)
                {
                    _isPhotoLoaded = value;
                    OnPropertyChanged(nameof(IsPhotoLoaded));
                }
            }
        }

        private ImageSource _yourImageSourceProperty;
        public ImageSource YourImageSourceProperty
        {
            get { return _yourImageSourceProperty; }
            set
            {
                if (_yourImageSourceProperty != value)
                {
                    _yourImageSourceProperty = value;
                    OnPropertyChanged(nameof(YourImageSourceProperty));
                }
            }
        }

        private DelegatesCommand _loadPhotoCommand;
        public ICommand LoadPhotoCommand
        {
            get
            {
                if (_loadPhotoCommand == null)
                {
                    _loadPhotoCommand = new DelegatesCommand(LoadPhoto, CanLoadPhoto);
                }
                return _loadPhotoCommand;
            }
        }

        private void LoadPhoto(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*",
                Title = "Выберите изображение"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;

                // Создаем объект BitmapImage и устанавливаем его в качестве источника изображения
                BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath));

                // Обновляем свойство, которое привязано к источнику изображения
                YourImageSourceProperty = bitmapImage;

                // Обновляем свойство, показывающее, что изображение загружено
                IsPhotoLoaded = true;
            }
            else
            {
                // Если пользователь отменил выбор файла, обновляем свойство, показывающее, что изображение не загружено
                IsPhotoLoaded = false;
            }
        }

        private bool CanLoadPhoto(object obj)
        {
            // Возвращаем true, если изображение не загружено
            return !IsPhotoLoaded;
        }

        private bool CanShowSummary(object obj)
        {
            if (SelectedSummary!=null)
            {
                return true;
            }
            return false;
        }

        private void ShowSummary(object obj)
        {
            try
            {
                SummaryView summaryView = new SummaryView();
                SummaryViewModel viewModel = new SummaryViewModel(SelectedSummary);

                summaryView.DataContext = viewModel;
                summaryView.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошло исключение: {ex.Message}");
            }
        }

        DelegatesCommand saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                    saveCommand = new DelegatesCommand(SaveSummary, CanSaveSummary);
                return saveCommand;
            }
        }

        DelegatesCommand clearsummary;
        public ICommand Clearsummary
        {
            get 
            {
                if (clearsummary == null)
                    clearsummary = new DelegatesCommand(ClearSummary, CanClearSummary);
                return clearsummary;
            }
        }
        private bool CanClearSummary(object obj)
        {
            return true;
        }
        private void ClearSummary(object obj)
        {
                Vacancy = string.Empty;
                FullName = string.Empty;
                Age = 0;
                MaritalStatus = string.Empty;
                Address = string.Empty;
                Email = string.Empty;
                Contacts = string.Empty;
                English = false;
                Armenian = false;
                Spanish = false;
                German = false;
                Japanese = false;
                Arabic = false;
                Swedish = false;
                Java = false;
                JavaScript = false;
                CSharp = false;
                PHP = false;
                Kotlin = false;
                Swift = false;
                Python = false;
                Testing = false;
                CloudServices = false;
                MobileDevelopment = false;
                ArchitecturalPatterns = false;
                VersionControlSystems = false;
                Databases = false;
                WebFrameworks = false;
                TechnicalSkillsDevelopment = false;
                ProjectManagement = false;
                Leadership = false;
                NewTechnologySpecialization = false;
                BusinessAnalyticsSkillsDevelopment = false;
                MoreThan5YearsExperience = false;
                ThreeToFiveYearsExperience = false;
                OneToThreeYearsExperience = false;
                LessThanOneYearExperience = false;
                NoExperience = false;
               AdditionalInformation = string.Empty;

        }
        private bool CanSaveSummary(object obj)
        {
            if (FullName == null || FullName.Length<2)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void SaveSummary(object obj)
        {
            summaryModels.Add(new SummaryModel(Vacancy, FullName, Age, MaritalStatus, Address, Email, Contacts,
            English, Armenian, German, Spanish, Japanese, Arabic, Swedish,
            Java, JavaScript, CSharp, PHP, Kotlin, Swift, Python,
            Testing, CloudServices, MobileDevelopment, ArchitecturalPatterns,
            VersionControlSystems, Databases, WebFrameworks,
            TechnicalSkillsDevelopment, ProjectManagement, Leadership,
            NewTechnologySpecialization, BusinessAnalyticsSkillsDevelopment,
            MoreThan5YearsExperience, ThreeToFiveYearsExperience,
            OneToThreeYearsExperience, LessThanOneYearExperience, NoExperience,
            AdditionalInformation));

            SaveData();
            MessageBox.Show("Информация успешно сохранена", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
