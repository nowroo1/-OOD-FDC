using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Future {
    public partial class Main : Form {

        ObjectivesForm _objectivesForm;
        ObjectivesForm _bucketListForm;
        WebLinkForm _aptitudeTestForm;
        WebLinkForm _jobInformationForm;
        MentoringForm _mentoringForm;

        public ObjectivesForm carrerPlanForm {
            get {
                return this._objectivesForm;
            }
            set {
                this._objectivesForm = value;
            }
        }
        public ObjectivesForm bucketListForm {
            get {
                return this._bucketListForm;
            }
            set {
                this._bucketListForm = value;
            }
        }
        public WebLinkForm jobInformationForm {
            get {
                return this._jobInformationForm;
            }
            set {
                this._jobInformationForm = value;
            }
        }
        public WebLinkForm aptitudeTestForm {
            get {
                return this._aptitudeTestForm;
            }
            set {
                this._aptitudeTestForm = value;
            }
        }
        public MentoringForm mentoringForm {
            get {
                return this._mentoringForm;
            }
            set {
                this._mentoringForm = value;
            }
        }


        public Main() {
            InitializeComponent();

            // setter를 이용하여 객체 생성
            this.carrerPlanForm = new carrerPlanForm();
            this.bucketListForm = new BucketListForm();
            this.aptitudeTestForm = new AptitudeTestForm();
            this.jobInformationForm = new JobInformationForm();
            this.mentoringForm = new MentoringForm();
        }


        private void Form1_Load(object sender, EventArgs e) {
            chart1.Series.Clear(); //default series를 삭제한다.
            Series sSin = chart1.Series.Add("목표 달성률"); //새로운 series 생성
            sSin.ChartType = SeriesChartType.Line; //그래프 모양을 '선'으로 지정
                                                   //데이터 포인트 저장
            for (double k = 0; k < 10; k += 0.1) {
                sSin.Points.AddXY(k, Math.Sin(k) * 100);
            }
        }

        private void carrerPlan_Click(object sender, EventArgs e) {
            carrerPlanForm.Show();
        }

        private void bucketList_Click(object sender, EventArgs e) {
            bucketListForm.Show();
        }

        private void aptitudeTest_Click(object sender, EventArgs e) {
            aptitudeTestForm.Show();
        }

        private void jobInformation_Click(object sender, EventArgs e) {
            jobInformationForm.Show();
        }

        private void mentoring_Click(object sender, EventArgs e) {
            mentoringForm.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
