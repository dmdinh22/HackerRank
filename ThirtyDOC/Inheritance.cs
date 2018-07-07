namespace HackerRank.ThirtyDOC
{
    public class Inheritance
    {
        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }
        class Student : Person
        {
            private int[] scores;

            public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
            {
                this.scores = scores;
            }

            public char Calculate()
            {
                int gradeAverage = 0;
                int sum = 0;

                for (int i = 0; i < scores.Length; i++)
                {
                    sum += scores[i];
                }

                int totalGrades = scores.Length;
                gradeAverage = sum / totalGrades;

                if (gradeAverage >= 90 && gradeAverage <= 100)
                {
                    return ('O');

                }
                else if (gradeAverage >= 80 && gradeAverage <= 90)
                {
                    return ('E');
                }
                else if (gradeAverage >= 70 && gradeAverage <= 80)
                {
                    return ('A');

                }
                else if (gradeAverage >= 55 && gradeAverage <= 70)
                {
                    return ('P');

                }
                else if (gradeAverage >= 40 && gradeAverage <= 55)
                {
                    return ('D');

                }
                else if (gradeAverage < 40)
                {
                    return ('T');

                }
                else
                {
                    return ('X');
                }
            }
        }
    }
}