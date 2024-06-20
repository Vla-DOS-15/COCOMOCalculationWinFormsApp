using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMOCalculationWinFormsApp
{
    public partial class MainForm : Form
    {
        bool isDigit = true;
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
            txtCodeSize.KeyDown += new KeyEventHandler(txtCodeSize_KeyDown); 
            txtCodeSize.KeyPress += new KeyPressEventHandler(txtCodeSize_KeyPress);
            btnGetData.Click += new EventHandler(btnGetData_Click);
        }
        void btnGetData_Click(object sender, EventArgs e)
        {
            if
        (string.IsNullOrWhiteSpace(txtCodeSize.Text))
            {
                return;
            }
            ProjectType type = (ProjectType)Enum.Parse(typeof(ProjectType), cmbProjectType.Text);
            int codeSize = int.Parse(txtCodeSize.Text);
            lblEfforts.Text = string.Format("Трудоємність: {0} {1}",
            BasicModel.GetEfforts(codeSize,
            type).ToString("F2"), " люд./міс.");
            lblTimeTo.Text = string.Format("Тривалість: {0} {1}",
            BasicModel.GetTimeToDevelop(codeSize,
            type).ToString("F2"), " міс.");
            lblDevelopers.Text = string.Format("Розробників: {0} {1}",
            BasicModel.GetPersonsToDevelop(codeSize,
            type).ToString("F1"), " чол.");
        }
        void txtCodeSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isDigit;
        }
        void txtCodeSize_KeyDown(object sender, KeyEventArgs e)
        {
            isDigit =
        ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
        && (e.KeyCode != Keys.Back));
        }
        void MainForm_Load(object sender, EventArgs e)
        {
            string[]
        projectTypes =
        Enum.GetNames(typeof(ProjectType));
            cmbProjectType.Items.AddRange(projectTypes); cmbProjectType.Text
            =
            cmbProjectType.Items[0].ToString(); lblEfforts.Text = ""; lblTimeTo.Text
            = ""; lblDevelopers.Text = "";
        }


    }
}
        

    public static class BasicModel
    {
        //Таблиця коефіцієнтів
        static double[][] modelTable = new double[3][]; static BasicModel()
        {
            modelTable[0] = new[] { 2.4, 1.05, 2.5, 0.38 }; modelTable[1] =
            new[] { 3.0, 1.12, 2.5, 0.35 }; modelTable[2] = new[] { 3.6, 1.20, 2.5, 0.32 };
        } //Трудоємність
        public static double GetEfforts(int codeSize, ProjectType type)
        {
            return modelTable[(int)type][0] * (Math.Pow(codeSize,
            modelTable[(int)type][1]));
        }
        //Термін розробки
        public static double GetTimeToDevelop(int codeSize, ProjectType
        type)
        {
            return modelTable[(int)type][2] * (Math.Pow(GetEfforts(codeSize,
            type), modelTable[(int)type][3]));
        }
        //Число необхідних розробників
        public static double GetPersonsToDevelop(int codeSize, ProjectType
        type)
        {
            return GetEfforts(codeSize, type) / GetTimeToDevelop(codeSize,
            type);
        }
    }
    //Типи проекту
    public enum ProjectType
    {
        Organic = 0, Semi_detached = 1, Embedded = 2
    }

