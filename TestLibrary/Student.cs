using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public enum Division
    {
        Failed,
        Third,
        Second,
        First,
        Distinction
    }
    public class Students
    {
        #region Propoerties
        private string studentName;
        private int roll;
        private List<Subject> subject;
        private float total;
        private float totalFull;
        private float percentage;
        private Division division;
        #endregion

        #region Constructors
        public Students(string studentname, int rollnum, List<Subject> sub)
        {
            this.studentName = studentname;
            this.roll = rollnum;
            this.subject = sub;
            Calucation();
        }
        public Students(int rollnum, List<Subject> sub)
        {
            this.roll = rollnum;
            this.subject = sub;
            Calucation();
        }
        public Students(List<Subject> sub)
        {
            this.subject = sub;
            Calucation();
        }
        #endregion

        #region Private Members
        private void Calucation()
        {
            total = 0;
            totalFull = 0;
            //foreach item 
            foreach (var item in subject)
            {
                total += item.AchievedMarks;
                totalFull += item.FullMarks;
            }

            ////for  loop 
            //for (int i = 0; i < subject.Count; i++)
            //{
            //    total += subject[i].AchievedMarks;
            //    totalFull += subject[i].FullMarks;
            //}

            ////do loop 
            //int i = 0;
            //do
            //{
            //    total += subject[i].AchievedMarks;
            //    totalFull += subject[i].FullMarks;
            //    i++;
            //} while (i < subject.Count);

            percentage = (total / totalFull) * 100;
            GetDivision();
        }
        private void GetDivision()
        {
            if (percentage < 32)
            {
                this.division = TestLibrary.Division.Failed;
            }
            else if (percentage < 45)
            {
                this.division = TestLibrary.Division.Third;
            }
            else if (percentage < 60)
            {
                this.division = TestLibrary.Division.Second;
            }
            else if (percentage < 80)
            {
                this.division = TestLibrary.Division.First;
            }
            else if (percentage <= 100)
            {
                this.division = TestLibrary.Division.Distinction;
            }
            else
            {
                this.division = TestLibrary.Division.Failed;
            }
        }

        #endregion

        #region Public Accessors
        public float Total
        {
            get { return this.total; }
        }
        public float Percentage
        {
            get { return this.percentage; }
        }
        public Division Division
        {
            get { return this.division; }
        }

        public string Name
        {
            get { return this.studentName; }
        }

        public List<Subject> Subject
        {
            set {
                subject = value;
                this.Calucation();
            }
        }
        #endregion

        #region Destructors
        ~Students()
        {

        }
        #endregion
    }

    public class Subject
    {
        private string subjectName;
        private float theoryMarks;
        private float practicalMarks;
        private float fullMarks;
        public string SubjectName
        {
            get { return this.subjectName; }
            set { subjectName = value; }
        }
        public float TheoryMarks
        {
            get { return this.theoryMarks; }
            set { theoryMarks = value; }
        }
        public float PracticalMarks
        {
            get { return this.practicalMarks; }
            set { practicalMarks = value; }
        }

        public float FullMarks
        {
            get { return this.fullMarks; }
            set { fullMarks = value; }
        }
        public float AchievedMarks
        {
            get { return this.theoryMarks + this.practicalMarks; }
        }
    }
}
