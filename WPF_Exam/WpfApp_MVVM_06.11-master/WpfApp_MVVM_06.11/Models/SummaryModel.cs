using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_MVVM_06._11.Models
{
    public class SummaryModel
    {
        public string Vacancy { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contacts { get; set; }

        public bool English { get; set; }
        public bool Armenian { get; set; }
        public bool German { get; set; }
        public bool Spanish { get; set; }
        public bool Japanese { get; set; }
        public bool Arabic { get; set; }
        public bool Swedish { get; set; }

        public bool Java { get; set; }
        public bool JavaScript { get; set; }
        public bool CSharp { get; set; }
        public bool PHP { get; set; }
        public bool Kotlin { get; set; }
        public bool Swift { get; set; }
        public bool Python { get; set; }

        public bool Testing { get; set; }
        public bool CloudServices { get; set; }
        public bool MobileDevelopment { get; set; }
        public bool ArchitecturalPatterns { get; set; }
        public bool VersionControlSystems { get; set; }
        public bool Databases { get; set; }
        public bool WebFrameworks { get; set; }

        public bool TechnicalSkillsDevelopment { get; set; }
        public bool ProjectManagement { get; set; }
        public bool Leadership { get; set; }
        public bool NewTechnologySpecialization { get; set; }
        public bool BusinessAnalyticsSkillsDevelopment { get; set; }

        public bool MoreThan5YearsExperience { get; set; }
        public bool ThreeToFiveYearsExperience { get; set; }
        public bool OneToThreeYearsExperience { get; set; }
        public bool LessThanOneYearExperience { get; set; }
        public bool NoExperience { get; set; }

        public string AdditionalInformation { get; set; }

        public SummaryModel(string vacancy, string fullName, int age, string maritalStatus, string address, string email, string contacts,
            bool english, bool armenian, bool german, bool spanish, bool japanese, bool arabic, bool swedish,
            bool java, bool javaScript, bool cSharp, bool php, bool kotlin, bool swift, bool python,
            bool testing, bool cloudServices, bool mobileDevelopment, bool architecturalPatterns, bool versionControlSystems, bool databases, bool webFrameworks,
            bool technicalSkillsDevelopment, bool projectManagement, bool leadership, bool newTechnologySpecialization, bool businessAnalyticsSkillsDevelopment,
            bool moreThan5YearsExperience, bool threeToFiveYearsExperience, bool oneToThreeYearsExperience, bool lessThanOneYearExperience, bool noExperience,
            string additionalInformation)
        {
            Vacancy = vacancy;
            FullName = fullName;
            Age = age;
            MaritalStatus = maritalStatus;
            Address = address;
            Email = email;
            Contacts = contacts;

            English = english;
            Armenian = armenian;
            German = german;
            Spanish = spanish;
            Japanese = japanese;
            Arabic = arabic;
            Swedish = swedish;

            Java = java;
            JavaScript = javaScript;
            CSharp = cSharp;
            PHP = php;
            Kotlin = kotlin;
            Swift = swift;
            Python = python;

            Testing = testing;
            CloudServices = cloudServices;
            MobileDevelopment = mobileDevelopment;
            ArchitecturalPatterns = architecturalPatterns;
            VersionControlSystems = versionControlSystems;
            Databases = databases;
            WebFrameworks = webFrameworks;

            TechnicalSkillsDevelopment = technicalSkillsDevelopment;
            ProjectManagement = projectManagement;
            Leadership = leadership;
            NewTechnologySpecialization = newTechnologySpecialization;
            BusinessAnalyticsSkillsDevelopment = businessAnalyticsSkillsDevelopment;

            MoreThan5YearsExperience = moreThan5YearsExperience;
            ThreeToFiveYearsExperience = threeToFiveYearsExperience;
            OneToThreeYearsExperience = oneToThreeYearsExperience;
            LessThanOneYearExperience = lessThanOneYearExperience;
            NoExperience = noExperience;

            AdditionalInformation = additionalInformation;
        }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }

}
