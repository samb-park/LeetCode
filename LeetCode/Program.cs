public class Program
{
    public static void Main(string[] args)
    {
        // 문제 풀이 클래스 목록
        List<ILeetCodeProblem> problems = new List<ILeetCodeProblem>
        {
            //new LeetCode.Array_String.MaximumDistanceInArraysSolution(),
            //new LeetCode.Array_String.WiggleSortSolution(),
            //new LeetCode.Array.IntegerToRomanSolution(),
            //new LeetCode.Array.LengthOfLastWordSolution(),
            new LeetCode.Array.ReverseWordsInaString(),
            // 새로운 문제를 추가하면 여기에 등록
        };

        // 모든 문제에 대한 테스트 실행
        foreach (var problem in problems)
        {
            problem.RunTests();
            Console.WriteLine();
        }
    }
}