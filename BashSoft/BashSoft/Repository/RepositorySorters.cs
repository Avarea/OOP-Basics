namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                PrintStudent(wantedData.OrderBy(x => x.Value.Sum())
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudent(wantedData.OrderByDescending(x => x.Value.Sum())
                    .Take(studentsToTake)
                    .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private static void OrderAndTake(Dictionary<string, List<int>> wantedData, int studentsToTake, Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        {
            Dictionary<string, List<int>> studentsSorted = GetSortedStudents(wantedData, studentsToTake, comparisonFunc);
            PrintStudent(studentsSorted);
        }

        private static Dictionary<string, List<int>> GetSortedStudents(Dictionary<string, List<int>> studentsWanted, int takeCount,
            Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> Comparison)
        {
            int valuesTaken = 0;
            Dictionary<string, List<int>> studentsSorted = new Dictionary<string, List<int>>();
            KeyValuePair<string, List<int>> nextInOder = new KeyValuePair<string, List<int>>();
            bool isSorted = false;

            while (valuesTaken < takeCount)
            {
                isSorted = true;
                foreach (var studentWithScore in studentsWanted)
                {
                    if (!String.IsNullOrEmpty(nextInOder.Key))
                    {
                        int comparisonResult = Comparison(studentWithScore, nextInOder);
                        if (comparisonResult >= 0 && !studentsSorted.ContainsKey(studentWithScore.Key))
                        {
                            nextInOder = studentWithScore;
                            isSorted = false;
                        }
                    }

                    else
                    {
                        if (!studentsSorted.ContainsKey(studentWithScore.Key))
                        {
                            nextInOder = studentWithScore;
                            isSorted = false;
                        }
                    }
                }
                if (!isSorted)
                {
                    studentsSorted.Add(nextInOder.Key, nextInOder.Value);
                    valuesTaken++;
                    nextInOder = new KeyValuePair<string, List<int>>();
                }
            }



            return studentsSorted;
        }

        private static int CompareInOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        {
            int totalOfFirstMarks = 0;
            foreach (int i in firstValue.Value)
            {
                totalOfFirstMarks += i;
            }
            int totalOfSecondMarks = 0;
            foreach (int i in secondValue.Value)
            {
                totalOfSecondMarks += i;
            }
            var result = totalOfSecondMarks.CompareTo(totalOfFirstMarks);
            return result;
        }

        private static int CompareInDecendingOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        {
            int totalOfFirstMarks = 0;
            foreach (int i in firstValue.Value)
            {
                totalOfFirstMarks += i;
            }
            int totalOfSecondMarks = 0;
            foreach (int i in secondValue.Value)
            {
                totalOfSecondMarks += i;
            }
            var result = totalOfFirstMarks.CompareTo(totalOfSecondMarks);
            return result;
        }

        public static void PrintStudent(Dictionary<string, List<int>> studentsSorted)
        {
            foreach (var pair in studentsSorted)
            {
                OutputWriter.PrintStudent(pair);
            }
        }
    }
}
