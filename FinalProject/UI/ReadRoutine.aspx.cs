using FinalProject.Libraries;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.UI
{
    public partial class ReadRoutine : System.Web.UI.Page
    {
        private static string[] Days = { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday" };
        private static string[] TimeSlot = { "8:30-10:00", "10:00-11:30", "11:30-1:00", "1:00-2:30", "2:30-4:00", "4:00-5:30" };
        public static int firstDayIndex = 0;
        public static int firstTimeSlot = 0;
        public static int classRoomStartIndex = 0;
        public List<RoutineSchema> RoutineList = new List<RoutineSchema>();
        public string[] classDays = new string[6];

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\nosra\documents\visual studio 2015\Projects\FinalProject\FinalProject\file\SWE-Classroutine-Spring-2018-V-1_1.xlsx";

            Application excelApp = new Application();
            Workbook excelWorkBook = excelApp.Workbooks.Open(path, ReadOnly: true);

            Worksheet excelWorkSheet = excelWorkBook.Worksheets.get_Item(1);

            ReadFirstDayFirstSlotRoutine(excelWorkSheet);

            CheckCourseCode();

            gvRoutine.DataSource = RoutineList;
            gvRoutine.DataBind();

        }

        private void CheckCourseCode()
        {
            int i = 0;
            foreach (RoutineSchema rs in RoutineList)
            {
                if (!rs.CourseCode.Equals(""))
                {
                    classDays[i++] = rs.CourseCode;
                }
            }
        }

        private void ReadFirstDayFirstSlotRoutine(Worksheet worksheet)
        {
            FindIndexByDay(Days[0], worksheet);
            firstTimeSlot = firstDayIndex + 1;
            classRoomStartIndex = firstTimeSlot + 2;

            for (int i = 0; ; i++)
            {
                string classRoomNumber = FindClassRoomNumber(classRoomStartIndex + i, worksheet);

                if (classRoomNumber.ToLower().Equals(Days[1]))
                {
                    break;
                }

                string courseCode = FindCourseCode(classRoomStartIndex + i, worksheet);
                string teacherInitial = FindTeacherInitial(classRoomStartIndex + i, worksheet);

                RoutineList.Add(new RoutineSchema
                {
                    ClassRoomNumber = classRoomNumber,
                    CourseCode = courseCode,
                    TeacherInitial = teacherInitial,
                    TimeSlot = TimeSlot[0],
                    Day = Days[0]
                });
            }

        }

        private void FindIndexByDay(string dayName, Worksheet worksheet)
        {
            for (int i = 1; ; i++)
            {
                string IsDay = string.Empty;
                try
                {
                    IsDay = worksheet.Cells[i, 1].Value.ToString();
                }
                catch (Exception ex)
                {
                    IsDay = string.Empty;
                }

                if (IsDay.ToLower().Equals(dayName))
                {
                    firstDayIndex = i;
                    break;
                }
            }
        }

        private string FindClassRoomNumber(int rowIndex, Worksheet worksheet)
        {
            string classRoomNumber = string.Empty;

            try
            {
                classRoomNumber = worksheet.Cells[rowIndex, 1].Value.ToString();
            }
            catch (Exception ex)
            {
                classRoomNumber = string.Empty;
            }
            return classRoomNumber;
        }

        private string FindCourseCode(int rowIndex, Worksheet worksheet)
        {
            string courseCode = string.Empty;

            try
            {
                courseCode = worksheet.Cells[rowIndex, 2].Value.ToString();
            }
            catch (Exception ex)
            {
                courseCode = string.Empty;
            }
            return courseCode;
        }


        private string FindTeacherInitial(int rowIndex, Worksheet worksheet)
        {
            string teacherInitial = string.Empty;

            try
            {
                teacherInitial = worksheet.Cells[rowIndex, 3].Value.ToString();
            }
            catch (Exception ex)
            {
                teacherInitial = string.Empty;
            }
            return teacherInitial;
        }

    }
}