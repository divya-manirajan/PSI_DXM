/**
 * This sets up the GUI to calculate the PSI for patients
 * @author Divya Manirajan
 * @version 1.0
 * GUI Programming Project 2 PSI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Programming_Project_2___PSI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //creates a variable to hold the ID# that appears in the data.csv file at the beginning of the
        //until the program is fully closed
        int id = 1;

        /**
         * This method activates when the calculate button is clicked to total up the score and show 
         * the results to the screen via message box as well as appending it to a file named data.csv
         */
        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            //creates variables for each text box in the GUI that a number is entered 
            double age, respiratoryRate, systolicBloodPressure, temperature, pulse,
                hematocrit, pH, BUN, sodium, glucose, partialPressureOxygen;

            //creates variables for variables that need a string 
            String sex, result = "";

            //creates boolean variables for all checkbox values
            bool nursingHomeResident, neoplasticDisease, liverDisease,
                congestiveHeartFailure, cerebrovascularDisease, renalDisease,
                alteredMentalStatus, pleuralEffusion;
            
            //For following if statements: boolean values for each checkbox are set to either true of false depending on if the coreresponding checkbox is checked or unchecked

            //If statement to determine if patient is a nursing home resident
            if (chk_NursingHomeResident.IsChecked == true)
            {
                nursingHomeResident = true;
            }
            else
            {
                nursingHomeResident = false;
            }

            //If statement to determine if patient has neoplastic disease
            if (chk_NeoplasticDisease.IsChecked == true)
            {
                neoplasticDisease = true;
            }
            else
            {
                neoplasticDisease = false;
            }

            //If statement to determine if patient has liver disease
            if (chk_LiverDisease.IsChecked == true)
            {
                liverDisease = true;
            }
            else
            {
                liverDisease = false;
            }

            //If statement to determine if patient has congestive heart failure
            if (chk_CongestiveHeartFailure.IsChecked == true)
            {
                congestiveHeartFailure = true;
            }
            else
            {
                congestiveHeartFailure = false;
            }

            //If statement to determine if patient has cerebrovascular disease
            if (chk_CerebrovascularDisease.IsChecked == true)
            {
                cerebrovascularDisease = true;
            }
            else
            {
                cerebrovascularDisease = false;
            }

            //If statement to determine if patient has renal disease
            if (chk_RenalDisease.IsChecked == true)
            {
                renalDisease = true;
            }
            else
            {
                renalDisease = false;
            }

            //If statement to determine if patient has altered mental status
            if (chk_AlteredMentalStatus.IsChecked == true)
            {
                alteredMentalStatus = true;
            }
            else
            {
                alteredMentalStatus = false;
            }

            //If statement to determine if patient has pleural effusion in X-Rays
            if (chk_PleuralEffusion.IsChecked == true)
            {
                pleuralEffusion = true;
            }
            else
            {
                pleuralEffusion = false;
            }

            //Following if statements set all text box values to corresponding string or double values
            //If text boxes are empty then the values are set to 0 and the result message appends what variable is empty


            //If statement to set the age to what is entered
            if (txt_Age.Text.Equals(""))
            {
                age = 0;
                result += "Age is empty.";
            }
            else
            {
                age = Double.Parse(txt_Age.Text);
            }

            //If statement to set the sex to what is entered
            if (txt_Sex.Text.Equals(""))
            {
                sex = "";
                result += "\nSex field is empty.";
            }
            else
            {
                sex = txt_Sex.Text;

            }

            //If statement to set the respiratory rate to what is entered
            if (txt_RespiratoryRate.Text.Equals(""))
            {
                respiratoryRate = 0;
                result += "\nRespiratory Rate is empty.";
            }
            else
            {
                respiratoryRate = Double.Parse(txt_RespiratoryRate.Text);
            }

            //If statement to set the systolic blood pressure to what is entered
            if (txt_Systolic_Blood_Pressure.Text.Equals(""))
            {
                systolicBloodPressure = 0;
                result += "\nSystolic Blood Pressure is empty.";
            }
            else
            {
                systolicBloodPressure = Double.Parse(txt_Systolic_Blood_Pressure.Text);

            }

            //If statement to set the temperature to what is entered
            if (txt_Temperature.Text.Equals(""))
            {
                temperature = 0;
                result += "\nTemperature is empty.";
            }
            else
            {
                temperature = Double.Parse(txt_Temperature.Text);
            }

            //If statement to set the pulse to what is entered
            if (txt_Pulse.Text.Equals(""))
            {
                pulse = 0;
                result += "\nPulse is empty.";
            }
            else
            {
                pulse = Double.Parse(txt_Pulse.Text);
            }

            //If statement to set the hematocrit to what is entered
            if (txt_Hematocrit.Text.Equals(""))
            {
                hematocrit = 0;
                result += "\nHematocrit is empty.";
            }
            else
            {
                hematocrit = Double.Parse(txt_Hematocrit.Text);
            }

            //If statement to set the pH to what is entered
            if (txt_pH.Text.Equals(""))
            {
                pH = 0;
                result += "\npH is empty.";
            }
            else
            {
                pH = Double.Parse(txt_pH.Text);
            }

            //If statement to set the BUN to what is entered
            if (txt_BUN.Text.Equals(""))
            {
                BUN = 0;
                result += "\nBUN is empty.";
            }
            else
            {
                BUN = Double.Parse(txt_BUN.Text);
            }

            //If statement to set the Sodium to what is entered
            if (txt_Sodium.Text.Equals(""))
            {
                sodium = 0;
                result += "\nSodium is empty.";
            }
            else
            {
                sodium = Double.Parse(txt_Sodium.Text);
            }

            //If statement to set the glucose to what is entered
            if (txt_Glucose.Text.Equals(""))
            {
                glucose = 0;
                result += "\nGlucose is empty.";
            }
            else
            {
                glucose = Double.Parse(txt_Glucose.Text);
            }

            //If statement to set the partial pressure of oxygen to what is entered
            if (txt_PartialPressureOxygen.Text.Equals(""))
            {
                partialPressureOxygen = 0;
                result += "\nPartial Pressure of Oxygen is empty.";
            }
            else
            {
                partialPressureOxygen = Double.Parse(txt_PartialPressureOxygen.Text);
            }

            //Once all information is entered and stored the calculation for the score begins

            //double value to count up the point value
            double score = 0;

            //adds the age to the score
            score += age;

            //removes 10 from score if patient is female
            if (sex.Equals("F"))
            {
                score -= 10;
            }

            //adds 10 points to score if patient is a nursing home resident
            if (nursingHomeResident)
            {
                score += 10;
            }

            //adds 30 points to score if patient has neoplastic disease
            if (neoplasticDisease)
            {
                score += 30;
            }

            //adds 20 points to score if patient has liver disease
            if (liverDisease)
            {
                score += 20;
            }

            //adds 10 points to score if patient has congestive heart failure
            if (congestiveHeartFailure)
            {
                score += 10;
            }

            //adds 10 points to score if patient has cerebrovascular disease
            if (cerebrovascularDisease)
            {
                score += 10;
            }

            //adds 10 points to score if patient has renal disease
            if (renalDisease)
            {
                score += 10;
            }

            //adds 20 points to score if patient has altered mental status
            if (alteredMentalStatus)
            {
                score += 20;
            }

            //adds 20 points to score if respiratory rate is >=30
            if (respiratoryRate >= 30)
            {
                score += 20;
            }
            
            //adds 20 points to score is systolic blood pressure is < 90
            if (systolicBloodPressure < 90)
            {
                score += 20;
            }

            //converts temperature to celsius if entered in fahrenheit
            if (radBut_Fahrenheit.IsChecked == true)
            {
                temperature = (temperature - 32) * (double) 5 / 9;
                
            }

            //adds 15 points to score if temperature is < 35 or >39.9
            if (temperature < 35 || temperature > 39.9)
            {
                score += 15;
            }

            //adds 10 points to score if pulse is >= 125
            if (pulse >= 125)
            {
                score += 10;
            }

            //adds 30 points to score if pH < 7.35
            if (pH < 7.35)
            {
                score += 30;
            }

            //converts BUN to md/dL if entered in mmol/L
            if (radBut_BUN_mmolL.IsChecked == true)
            {
                BUN = BUN * 2.8;
            }

            //adds 20 points to score if BUN >= 30
            if (BUN >= 30)
            {
                score += 20;
            }

            //adds 20 points to score if sodium < 130
            if (sodium < 130)
            {
                score += 20;
            }

            //converts glucose to mg/dL if entered in mmol/L
            if (radBut_Glucose_mmolL.IsChecked == true)
            {
                glucose = glucose * 18;
            }

            //adds 10 points to score if glucose is >= 250
            if (glucose >= 250)
            {
                score += 10;
            }

            //adds 10 points to score if hematocrit is < 30
            if (hematocrit < 30)
            {
                score += 10;
            }

            //converts partial pressure of oxygen to mmHg if entered in kPa
            if (radBut_PartialPressureOxygen_kPa.IsChecked == true)
            {
                partialPressureOxygen = partialPressureOxygen * 7.501;
            }

            //adds 10 points to score if partial pressure of oxygen is < 60
            if (partialPressureOxygen < 60)
            {
                score += 10;
            }

            //adds 10 points to score if patient has pleural Effusion on X-Ray
            if (pleuralEffusion)
            {
                score += 10;
            }
            
            //Once score is calculated the result is determined

            //Result is determined for each risk class based on the score 
            //Result shows the risk class, the risk, the score, the admission status
            if (score == 0)
            {
                result += "\nRisk Class: 1" +
                    "\nRisk: Low" +
                    "\nPoint Value: " + score +
                    "\nAdmisstion Status: Outpatient Care";
            }
            if (score <= 70)
            {
                result += "\nRisk Class: 2" +
                    "\nRisk: Low" +
                    "\nPoint Value: " + score +
                    "\nAdmisstion Status: Outpatient Care";
            }
            if (score >= 71 && score <= 90)
            {
                result += "\nRisk Class: 3" +
                    "\nRisk: Low" +
                    "\nPoint Value: " + score +
                    "\nAdmisstion Status: Outpatient or Observation Admission";
            }
            if (score >= 91 && score <= 130)
            {
                result += "\nRisk Class: 4" +
                    "\nRisk: Moderate" +
                    "\nPoint Value: " + score +
                    "\nAdmisstion Status: Inpatient Admission";
            }
            if (score > 130)
            {
                result += "\nRisk Class: 5" +
                    "\nRisk: High" +
                    "\nPoint Value: " + score +
                    "\nAdmisstion Status: Inpatient Admission (check for sepsis)";
            }

           //A message box pops up showing the final result
           MessageBox.Show(result.ToString(), "Results", MessageBoxButton.OK, MessageBoxImage.Information);

          //creates a string variable to hold the file name and sets it to data.csv
            string fileName = "data.csv";

            //creates a string variable to hold all data that will be entered into the file
            string dataResult = id+", "+age+", "+sex+", "+Convert.ToByte(nursingHomeResident)+", "+Convert.ToByte(neoplasticDisease)+", "+
                Convert.ToByte(liverDisease)+", "+Convert.ToByte(congestiveHeartFailure)+", "+Convert.ToByte(cerebrovascularDisease)+", "+
                Convert.ToByte(renalDisease)+", "+Convert.ToByte(alteredMentalStatus)+", "+Convert.ToByte(pleuralEffusion)+", "+respiratoryRate+", "+
                systolicBloodPressure+", "+temperature+", "+pulse+", "+hematocrit+", "+pH+", "+BUN+", "+sodium+", "+glucose+", "+partialPressureOxygen+"\n"; 

            //appends the dataResult into the fileName file each time the calculate button is clicked
            File.AppendAllText(fileName, dataResult);

            //increments the ID# by 1 to account for the next line of data 
            id++;
        }

        /**
         * This method activates when the clear button is clicked to remove all data from text boxes and check boxes and radio buttons
         * and prepare the application for a new patient to be entered in
         */
        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            //All text boxes are cleared out, all checkboxes are marked as false and all radio buttons are unchecked

            txt_Age.Clear();
            txt_Sex.Clear();
            chk_NursingHomeResident.IsChecked = false;
            chk_NeoplasticDisease.IsChecked = false;
            chk_LiverDisease.IsChecked = false;
            chk_CongestiveHeartFailure.IsChecked = false;
            chk_CerebrovascularDisease.IsChecked = false;
            chk_RenalDisease.IsChecked = false;
            chk_AlteredMentalStatus.IsChecked = false;
            chk_PleuralEffusion.IsChecked = false;
            txt_Systolic_Blood_Pressure.Clear();
            txt_Temperature.Clear();
            txt_Pulse.Clear();
            txt_Hematocrit.Clear();
            txt_pH.Clear();
            txt_BUN.Clear();
            txt_Sodium.Clear();
            txt_Glucose.Clear();
            txt_PartialPressureOxygen.Clear();
            radBut_Celsius.IsChecked = false;
            radBut_Fahrenheit.IsChecked = false;
            radBut_BUN_mgdl.IsChecked = false;
            radBut_BUN_mmolL.IsChecked = false;
            radBut_Glucose_mgdl.IsChecked = false;
            radBut_Glucose_mmolL.IsChecked = false;
            radBut_PartialPressureOxygen_kPa.IsChecked = false;
            radBut_PartialPressureOxygen_mmHg.IsChecked = false;
        }
    }
}
