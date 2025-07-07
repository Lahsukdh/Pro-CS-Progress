namespace tracker
{
    class Student
    {
        private string? name;
        private float? grade;

        public Student()
        {
            name = "NULL";
            grade = 0;

        }

        public Student(string? newName, float? score)
        {
            name = newName;
            grade = score;
        }

        public string? getName()
        {
            return name;
        }

        public float? getGrade()
        {
            return grade;
        }
    }

    class Class
    {
        private Student?[] testClass;
        private int? size;
        public Class()
        {
            size = 5;
            testClass = new Student[5];
        }
        public Class(int nums)
        {
            testClass = new Student[nums];
            size = nums;
        }

        public void viewClass()
        {
            foreach (Student? pupil in testClass)
            {
                if (pupil != null)
                {
                    System.Console.WriteLine("{0}  -  {1}", pupil.getName(), pupil.getGrade());
                }
            }
        }
        public void getAverage()
        {
            float? sum = 0;
            int? num = 0;
            foreach (Student? pupil in testClass)
            {
                if (pupil != null)
                {
                    sum = sum + pupil.getGrade();
                    num++;
                }
            }

            System.Console.WriteLine(sum/num);
        }

        public void addStudent(string? studentName, float? grade)
        {
            for (int i = 0; i < size; i++)
            {
                if (testClass[i] == null)
                {
                    testClass[i] = new Student(studentName, grade);
                    return;
                }
            }
            System.Console.WriteLine("Unable to add student, Class is full");
        }
        public void removeStudent(String? studentName)
        {
        
            for (int i = 0; i < size; i++)
            {
                
                if (testClass[i] != null && testClass[i].getName() == studentName)
                {
                    testClass[i] = null;
                    return;
                }
            }
        
            System.Console.WriteLine("Unable to remove, student is not found");
        }


    }
}
