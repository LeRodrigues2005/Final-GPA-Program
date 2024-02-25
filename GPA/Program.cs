string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int mult1 = course1Grade * course1Credit;
int mult2 = course2Grade * course2Credit;
int mult3 = course3Grade * course3Credit;
int mult4 = course4Grade * course4Credit;
int mult5 = course5Grade * course5Credit;

int sum = mult1 + mult2 + mult3 + mult4 + mult5;
int sumCredit = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal gpa = (decimal) sum / sumCredit;
string formattedGpa = gpa.ToString("0.00");

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\t\tCredit Hours\n");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}\n");

Console.WriteLine($"Final GPA: \t\t\t{formattedGpa}");
