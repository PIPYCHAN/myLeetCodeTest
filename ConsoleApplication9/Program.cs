using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.XPath;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace ConsoleApplication9
{
    #region Class
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    #endregion



    class Program
    {
        private static IList<int> lisTree = new List<int>();
        private static Stack<int> stForTree = new Stack<int>();
        static void Main(string[] args)
        {
            #region old
            //var result = NumWays(5, GetMatrix("[[0,2],[2,1],[3,4],[2,3],[1,4],[2,0],[0,4]]"), 3);
            //var result = NumMovesStones(1,3,5);
            //TripleInOne ti = new TripleInOne(1);
            //ti.Push(0,1);
            //ti.Push(0, 2);
            //var reslt2=ti.Pop(0);
            //var reslt3 = ti.Pop(0);

            //var result = DaysBetweenDates("2020-01-15", "2019-01-15");
            //var result = MostVisited(4, new int[] { 3, 1, 2, 3, 1 });
            //var result = LeastMinutes(4);
            //var result = MaxProductDifference(new int[] { 4, 2, 5, 9, 7, 4, 8 });
            //var result = ReorderLogFiles(new string[] { "l5sh 6 3869 08 1295", "16o 94884717383724 9", "43 490972281212 3 51", "9 ehyjki ngcoobi mi", "2epy 85881033085988", "7z fqkbxxqfks f y dg", "9h4p 5 791738 954209", "p i hz uubk id s m l", "wd lfqgmu pvklkdp u", "m4jl 225084707500464", "6np2 bqrrqt q vtap h", "e mpgfn bfkylg zewmg", "ttzoz 035658365825 9", "k5pkn 88312912782538", "ry9 8231674347096 00", "w 831 74626 07 353 9", "bxao armngjllmvqwn q" });
            //var result = CanBeIncreasing(new int[] {2,3,1,2});
            //var result = FindCenter(GetMatrix("[[1,2],[2,3],[4,2]]"));
            //var result = CountPoints(GetMatrix("[[1,3],[3,3],[5,3],[2,2]]"),GetMatrix("[[2,3,1],[4,3,1],[1,1,2]]"));
            //var result = BuildArray(new int[] {0, 2, 1, 5, 3, 4 });
            //var result = GenerateParenthesis(2);
            //var result = DeepestLeavesSum(ConvertTreeFromArray(new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8}));
            //var result = IsDecomposable("00011111222");
            //var result = Permute(new int[] { 1, 2, 3 });
            //var result = SwapPairs(GenerateListNodeFromArray(new int[] { 1, 2, 3, 4 }));
            //var result = UniquePaths(3, 7);
            //var result = IntToRoman(1994);
            //var result = MinPathSum(GetMatrix("[[1,2,3],[4,5,6]]"));
            //var result = CanJump(new int[] { 2, 3, 1, 1, 4 });
            //var result=Subsets(new int[] { 1,2,3});
            //var result = CombinationSum(new int[] { 2, 3, 5 }, 8);
            //var result = LastRemaining(5,3);
            //var result = PaintingPlan(3, 8);
            //var result = NearestValidPoint(3,4,GetMatrix(" [[1,2],[3,1],[2,4],[2,3],[4,4]]"));
            //var result = PurchasePlans(new int[] { 2, 5, 3, 5 }, 6);
            //int test = int.MaxValue;
            //var result = ContainsPattern(new int[] { 1, 2, 4, 4, 4, 4 },1,3);
            ////var result = NumWays(5,GetMatrix("[[0,2],[2,1],[3,4],[2,3],[1,4],[2,0],[0,4]]"),3);
            //var result = FloodFill(GetMatrix("[[0,0,0],[0,1,1]]"),1,1,2);
            //var result = CountGoodSubstrings("aababcabc");
            //var result = IsCovered(GetMatrix("[[1,2],[3,4],[5,6]]"),2,5);
            //var result = LongestNiceSubstring("aAa");
            //var result = HalfQuestions(new int[] { 2, 1, 6, 2 });
            //var result = MakeEqual(new string[] { "abc", "aabc", "bc" });
            //var result = LargestOddNumber("35427");
            //var result = RobotSim(new int[] { -2, 8, 3, 7, -1 },GetMatrix("[[-4,-1],[1,-1],[1,4],[5,0],[4,5],[-2,-1],[2,-5],[5,1],[-3,-1],[5,-3]]"));
            //var result = ShiftGrid(GetMatrix("[[1],[2],[3],[4],[7],[6],[5]]"),23);
            //var result = ImageSmoother(GetMatrix("[[2,3,4],[5,6,7],[8,9,10],[11,12,13],[14,15,16]]"));
            //var result = Tictactoe(GetMatrix("[[0,0],[1,1],[2,0],[1,0],[1,2],[2,1],[0,1],[0,2],[2,2]]"));
            //var result = ConstructRectangle(4);
            //var result = CheckZeroOnes("111000");
            //var result = IsOneBitCharacter(new int[] { 1,0,1,0});
            //var result = ConvertToBase7(0);
            //var result = CountBits(10);
            //var result = MaxRepeating("ababc","ab");
            //var result = HeightChecker(new int[] { 5, 1, 2, 3, 4 });
            //var result = FindPoisonedDuration(new int[] { 1},1000000);
            //var result = ReorderSpaces("  a");
            //var result = BuildArray(new int[] { 1,3},3);
            //var result = SecondHighest("abc1111");
            //var result = TrailingZeroes2(5);
            //var result = IsBoomerang(GetMatrix("[[1,0],[1,1],[1,0]]"));
            //var result = GetMaximumGenerated(7);
            //var result = SlowestKey(new int[] { 9, 29, 49, 50 }, "cbcd");
            //var result = IsSumEqual("acb","cba","cdb");
            //var result = LongestPalindrome2("cbbd");
            //var result = Reformat("leetcode12345678");
            //var result = ReplaceDigits("a1c1e1");
            //var result = SumEvenAfterQueries(new int[] { 1, 2, 3, 4 },GetMatrix("[[1,0],[-3,1],[-4,0],[2,3]]"));
            //var result = MaxScore("011101");谔32
            //var result = IsAlienSorted(new string[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz");
            //var result = PaintingPlan(2,2);
            //var result2 = Decrypt(new int[] { 2, 4, 9, 3 },-2);
            //var result2 = SpecialArray(new int[] { 0, 4, 3, 0, 4});
            //var result = ReformatNumber("1-23-45 6");
            //var result = NumSpecial(GetMatrix("[[1,0,0],[0, 0, 1],[1, 0, 0]]"));
            //var result = NumberOfDays(1992,7);
            //var result = ArrayRankTransform(new int[] {  12, 100,  5, 12 });
            //var result = MissingNumber(new int[] { 0, 1, 2, 4, 5, 6, 7,8, 9 });
            //var result = MaximumPopulation(GetMatrix(" [[1993,1999],[2000,2010]]"));
            //var result = SortSentence("sentence4 a3 is2 This1");
            //var result = SumBase(34,6);
            //var result = LengthOfLongestSubstring("YazaAay");
            //var result = CanAttendMeetings(GetMatrix("[[0,30],[5,10],[15,20]]"));
            //var result = DistanceBetweenBusStops(new int[] {1,2,3,4 },3,1);
            //var result = BinaryGap(22);
            //var result = CheckIfExist(new int[] { 10, 2, 5, 3 });//   l<r少等号(new int[] { 10, 2, 5, 3 });
            //var result = NumberOfLines(new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "bbbcccdddaaa");
            //var result = IsPathCrossing("NES");
            //var result = MaxCount(3,3,GetMatrix("[[2,2],[3,3]]"));
            //var result = DeleteDuplicates(GenerateListNodeFromArray(new int[] { 1, 1, 2,3, 3 }));
            //var result = DeleteDuplicates2(GenerateListNodeFromArray(new int[] { 1, 2, 3, 3, 4, 4, 5 }));
            //var result=
            //var temp = ReverseListNode(GenerateListNodeFromArray(new int[] { 1,2,3,4,5}));
            //var result = IsPalindrome4(GenerateListNodeFromArray(new int[] { 1,2,3,5,2,1 }));
            //var result = AddTwoNumbers(GenerateListNodeFromArray(new int[] { 9,9 }), GenerateListNodeFromArray(new int[] { 9 }));
            //var result = longestPalindrome2("babad");
            //var result = RemoveNthFromEnd(GenerateListNodeFromArray(new int[] { 1 }),1);
            //var result = IsPalindrome4(GenerateListNodeFromArray(new int[] { 1, 2, 2, 1 }));

            //var result = DominantIndex(new int[] { 3, 6, 1, 0 });
            //var result = Tribonacci(4);
            //var result = RotateString("abcde", "cdeab");
            //var result = FindRelativeRanks(new int[] { 5, 4, 3, 2, 1 });
            //var result = FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
            //int[] arr = { 3, 5, 1, 6, 2,7 };
            //var result = QuickSort(ref arr, 0, 5);
            //var result = FindShortestSubArray(new int[] { 1, 2, 2, 3, 1, 4, 2 });
            //var result = NumDifferentIntegers("leet1234code234");
            //var result = LargestUniqueNumber(new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 });
            //var result = MaxIncreaseKeepingSkyline(GetMatrix("[[3,0,8,4],[2,4,5,7],[9,2,6,3],[0,3,1,0]]"));
            //var result = CheckOnesSegment("1001");
            //var result = ReconstructQueue(GetMatrix("[[7,0],[4,4],[7,1],[5,0],[6,1],[5,2]]"));
            //var result = GetIntersectionNode(GenerateListNodeFromArray(new int[] { 4, 1, 8, 4, 5 }), GenerateListNodeFromArray(new int[] { 5, 0, 1, 8, 4, 5 }));
            //var result = DeleteNode(GenerateListNodeFromArray(new int[] { 4, 5, 1, 9 }),4);

            //var testt = HasGroupsSizeX(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 });
            //var test = MostCommonWord("L, P! X! C; u! P? w! P. G, S? l? X? D. w? m? f? v, x? i. z; x' m! U' M! j? V; l. S! j? r, K. O? k? p? p, H! t! z' X! v. u; F, h; s? X? K. y, Y! L; q! y? j, o? D' y? F' Z; E? W; W' W! n! p' U. N; w? V' y! Q; J, o! T? g? o! N' M? X? w! V. w? o' k. W. y, k; o' m! r; i, n. k, w; U? S? t; O' g' z. V. N? z, W? j! m? W! h; t! V' T! Z? R' w, w? y? y; O' w; r? q. G, V. x? n, Y; Q. s? S. G. f, s! U? l. o! i. L; Z' X! u. y, Q. q; Q, D; V. m. q. s? Y, U; p? u! q? h? O. W' y? Z! x! r. E, R, r' X' V, b. z, x! Q; y, g' j; j. q; W; v' X! J' H? i' o? n, Y. X! x? h? u; T? l! o? z. K' z' s; L? p? V' r. L? Y; V! V' S. t? Z' T' Y. s? i? Y! G? r; Y; T! h! K; M. k. U; A! V? R? C' x! X. M; z' V! w. N. T? Y' w? n, Z, Z? Y' R; V' f; V' I; t? X? Z; l? R, Q! Z. R. R, O. S! w; p' T. u? U! n, V, M. p? Q, O? q' t. B, k. u. H' T; T? S; Y! S! i? q! K' z' S! v; L. x; q; W? m? y, Z! x. y. j? N' R' I? r? V! Z; s, O? s; V, I, e? U' w! T? T! u; U! e? w? z; t! C! z? U, p' p! r. x; U! Z; u! j; T! X! N' F? n! P' t, X. s; q'", new string[] { "m", "i", "s", "w", "y", "d", "q", "l", "a", "p", "n", "t", "u", "b", "o", "e", "f", "g", "c", "x" });

            //var result = SingleNonDuplicate(new int[] { 1 });

            //var result = ShipWithinDays(new int[] { 3, 2, 2, 4, 1, 4},3);
            //var result = MinEatingSpeed(new int[] { 332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184 }, 823855818);
            //var result = FourSum(new int[] { 1, 0, -1, 0, -2, 2 },0);
            //var result = FourSumCount(new int[] { 1, 2 }, new int[] { -2, -1 }, new int[] { -1, 2 }, new int[] { 0, 2 });
            //var result = MinOperations3(new int[] { 1, 1, 4, 2, 3 },5);
            //var result = CheckArithmeticSubarrays(new int[] { 4, 6, 5, 9, 3, 7 },new int[] { 0, 0, 2 },new int[] { 2, 3, 5 });
            //var result = NthUglyNumber(10) ;
            //var result = CuttingRope(6);
            //var result = LargestNumber(new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            //var result = MedianSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            //var result = LastRemaining(5,3);
            //var result = CuttingRope(120);
            //var result = SingleNumbers(new int[] { 4, 1, 4, 6 });
            //var result = FindLength(new int[] { 1, 2, 3, 2, 1 },new int[] { 3, 2, 1, 4, 7 });
            //var result = NumberOfSubarrays(new int[] { 2,2,1,2,2,1,2,1 },2);
            //var result = NumSubarrayBoundedMax(new int[] { 1, 2, 1, 4, 3, 5, 3, 2, 6 },2,3);v
            //var result = TotalFruit(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 });
            //var result = FindMaxLength(new int[] { 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0 });
            //var result = StringShift("abcdefg", GetMatrix(" [[1,1],[1,1],[0,2],[1,3]]"));

            //var result = MaxSubArrayLen(new int[] { 1,1,0 },1);
            //var result = MinSubArrayLen(11,new int[] { 1,2,3,4,5 });
            //var result = SubarraySum(new int[] { 1, -1, 0 },0);
            //var testr = AreAlmostEqual("bank", "kanb");
            //var result = LengthOfLongestSubstring2("abcabcbb");

            //testAction();
            //var result = FindUnsortedSubarray(new int[] { 2, 6, 4, 8, 10, 9, 15 });
            //var result = TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 },2);
            //var result = TrimMean(new int[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 });
            //var result = RepeatedNTimes(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 });
            //var result = ProjectionArea(GetMatrix("[[1,2],[3,4]]"));
            //var result = RelativeSortArray(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 });

            //var test1 = RemoveElements(GenerateListNodeFromArray(new int[] { 1,2,3,6,4,5,6}), 6);
            //var result = NumWays(7);
            //var result = MaximumProduct(new int[] { -100, -98, -1, 2, 3, 4 });
            //var result = IsIsomorphic("paper", "title");
            //var result = IsMonotonic(new int[] { 1,1,2 });
            //var result1 = CanConstruct("a","b");
            //var result = TrailingZeroes(78);
            //var result = MatrixReshape(GetMatrix("[[1,2],[3, 4]]"),1,4);
            //var result = IsIsomorphic("ab", "aa");
            //var result = RepeatedSubstringPattern("abcabcabc");
            //var result = RemoveVowels("leetcode");
            //Foo f = new Foo();
            //var result = CountGoodRectangles(GetMatrix("[[5,8],[3,9],[5,12],[16,5]]"));
            //var result = MinPartitions("82734");
            //var result = sumNums(3);
            //二分查找 汇总 https://leetcode-cn.com/problems/search-a-2d-matrix/solution/yi-wen-dai-ni-gao-ding-duo-ge-er-fen-cha-2hl9/
            //var result = IsLongPressedName("alex","aaleexa");
            //var result = FindClosest(new string[] { "mm", "l", "tul", "nd", "up", "ugu", "sgn", "bly", "o", "psn", "dn", "jw", "uo", "ry", "z", "kyb", "en", "a", "aem", "vcy", "y", "z", "wuu", "ver", "l", "wi", "jh", "nfu", "quq", "wa", "zy", "lyu", "vny", "v", "k", "p", "k", "buu", "w", "b", "jl", "mwv", "v", "til", "mv", "mv", "m", "uar", "dbo", "ae", "hyx", "rxy", "p", "an", "bz", "jcv", "t", "rac", "amw", "qhs", "ed", "b", "rw", "pu", "sr", "u", "a", "go", "pdm", "yzl", "mkw", "ai", "u", "s", "rsg", "uu", "fr", "g", "l", "is", "kok", "xnh", "zv", "dcf", "u", "x", "tq", "f", "r", "ekv", "jvm", "krk", "cd", "ks", "dv", "z", "qw", "m", "pe", "l", "etk", "t", "xuq", "t", "ntc", "h", "s", "iat", "xe", "s", "l", "bq", "eg", "mw", "hy", "ol", "szb", "f", "vi", "rok", "ks", "v", "va", "klf", "yg", "t", "vuo", "wt", "x", "wbs", "gl", "uhj", "gkv", "m", "d", "yo", "tah", "ja", "qe", "q", "a", "d", "hc", "zbh", "mnr", "chf", "sbp", "v", "wd", "q", "sj", "khu", "hsx", "i", "i", "q", "uzy", "can", "qq", "nlp", "io", "kp", "d", "p", "cxt", "zdj", "rxr", "w", "eye", "ukn", "bf", "x", "v", "uvy", "xd", "f", "vb", "y", "wjh", "n", "ns", "qev", "i", "xl", "ywg", "v", "gi", "sbh", "dq", "do", "fqu", "ee", "ru", "nxh", "as", "jvc", "n", "h", "yvd", "ke", "jx", "e", "a", "kou", "d", "ky", "pue", "yto", "i", "ik", "px", "h", "tem", "msp", "dyc", "abx", "wwt", "e", "r", "o", "p", "ds", "x", "pe", "j", "tu", "k", "k", "nt", "e", "vpn", "ml", "otp", "j", "xtg", "hkn", "jey", "h", "wg", "wni", "g", "meo", "g", "y", "o", "p", "zc", "h", "r", "c", "r", "ixc", "mvg", "x", "mb", "zm", "hex", "w", "r", "u", "ai", "f", "mkh", "um", "c", "e", "gun", "ph", "r", "nmf", "p", "qw", "s", "hmy", "in", "my", "y", "g", "p", "jl", "v", "ldr", "js", "px", "t", "c", "fm", "d", "zdi", "tv", "oeh", "cqz", "ol", "sou", "s", "ht", "b", "wn", "l", "stu", "hs", "cik", "kqj", "ee", "fr", "ze", "tn", "kxs", "euw", "blv", "r", "qk", "pf", "ywg", "f", "nt", "gu", "zk", "pp", "d", "i", "maq", "qc", "vp", "jys", "w", "ap", "ro", "d", "jq", "rx", "f", "iiy", "tk", "uh", "qtb", "l", "rhm", "ppg", "gla", "ipm", "i", "z", "ys", "r", "p", "fqd", "m", "i", "sa", "ghf", "qh", "kxw", "x", "z", "i", "iv", "h", "b", "cez", "pe", "ge", "hoc", "k", "h", "yac", "ft", "io", "ex", "bk", "f", "rlx", "n", "ll", "ts", "yj", "lfm", "t", "wa", "bm", "cq", "hbb", "i", "ec", "pnw", "rfk", "vem", "d", "jqy", "z", "w", "i", "h", "f", "jks", "uq", "euo", "tjo", "r", "o", "ct", "sac", "am", "z", "y", "nbb", "n", "r", "b", "no", "hdh", "f", "ogo", "nx", "g", "q", "ehh", "by", "h", "kuc", "pl", "o", "r", "i", "lcp", "et", "hpe", "yi", "ohv", "gc", "dgt", "x", "c", "e", "kwo", "gop", "yf", "as", "n", "ku", "i", "kk", "vk", "k", "pkm", "gyr", "gvf", "xsu", "o", "i", "qxd", "zm", "b", "mv", "gh", "wwj", "uxy", "of", "lfw", "eh", "u", "gk", "r", "yu", "or", "a", "bb", "uq", "ze", "fkv", "yf", "eui", "iz", "xla", "nap", "gy", "rg", "km", "u", "e", "sxa", "dto", "dwt", "nsn", "up", "cz", "u", "r", "ya", "m", "t", "mx", "t", "w", "cm", "q", "yf", "e", "tvx", "kk", "w", "hdh", "qgz", "qud", "qi", "su", "p", "gr", "rj", "pkg", "f", "p", "vu", "fey", "h", "n", "jyl", "em", "ven", "e", "k", "kt", "i", "krd", "w", "jet", "eu", "xu", "sxv", "s", "ood", "eyu", "h", "pwg", "paa", "mf", "h", "qbl", "fw", "krr", "qx", "mca", "lm", "sed", "bmq", "g", "p", "e", "lbn", "kx", "li", "bpx", "ul", "da", "wfb", "qwp", "ros", "ipk", "u", "hh", "t", "r", "ytd", "lu", "k", "yc", "ibm", "sq", "nwb", "mxi", "zbn", "jfc", "xp", "f", "o", "b", "pp", "z", "j", "bq", "qpp", "l", "p", "ctp", "pe", "tm", "kpz", "gm", "xt", "t", "m", "lw", "uvo", "t", "rf", "pqm", "hq", "mfq", "g", "q", "m", "hpb", "jcw", "zwo", "u", "t", "bdq", "nk", "ua", "y", "msu", "b", "g", "ze", "ijv", "q", "dj", "nn", "rnx", "st", "u", "ls", "jfs", "mpz", "w", "wsu", "g", "ae", "e", "yoh", "ye", "nv", "d", "wng", "yxd", "bw", "sqy", "a", "k", "ilo", "bds", "e", "t", "uun", "ue", "zdi", "b", "ul", "ou", "e", "z", "a", "cll", "om", "x", "b", "ajp", "vjc", "epa", "dpx", "bl", "tt", "nj", "c", "seg", "oz", "jj", "qg", "xz", "iq", "jo", "a", "m", "gfd", "bdj", "ztq", "vmb", "wd", "dlb", "xl", "ckt", "ks", "hp", "s", "j", "jyq", "x", "zlc", "l", "u", "q", "p", "apl", "ci", "k", "p", "ut", "dz", "x", "u", "r", "bs", "tu", "c", "t", "xo", "r", "n", "xlb", "u", "fi", "az", "c", "pi", "fz", "v", "kin", "d", "zb", "k", "x", "px", "u", "in", "f", "zav", "ey", "okl", "i", "r", "qv", "aac", "m", "eb", "cy", "pyd", "n", "m", "pmh", "hx", "zn", "vck", "cif", "g", "l", "cpg", "t", "a", "czb", "j", "i", "x", "f", "yk", "he", "s", "zg", "gz", "ckl", "zmk", "kj", "v", "kn", "uzq", "qj", "v", "t", "rf", "npj", "dm", "qn", "jav", "i", "q", "g", "udw", "z", "qsj", "c", "x", "cnp", "e", "vxh", "gw", "mk", "rau", "mnh", "xyi", "i", "h", "t", "src", "o", "z", "jm", "pn", "i", "lw", "wd", "x", "l", "cmw", "s", "d", "id", "ux", "p", "d", "p", "mjk", "kr", "jt", "u", "rss", "zim", "fi", "il", "e", "w", "dfd", "fby", "ui", "kq", "yjt", "uzh", "vby", "pv", "o", "g", "u", "k", "rw", "jyx", "xr", "wyh", "dq", "qrb", "e", "nl", "di", "l", "gwj", "zz", "cvh", "iah", "yif", "xtm", "wf", "iix", "o", "j", "kf", "lbz", "hq", "xp", "q", "ku", "uc", "ojp", "mym", "hft", "vrb", "bwu", "d", "tz", "m", "mhs", "vl", "n", "h", "nd", "kdl", "h", "gp", "pff", "ry", "ap", "puf", "lk", "s", "hh", "om", "x", "z", "pjy", "ye", "cah", "lwz", "rjx", "n", "cue", "jww", "o", "wu", "eh", "yci", "h", "gi", "bh", "al", "sms", "bca", "ye", "t", "ift", "y", "l", "is", "gdq", "s", "nx", "ch", "qy", "hl", "nfy", "zsm", "yy", "ecq", "sv", "re", "k", "fsn", "nre", "eu", "zf", "rq", "hqw", "jzh", "u", "kc", "si", "ilq", "ih", "iau", "v", "p", "gzm", "yx", "uef", "rq", "xap", "hve", "slp", "h", "s", "znc", "ua", "xp", "sr", "ty", "q", "va", "e", "w", "fzi", "v", "p", "rts", "ye", "vwl", "xf", "x", "s", "l", "xu", "jv", "dp", "gjl", "g", "g", "gom", "e", "nl", "aae", "ebd", "e", "fx", "w", "n", "w", "va", "h", "t", "g", "i", "f", "dpe", "p", "v", "m", "cx", "vgo", "d", "qq", "njn", "fr", "vuq", "rmv", "zk", "m" }, "hkn", "ae");
            //var result = MaxArea(new int[] { 2, 3, 10, 5, 7, 8, 9 });
            //var result = SearchMatrix2(GetMatrix("[[1, 4, 7, 11, 15],[2, 5, 8, 12, 19],[3, 6, 9, 16, 22],[10, 13, 14, 17, 24],[18, 21, 23, 26, 30]]"), 5);
            //var result = MaximumUnits(GetMatrix(" [[1, 3],[2, 2],[3, 1]]"),4);
            //var result = LargestSubarray(new int[] { 1, 4, 5, 2, 3 },3);
            //var result = SearchMatrix(GetMatrix("[[1]]"),1);
            //var result = TotalMoney(10);
            //var result = MaxNumberOfApples(new int[] { 900, 950, 800, 1000, 700, 800 });
            //var result = MinOperations("0100");
            //var result = RobotSim(new int[] { 4, -1, 4, -2, 4 },GetMatrix(" [[2,4]]"));
            //var result = IsArmstrong(153);
            //var result = MaxDepthAfterSplit("");
            //var result = CountBalls(1,10);
            //var result = CheckPossibility(new int[] {-1, 4, 2, 3});
            //var result = SumOfUnique(new int[] { 1, 2, 3, 2 });
            //var testBinSearch = testBinarySearch(new int[] { 1,2,3,3,4,4,4,4,7,8},5);
            //var result = BreakfastNumber(new int[] {2,1,1 },new int[] { 8, 9, 5, 1,6,6 },15);
            //var result = IsMajorityElement(new int[] { 2, 4, 5, 5, 5, 5, 5, 6, 6},5);
            //var result2 = ClosestValue(ConvertTreeFromArray(new int?[] { 4, 2, 5, 1, 3 }), 2.714286);
            //var result1 = FixedPoint(new int[] { -10, -5, -2, 0, 4, 5, 6, 7, 8, 9, 10 });
            //var test = findFirstPosition(new int[] { 3,4,5,5 }, 5);
            //var result = SearchRange(new int[]{ 5, 7, 7, 8, 8, 10},8);
            //var result = oddCells(2,3,GetMatrix(" [[0,1],[1,1]]"));
            //var result = LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            //var result = KthSmallest(GetMatrix("[[1,5,9],[10,11,13],[12,13,15]]"),8);
            //var result = IsToeplitzMatrix(GetMatrix("[[1,2,3,4],[5,1,2,3],[9,5,1,2]]"));
            //var result1 = MergeAlternately("abc","pqr");
            //var result = MaxSatisfied(new int[] { 1, 0, 1, 2, 1, 1, 7, 5 }, new int[] { 0, 1, 0, 1, 0, 1, 0, 1 }, 3);

            //var result = ArraysIntersection(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5, 7, 9 }, new int[] { 1, 3, 4, 5, 8 });
            //var result = CheckRotateArray(new int[] { 3,4,5,1,2});
            //var result = CountLetters("aaaaaaaaaa") ;
            //var result = DeleteNodes(GenerateListNodeFromArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),1,3);
            //var result = TwoSumLessThanK(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60);
            //var result = CalculateTime("pqrstuvwxyzabcdefghijklmno", "leetcode");
            //var result = AnagramMappings(new int[] { 12, 28, 46, 32, 50 }, new int[] { 50, 12, 32, 46, 28 });
            //var result = LargestAltitude(new int[] { -5, 1, 5, 0, -7 });
            //var result = RemoveElement(new int[] { 3, 2, 2, 3,3,1 },3);
            //var result = ReplaceSpace("We are happy.");
            //Console.WriteLine(result.ToString());
            //var result = WordPattern("abba", "dog cat cat fish");
            //var result = IsFlipedString("waterbottle", "erbottlewat");
            //var result = CommonChars(new string[] { "bella", "label", "roller" });
            //var result = FindLUSlength("abc","cdc");
            //var result = SortArrayByParity(new int[] {0,2 });
            //var result = FindLucky(new int[] { 2,3,3,2,2,1 });
            //var result = GcdOfStrings("ABABA", "ABAB");
            //var result = ReformatDate("20th Oct 2052");
            //var result = FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },new string[] { "KFC", "Burger King", "Tapioca Express", "Shogun" });
            //var result = NumberOfMatches(14);
            //var result = FirstUniqChar2("leetcode");
            //var result = ValidMountainArray(new int[] { 0,5, 5 });
            //var result = ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 },2);
            //var result = FindLHS(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 });
            //var result = ThirdMax(new int[] { 1, 2, -2147483648 });
            //MergeNum(new int[]{ 1, 2, 3, 0, 0, 0 },3,new int[]{ 2, 5, 6 },3);
            //var result = CanThreePartsEqualSum(new int[] {10, -10, 10, -10, 10, -10, 10, -10 });
            //var result = ReverseList();


            //var test = GenerateListNodeFromArray(new int[] { 5, 4, 3, 2, 1 });
            //var result = ReverseList(GenerateListNodeFromArray(new int[] { 5,4,3,2,1 }));
            //var result = ValidPalindrome("cbbcc");
            //var result = LengthOfLongestSubstring("abcabcbb");
            //var result = LargeGroupPositions("aaa"); 

            //var result = ConvertToTitle(576);
            //var result = MaxDepth("(1)+((2))+(((3)))");
            //var result = CountStudents(new int[] { 1, 1, 0, 0 }, new int[]{ 0, 1, 0, 1 });
            //var result2 = CountBinarySubstrings("00110011");
            //var result = MaxProfit20201026(new int[] { 3, 2, 6, 5, 0, 3 });
            //var result2 = DistributeCandies(new int[] { 1, 1, 2, 3});
            //var result = AddDigits(38);
            //var result = ShortestToChar("loveleetcode", 'e');
            //var result = MinimumAbsDifference(new int[] { 3, 8, -10, 23, 19, -4, -14, 27 });
            //var result = SortArrayByParityII(new int[] { 4,2,5,7 });
            //var result = MinStartValue(new int[] { -3, 2, -3, 4, 2 });
            //var result = FindString(new string[] { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" },"ball");
            //var result = SmallestRangeI(new int[] { 1, 3, 6 },3);
            //var result = Average(new int[] { 4000, 3000, 1000, 200 });
            //var result = NumRookCaptures(GetMatrixChar("[['.','.','.','.','.','.','.','.'],['.','.','.','p','.','.','.','.'],['.','.','.','R','.','.','.','p'],['.','.','.','.','.','.','.','.'],['.','.','.','.','.','.','.','.'],['.','.','.','p','.','.','.','.'],['.','.','.','.','.','.','.','.'],['.','.','.','.','.','.','.','.']]"));
            //var result = twoSum(new int[] { 10, 26, 30, 31, 47, 60 },40);
            //var result = FindDuplicate(new int[] { 1, 3, 4, 2, 2 });
            //var result = CountLargestGroup(13);
            //Hanota(new List<int> { 2,1,0},new List<kint> { }, new List<int> { });
            //var result = LargestPerimeter(new int[] { 2,1,2 });
            //var result = DetectCapitalUse("Tdsdsds");
            //var result = ReverseOnlyLetters("7_28]");
            //var result = MaxPower("cc");
            //var result = LargestTriangleArea(GetMatrix("[[0,0],[0,1],[1,0],[0,2],[2,0]]"));
            //var result = ToGoatLatin("Each word consists of lowercase and uppercase letters only");
            //var result = ThousandSeparator(1234);
            //var result = BitwiseComplement(0);
            //var result = MaxLengthBetweenEqualCharacters("aa");
            //var result = RotatedDigits(10000);
            //var result = Reverse(123);
            //var result = ReverseStr("abcdefg", 2);
            //var result = CountSegments("Of all the gin joints in all the towns in all the world, ");
            //var result = RelativeSortArray(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 1 }, new int[] { 2, 1, 4, 3, 9, 6 },);
            //var result = TwoSum2(new int[] { 2,7,11,15},9);
            //var result = PlusOne(new int[] {9 });
            //var result = CanPermutePalindrome("tactcoa");
            //var result = CompressString("bbbac");
            //var result = NumSmallerByFrequency(new string[] { "bba", "abaaaaaa", "aaaaaa", "bbabbabaab", "aba", "aa", "baab", "bbbbbb", "aab", "bbabbaabb" },new string[] { "aaabbb", "aab", "babbab", "babbbb", "b", "bbbbbbbbab", "a", "bbbbbbbbbb", "baaabbaab", "aa" });
            //var result = IslandPerimeter(GetMatrix("[[1,0]]"));
            //var result = AllPathsSourceTarget(new int[5][] { new int[3] { 4, 3, 1 }, new int[3] { 3, 2, 4 }, new int[1] { 3 }, new int[1] { 4 } , new int[0] {  }});
            //var result = MinDeletionSize(new string[] { "abcdef", "uvwxyz" });
            //var result = GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 });
            //var result = PartitionLabels("ababcbacadefegdehijhklij");
            //var result = MatrixScore(GetMatrix("[[0,0,1,1],[1,0,1,0],[1,1,0,0]]"));
            //var result = MaxProfit20201023(new int[] { 1, 3, 2, 8, 4, 9 },2);
            //var result = NumUniqueEmails(new string[] {"gm.e.i+vcj.fcn@m.hkelhyekj.com", "gm.e.i+kt.h.me+v@m.hkelhyekj.com", "gm.e.i+w.q+h.a.ai@m.hkelhyekj.com"});

            //var result = Exchange(new int[] { 1,  3, 5 });
            //var result = IsPrefixOfWord("i love eating burger", "burg");
            //var testt = 3 % 5;
            //var result = SurfaceArea(GetMatrix("[[1,2],[3,4]]"));
            //var result = MaxNumberOfBalloons("loonbalxballpoon");
            //var result = UncommonFromSentences("this apple is sweet",  "this apple is sour");
            //var result = DistributeCandies(10,3);
            //var result = ExpectNumber(new int[] { 1,1});
            //var result = (5);
            //var result = GetRow(3);
            //var result = IsAnagram("anagram","nagaram");
            //var result = RomanToInt("DCXXI");
            //var result = FindOcurrences("jkypmsxd jkypmsxd kcyxdfnoa jkypmsxd kcyxdfnoa jkypmsxd kcyxdfnoa kcyxdfnoa jkypmsxd kcyxdfnoa", "kcyxdfnoa","jkypmsxd");

            //int?[] arr = { 27, null, 34, null, 58, 50, null, 44, null, null, null };
            //TreeNode resultNode = ConvertTreeFromArray(arr);
            //int[] testArr = new int[6] { 2, 7, 4, 1, 8, 1};
            //var result = LastStoneWeight(testArr);
            //int[][] matrix = { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 1 } };
            //var result = gardenNoAdj(3, matrix);

            //var result = GetKth(12, 15, 2);
            //int[][] matrix = { new int[] { 0, 1 }, new int[] { 2, 0 }, new int[] { 1, 2 } };
            //var result = FindRedundantConnection(matrix);
            //var result = CountServers(matrix);
            //var result = CanReach(new int[] { 4, 2, 3, 0, 3, 1, 2},5);
            //var result = CanFinish(3, matrix);
            //var test2 = CountGoodTriplets(new int[] { 3, 0, 1, 1, 9, 7 },7,2,3);
            //var test3 = JudgeCircle("DD");
            //var test5 = SumOddLengthSubarrays(new int[] { 1, 4, 2 });
            //var test6 = IsPalindrome(121);
            //var test7 = NumSpecialEquivGroups(new string[] { "abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx" });
            //int[][] matrix = { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 1, 3 }, new int[] { 1, 10 }, new int[] { 1, 11 }, new int[] { 1, 4 }, new int[] { 2, 4 }, new int[] { 2, 6 }, new int[] { 2, 9 }, new int[] { 2, 10 }, new int[] { 2, 4 }, new int[] { 2, 5 }, new int[] { 2, 10 }, new int[] { 3, 7 }, new int[] { 3, 7 }, new int[] { 4, 5 }, new int[] { 4, 11 }, new int[] { 4, 11 }, new int[] { 4, 10 }, new int[] { 5, 7 }, new int[] { 5, 10 }, new int[] { 6, 8 }, new int[] { 7, 11 }, new int[] { 8, 10 } };
            //var result = IsBipartite(matrix);
            //int[][] matrix = { new int[] { 0, 1 }, new int[] { 2, 0 }, new int[] { 1, 2 } };
            //var result = EventualSafeNodes(matrix);
            //var result = FindWhetherExistsPath(12,matrix,2,3);
            //int[][] matrix = { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 1, 3 } };
            //var matrix = GetMatrix("[[5]]");
            //var test33 = FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
            //var test33 = GetValidT9Words("8733",new string[] { "tree", "used" });
            //ListNode head = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(4);
            //head.next = node2;
            //node2.next = node3;
            //ListNode head2 = new ListNode(1);
            //ListNode node22 = new ListNode(3);
            //ListNode node32 = new ListNode(4);
            //head2.next = node22;
            //node22.next = node32;

            //var result = MergeTwoLists2(head, head2);

            //var test44 = DiagonalSum(matrix);
            //var result = MaxDistance(matrix);
            //位运算
            //var result = MissingNumber2(new int[] { 3, 0, 1 });
            //var result = MajorityElement2(new int[] { 3, 2 });
            //var result = HasAlternatingBits(7);
            //var result = MissingNumber3(new int[] { 3,0,1});
            //var result = Add(13,8);
            //var result = ConvertInteger(1,2);
            //var result = ReverseBits2(7);
            //var result = IsPowerOfFour(16);
            //var result = InsertBits(1024,19,2,6); 
            //var result2 = ToHex(26);
            //var result = ArrayPairSum(new int[] { 1,4,2,3 });
            //var result = SingleNumber(new int[] { 2,2,1 });
            //var result = ExchangeBits(2);
            //var result = CountPrimeSetBits(10,15);
            //var result = SortByBits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });


            //var result = DiStringMatch("IDID");

            //var result = IsUnique("leetcode");
            //int[] arr2 = { 8, 7, 4, 2, 8, 1, 7, 7, 10, 1 };
            //var result = FinalPrices(arr2);
            //ListNode head = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(4);
            //head.next = node2;
            //node2.next = node3;
            //ListNode head2 = new ListNode(1);
            //ListNode node22 = new ListNode(3);
            //ListNode node32 = new ListNode(4);
            //head2.next = node22;
            //node22.next = node32;

            //var result = MergeTwoLists(head, head2);

            ////var result = SortString("aaaabbbbcccc");

            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = { 2, 4, 1, 3 };
            //var result = CanBeEqual(arr1, arr2);

            //int[][] matrix = { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 1 } };
            //var result = FreqAlphabets("10#11#12");
            //var result = SpiralOrder(matrix);
            //var result = ReplaceSpace("We are happy.");


            //int[][] matrix = { new int[] { 1,2 }, new int[] { 2,3 }, new int[] { 3,1 } };
            //var result = gardenNoAdj(3,matrix);
            //ListNode head = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(3);
            //ListNode node4 = new ListNode(4);
            //ListNode node5 = new ListNode(5);
            //head.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node5;
            //var result = ReverseList(head);
            //var result = ReversePrint(head);
            //var result = NumWaterBottles(9, 3);

            //ListNode head = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(3);
            //ListNode node4 = new ListNode(4);
            //ListNode node5 = new ListNode(5);
            //head.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node5;

            //var result = ReverseList(head);


            //var result = LuckyNumbers(matrix);
            ////var result = ReverseWords("Let's take LeetCode contest");
            ////var result = MinDiffInBST(resultNode);
            //var result = Tree2str(resultNode);

            //var result = DiameterOfBinaryTree(resultNode);

            //var result = FindSecondMinimumValue(resultNode);

            //var result = SumOfLeftLeaves(resultNode);
            //var result = FindTilt(resultNode);

            //var result = FindTargetIteration(resultNode, 4);
            //var result = IsBalancedNew(resultNode);


            //var result = ConvertBST(resultNode);

            //int[] compArr = { 8, 1, 2, 2, 3 };
            //var result = smallerNumbersThanCurrent(compArr);

            //int?[] arr = { 1, 2, 3, null, 5 };
            //var newTreeNode = ConvertTreeFromArray(arr);

            //var result = BinaryTreePaths(newTreeNode);

            //TreeNode node1 = new TreeNode(2);
            //TreeNode node2 = new TreeNode(4);
            //var result = LowestCommonAncestor(newTreeNode, node1, node2);
            //var result = SumRootToLeaf(newTreeNode);
            //var result = AverageOfLevels(newTreeNode);
            //TreeNode root = new TreeNode(1);

            //TreeNode node1 = new TreeNode(2);
            //TreeNode node2 = new TreeNode(3);
            //TreeNode node3 = new TreeNode(4);
            //root.left = node1;
            //root.right = node2;
            ////node1.left = node2;
            //lisTree = new List<int>();
            //var result=PostOrderTraversal(root);

            //var result2 = PreorderTraversal(root);
            //var result = InorderTraversal(root);
            //int[] nums1 = { 2, 4 }, nums2 = { 1, 2, 3, 4 };
            //var result = NextGreaterElement(nums1, nums2);
            //MyQueue q = new MyQueue();
            //q.Push(1);
            //q.Push(2);
            //int resul1 = q.Peek();
            //int resul12 = q.Pop();
            //bool result3 = q.Empty();

            //string[] arr = {"1","C","-62","-45","-68"    };
            //var result = CalPoints(arr);
            //string str = "abbaca";
            //var result = RemoveDuplicates(str);
            //var result = IsValid(str);

            //int[] arr = { 1, 3, -1, -3, 5, 3, 6,7 };
            ////int[] arr = {  5,4,1,2,6 };
            //var result = maxSlidingWindow(arr,3);

            //public static List<int> lisTreePre = new List<int>();

            //TreeNode root = new TreeNode(3);

            //TreeNode node1 = new TreeNode(9);
            //TreeNode node2 = new TreeNode(20);
            //root.left = node1;
            //root.right = node2;

            //TreeNode node3 = new TreeNode(15);
            //TreeNode node4 = new TreeNode(7);
            //node2.left = node3;
            //node2.right = node4;
            //lisTreePre = new List<int>();
            //InOrder(root);

            //lisTreePre = new List<int>();
            //PostOrder(root);

            //string[] lis = { "a", "b", "c" };
            //string strPreResult = string.Join("", lis);
            //int?[] arr = { 1, 2 };
            //TreeNode root = ConvertTreeFromArray(arr);
            //var result = MinDepth(root);

            //int?[] arr = { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 };
            //var exampleRoot = ConvertTreeFromArray(arr);\
            //var result = HasPathSum(exampleRoot, 22);

            ////var test1= testDFS(root);
            //var result = IsBalanced(root);
            //var result = DivingBoard(1, 2, 3);
            //int[] arr = { 3, 4, 5, 1, 2 };
            //var result = MinArray(arr);
            //var result = IsPerfectSquare(16);
            //int[] arr = { 4, - 3, 5, - 2, - 1, 2 ,6 ,- 2 };
            //var result=GetLeastNumbers(arr,3);

            //var result = MaxSubArray(arr);
            //int[] arr = { 1, 2, 3, 2, 2, 2, 5, 4, 2 };
            //var result = MajorityElement(arr);
            //int[] arr = { 1, 3, 5, 6 };
            //var result = SearchInsert(arr, 4);
            //var result = GuessNumber(10);
            //int[] arr = { 1 };
            //var result2 = findIndex(arr, 3);
            //var result = SearchTimes(arr, 1);
            //int[] arr = { 0, 0, 2 };
            //var result = FindMagicIndex(arr);
            //var result = MySqrt(8);

            //int[][] mat = new int[5][];
            //int[] arr1 = { 1, 1, 0, 0, 0 };//2
            //int[] arr2 = { 1, 1, 1, 1, 0 };//4
            //int[] arr3 = { 1, 0, 0, 0, 0 };//1
            //int[] arr4 = { 1, 1, 0, 0, 0 };//2
            //int[] arr5 = { 1, 1, 1, 1, 1 };//5
            //mat[0] = arr1;
            //mat[1] = arr2;
            //mat[2] = arr3;
            //mat[3] = arr4;
            //mat[4] = arr5;
            //var result = KWeakestRows(mat, 3);

            //int[] arr = { -1, 0, 3, 5, 9, 12 };
            //var result = Search(arr, 2);

            //int[] arr = { 0 };
            //var result = MissingNumber(arr);

            //string S = "ae##";
            //string T = "c#d#";
            //BackspaceCompare(S, T);
            //int[] arrA = { 1, 2, 3, 0, 0, 0 };
            //int[] arrB = { 2, 5, 6 };
            //Merge(arrA, 3, arrB, 3);
            //int[] arr = { 6, 2, 1, 4, 5, 3, 8, 10, 11 };// 
            //var result = MergeSort(arr, 0, arr.Length - 1);

            //string str1 = "zlexya";
            //string str2 = "aazlllllllllllllleexxxxxxxxxxxxxxxya";


            //var result = StrStr(str1, str2);
            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //var result = Intersect(nums1, nums2);
            //int[] nums = { 2, 7, 11, 15 };
            //var result = TwoSum(nums, 9);

            ////环形链表
            //ListNode head = new ListNode(3);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(0);
            //ListNode node4 = new ListNode(4);
            //head.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node2;
            //var result = HasCycle(head);
            //创建链表
            //int[] arr = { 3, 2, 0, 4 };
            //ListNode head = new ListNode(arr[0]);
            //ListNode tempCurrNode = head;
            //ListNode tempNode = null;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    tempNode = new ListNode(arr[i]);
            //    tempCurrNode.next = tempNode;
            //    tempCurrNode = tempNode;

            //}
            //int[] arr = { -4, -1, 0, 3, 10 };
            //var result = SortedSquares(arr);
            //int[] arr3 = { 6, 2, 1, 4, 5, 3, 8, 10, 11 };
            //BinarySearch(arr3, 0, arr3.Length - 1, 8);

            //int[] arr1 = { 4, 5, 9 };
            //int[] arr2 = { 0, 4, 9, 8, 4 };
            //var result = Intersection(arr1, arr2);
            //int[] arr = { 0, 1, 2, 2 };
            //var result = TotalFruit(arr);
            //int[] arr = { 1, 2, 3 };
            //ListNode node1 = new ListNode(arr[0]);
            //ListNode otherNode = node1;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    ListNode tempLN = new ListNode(arr[i]);
            //    otherNode.next = tempLN;
            //    otherNode = tempLN;
            //}
            //var result = KthToLast(node1, 3);
            //Console.WriteLine(result);

            //string str = ",.";
            //ReverseVowels(str);

            //int[] nums = { 0, 1, 0, 0, 3, 12 };
            //RemoveElement(nums, 3);

            //int[] nums = { 0, 1, 0, 3, 12 };
            //RemoveElement(nums, 3);
            //MoveZeroesByNewList(nums);
            //MoveZeroes(nums);
            //int[][] arr2d = new int[1][];
            //int[] arr1 = { -1, 3 };
            //int[] arr2 = { 2, 5, 8, 12, 19 };
            //int[] arr3 = { 3, 6, 9, 16, 22 };
            //int[] arr4 = { 10, 13, 14, 17, 24 };
            //int[] arr5 = { 18, 21, 23, 26, 30 };
            //arr2d[0] = new int[2];
            //arr2d[1] = new int[5];
            //arr2d[2] = new int[5];
            //arr2d[3] = new int[5];
            //arr2d[4] = new int[5];
            //GenerateMatrixByLine(arr2d, arr1, 0);
            //GenerateMatrixByLine(arr2d, arr2, 1);
            //GenerateMatrixByLine(arr2d, arr3, 2);
            //GenerateMatrixByLine(arr2d, arr4, 3);
            //GenerateMatrixByLine(arr2d, arr5, 4);

            //var result = FindNumberIn2DArray(arr2d, 3);

            //Console.WriteLine(result);
            //var result = LargestSumAfterKNegations(arr, 5);
            //int[] arr = { 1, 2, 3, 4, 5 };
            //ListNode node1 = new ListNode(arr[0]);
            //ListNode otherNode = node1;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    ListNode tempLN = new ListNode(arr[i]);
            //    otherNode.next = tempLN;
            //    otherNode = tempLN;
            //}

            //var result = IsPalindrome(node1);
            //string str = ".";
            //var result = IsPalindrome(str);
            //ListNode ln1 = new ListNode(1);
            //ListNode ln2 = new ListNode(2);
            //ListNode ln3 = new ListNode(3);
            //ListNode ln4 = new ListNode(4);
            //ListNode ln5 = new ListNode(5);
            //ListNode ln6 = new ListNode(6);
            //ln1.next = ln2;
            //ln2.next = ln3;
            //ln3.next = ln4;
            //ln4.next = ln5;
            //ln5.next = ln6;
            //GetKthFromEnd(ln1, 2);
            //char[] arr = { 'h', 'e', 'l', 'l', 'o' };
            //ReverseString(arr);
            //int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //var result = RemoveDuplicates(arr);
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 1, 1 };
            //var result = FindContentChildren(arr1, arr2);
            //Console.WriteLine(result);
            //var result = LemonadeChange(arr);
            //string[] s = { "cba", "daf", "ghi" };
            //var result = MinDeletionSize(s);
            ////List<int[]> lis = new List<int[]>();
            ////lis.Add(new int{10,20});
            ////[10,20],[30,200],[400,50],[30,20]
            //int[][] arr = new int[4][];
            //arr[0] = new int[] { 10, 20 };
            //arr[1] = new int[] { 30, 200 };
            //arr[2] = new int[] { 400, 50 };
            //arr[3] = new int[] { 30, 20 };
            ////int sum = 0;
            ////arr[0] = new int[] { 259,770 };
            ////arr[1] = new int[] { 926,667 };
            ////arr[2] = new int[] { 184,139 };
            ////arr[3] = new int[] { 840,118 };
            ////           arr[4] = new int[] { 577,46 };
            ////           arr[5] = new int[] { 448,54};
            //TwoCitySchedCost(arr);

            //int[] nums = { 4, 3, 10, 9, 8 };
            //int[] nums = { 4, 3, 10, 9, 8 };
            //var result2 = MinSubsequence(nums);
            //            int[] arrInt = { 2,2,2,3,3};
            //MinCostToMoveChips(arrInt);
            //int[] arr = { 7, 1, 5, 3, 6, 4 };
            //var result = MaxProfit(arr);

            //var result = MaxSubArray(arr);

            //var result = MaxProduct(arr);
            //int[] arr = { 2, 1, 1, 2 };
            //var result = Rob2(arr);
            //int[] arr = { 2, 1, 1, 2 };
            //var resul = Rob(arr);
            //var result = WaysToStep(61);
            //string str1 = "leeeeetcode";
            //string str2 = "yyyyylyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyeyyyyyyeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyytyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyycyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyoyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyydyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyeyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy";
            //var result = IsSubsequence(str1, str2);
            //string strTest1 = " beijing olympic sport game  !1234567890";
            //byte[] barr1 = System.Text.Encoding.GetEncoding("GBK").GetBytes(strTest1);
            //int testlength1 = barr1.Length;

            //string strTest2 = "北京奥运会 beijing olympic sport game  !1234567890";
            //byte[] barr2 = System.Text.Encoding.GetEncoding("GBK").GetBytes(strTest2);
            //int testlength2 = barr2.Length;
            //string strTest3 = "北京奥运会";
            //byte[] barr3 = System.Text.Encoding.GetEncoding("GBK").GetBytes(strTest3);
            //int testlength3 = barr3.Length;
            //5个一行
            //string strSubtring1 = CutByteString(strTest2, 0, 15);
            //var testArr = strSubtring1.ToArray();
            //var testarr2 = Encoding.Default.GetBytes(strSubtring1);
            //Console.WriteLine(strSubtring1);
            //var rest = MinCostClimbingStairs(arr);
            //int[] arrInt = { -1 };
            //var sumResult = MaxSubArray(arrInt);

            //var result = jump(8);
            //var result = cutting(8);

            //int[] inpuarr = { 2, 1, 1, 2 };
            //int sum = Rob(inpuarr);
            //int[] arrIntNums = { 0, 1, 2, 3, 4 };
            //int[] index = { 0, 1, 2, 2, 1 };
            //int[] result = CreateTargetArray(arrIntNums, index);
            //ListNode ln1 = new ListNode(1);
            //ListNode ln2 = new ListNode(2);
            //ListNode ln3 = new ListNode(3);
            //ListNode ln4 = new ListNode(4);
            //ListNode ln5 = new ListNode(5);
            //ListNode ln6 = new ListNode(6);
            //ln1.next = ln2;
            //ln2.next = ln3;
            //ln3.next = ln4;
            //ln4.next = ln5;
            //ln5.next = ln6;
            //GetKthFromEnd(ln1, 2);

            //int[] arrInt={-10,-3,0,5,9};
            //SortedArrayToBST(arrInt);
            //int[] prices = {1, 3, 2, 8, 4, 9};
            //int fee = 2;
            //int result = maxProfit(prices,fee);

            //int result = BalancedStringSplit("RLRRLLRLRL");
            //ListNode ln1 = new ListNode(1);
            //ListNode ln2 = new ListNode(0);
            //ListNode ln3 = new ListNode(1);
            //ln1.next = ln2;
            //ln2.next = ln3;

            //var result = GetDecimalValue(ln1);
            //int test = 2 ^ 2;
            //if ((2 ^ 2) == 0)
            //{

            //}
            //TreeNode root = new TreeNode(4);

            //TreeNode node1 = new TreeNode(2);
            //TreeNode node2 = new TreeNode(7);
            //root.left = node1;
            //root.right = node2;

            //TreeNode node3 = new TreeNode(1);
            //TreeNode node4 = new TreeNode(3);
            //node1.left = node3;
            //node1.right = node4;

            //var result = SearchBST(root, 2);
            ////SelfDividingNumbers
            //var selfResult = SelfDividingNumbers(1, 22); 

            //int[] arrInt = new int[5];

            ////test
            //Console.WriteLine("please input words");
            //var input = Console.ReadLine();
            //string ss = input.ToString();
            //Console.WriteLine("what you input is:"+ss);
            //Console.ReadKey();
            //var testRead = Console.Read();

            ////GetSumZeroArray
            //Stack<int> testStack = GetSumZeroArray(6);
            //List<int> listResult= testStack.ToList();

            //Console.WriteLine(string.Join(",", listResult));
            //Console.ReadLine();
            //var result = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 },8);
            //var result = LetterCombinations("23");
            //var result = TopKFrequent2(new string[] { "i", "love", "leetcode", "i", "love", "coding" },2);
            //var result = CheckStraightLine(GetMatrix(" [[-4,-3],[1,0],[3,-1],[0,-1],[-5,2]]"));
            //var result = LongestWord(new string[] { "yo", "ew", "fc", "zrc", "yodn", "fcm", "qm", "qmo", "fcmz", "z", "ewq", "yod", "ewqz", "y" });
            //var result = IsRectangleOverlap(new int[] { 1, 13, 16, 20 }, new int[] { 2, 12, 11, 18 });
            //var result = AddToArrayForm(new int[] { 0}, 23);
            //var result = ExpressiveWords("",new string[] { });
            //var result = lowestCommonAncestor3(ConvertTreeFromArray(new int?[] { 3, 5, 1 }),new TreeNode(5),new TreeNode(1));
            //var result = MaxDepth(Node);
            //var result = SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });
            //var result = fraction(new int[] { 0,0,3});
            //Hanota(new List<int>() { 4,3,2,1}, new List<int>() , new List<int>());
            //var result = CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");
            //var result = MinOperations(new int[] { 1, 5, 2, 4, 1 });
            //var result = IncreasingBST(ConvertTreeFromArray(new int?[] { 2,1,3 }));
            //var result = IsPowerOfThree(27);
            //var result = RangeSumBST2(ConvertTreeFromArray(new int?[] { 10, 5, 15, 3, 7, null, 18 }),7,15);
            //var result = AllCellsDistOrder(2,3,1,2);
            //var result = SumBase(34,6);
            //DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
            //var result = NumEquivDominoPairs(GetMatrix("[[1,2],[1,2],[1,1],[1,2],[2,2]]")) ;
            //var result = PrefixesDivBy5(new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 });
            //var result = FindKthPositive(new int[] { 1,2,3,4 },2);
            //var result = CanFormArray(new int[] { 97, 80, 56, 85, 60, 33, 26, 23, 99, 98, 19, 34, 30, 66 },GetMatrix("[[98,19],[23,99],[97,80,56,85,60],[33,26],[34],[30,66]]"));
            //var result = DayOfTheWeek(31,8,2009);
            //var result2 = LicenseKeyFormatting("5F3Z-2e-9-w", 4);
            #endregion

            #region UnFinished/error
            //var result = FirstBadVersion(2126753390);
            //Console.WriteLine("Finished");
            //int[] houseArr = { 1, 5 };
            //int[] radiusArr = { 2 };
            //var result = FindRadius(houseArr, radiusArr);
            //var result = ArrangeCoins(2147483647);

            //var result = FindPairs(arr,1);
            //Console.WriteLine(result);

            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            //var result = ThreeSum(arr);

            #endregion


            //var result = Combine(4,2);
            //var result = CombinationSum2(new int[] { 2, 5, 2, 1, 2 },5);
            //var result = CombinationSum3(3,7);
            //var result = PermuteUnique(new int[] { 2,2,1,1 });;
            //var rewsult = NumTilePossibilities("AAABBC");
            //var result = Permutation2("qqe");
            //var result = Partition3("aab");
            //var result = LetterCasePermutation("ab");
            var result = Permutation4("abc");
            Console.WriteLine("end");
            Console.ReadKey();
        }
        public static string[] Permutation4(string s)
        {
            List<string> res = new List<string>();
            LinkedList<char> path = new LinkedList<char>();
            bool[] used = new bool[s.Length];
            Permutation4_DFS(s,res,path,used);
            return res.ToArray();
        }
        public static void Permutation4_DFS(string s, List<string> res, LinkedList<char> path, bool[] used)
        {
            if (path.Count==s.Length)
            {
                res.Add(new String(path.ToArray()));
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }
                path.AddLast(s[i]);
                used[i] = true;
                Permutation4_DFS(s,res,path,used);
                used[i] = false;
                path.RemoveLast();
            }
        }
        /// <summary>
        ///784. 字母大小写全排列 https://leetcode-cn.com/problems/letter-case-permutation/
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static IList<string> LetterCasePermutation(string S)
        {
            char[] arr = S.ToCharArray();
            IList<string> res = new List<string>();
            LinkedList<char> path = new LinkedList<char>();
            LetterCasePermutation_DFS(arr,res,0);
            return res;
        }
        public static void LetterCasePermutation_DFS(char[] arr, IList<string> res, int index)
        {
            if (index == arr.Length)
            {
                res.Add(new String(arr));
                return;
            }
            LetterCasePermutation_DFS(arr, res, index + 1);
            if (!(arr[index] <= '9' && arr[index] >= '0'))
            {
                if (arr[index] >= 'a' && arr[index] <= 'z')
                    arr[index] = (char)(arr[index] + ('A' - 'a'));
                else
                    arr[index] = (char)(arr[index] - ('A' - 'a'));

                LetterCasePermutation_DFS(arr, res, index + 1);
            }
        }
        /// <summary>
        ///131. 分割回文串 https://leetcode-cn.com/problems/palindrome-partitioning/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IList<IList<string>> Partition3(string s)
        {
            char[] arr = s.ToCharArray();
            
            IList<IList<string>> res = new List<IList<string>>();
            LinkedList<string> path = new LinkedList<string>();
            Partition3_DFS(arr,res,path,0);
            return res;
        }
        public static void  Partition3_DFS(char[] arr , IList<IList<string>> res, LinkedList<string> path,int start)
        {
            if (start == arr.Length)
            {
                //res.Add(new List<string>(path.ToArray()));
                res.Add(new List<string>(path));
                return;
            }
            for (int i = start; i < arr.Length; i++)
            {
                if (Partition3_IsPalind(arr,start,i))
                {
                    path.AddLast(new String(arr,start,i-start+1));
                    Partition3_DFS(arr,res,path,i+1);
                    path.RemoveLast();
                }
            }
        }
        public static bool Partition3_IsPalind(char[] arr,int left,int right)
        {
            while (left<right)
            {
                if (arr[left]!=arr[right])
                {
                    return false;
                }
                left ++;
                right--;
            }
            return true;
        }
        /// <summary>
        /// 面试题 08.08. 有重复字符串的排列组合 https://leetcode-cn.com/problems/permutation-ii-lcci/
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string[] Permutation2(string S)
        {
            char[] arr = S.ToCharArray();
            Array.Sort(arr);
            bool[] used = new bool[arr.Length];
            List<string> res = new List<string>();
            LinkedList<char> path = new LinkedList<char>();
            Permutation2_DFS(arr, res,path,used);
            return res.ToArray();
        }
        public static void Permutation2_DFS(char[] arr, List<string> res, LinkedList<char> path, bool[] used)
        {

            if (path.Count == arr.Length)
            {
                res.Add(new String(path.ToArray()));
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                if (i > 0 && arr[i] == arr[i - 1] && used[i - 1])
                {
                    continue;
                }
                path.AddLast(arr[i]);
                used[i] = true;
                Permutation2_DFS(arr, res, path, used);
                used[i] = false;
                path.RemoveLast();
            }
        }
        /// <summary>
        /// 1079. 活字印刷 https://leetcode-cn.com/problems/letter-tile-possibilities/
        /// </summary>
        /// <param name="tiles"></param>
        /// <returns></returns>
        public static int NumTilePossibilities(string tiles)
        {
            int n = tiles.Length;
            char[] tilesArr = tiles.ToCharArray();
            Array.Sort(tilesArr);
            bool[] used = new bool[n];
            LinkedList<char> path = new LinkedList<char>();
            IList<IList<char>> res = new List<IList<char>>();
            int[] count = new int[1];
            NumTilePossibilities_DFS(tilesArr, 0,0,used,path, res, count);
            return count[0];

        }
        public static void NumTilePossibilities_DFS(char[] tiles,int start,int depth,bool[] used, LinkedList<char> path, IList<IList<char>> res,int[] count)
        {
  
 
            if (depth> tiles.Length)
            {
                return;
            }
            for (int i = 0; i < tiles.Length; i++)
            {
                if (used[i] || (i-1 >= 0 && tiles[i] == tiles[i - 1] && !used[i - 1]))
                {
                    continue;
                }

                count[0]++;

                path.AddLast(tiles[i]);
                res.Add(new List<char>(path));
                
                used[i] = true;
                NumTilePossibilities_DFS(tiles, i, depth + 1, used, path, res, count);
                used[i] = false;

                path.RemoveLast();
            }
        }
        /// <summary>
        /// 47. 全排列 II https://leetcode-cn.com/problems/permutations-ii/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            int len = nums.Length;
            IList<IList<int>> res = new List<IList<int>>();
            if (len == 0)
            {
                return res;
            }

            // 排序（升序或者降序都可以），排序是剪枝的前提
            Array.Sort(nums);

            bool[] used = new bool[len];
            // 使用 Deque 是 Java 官方 Stack 类的建议
            LinkedList<int> path = new LinkedList<int>();
            PermuteUnique_DFS(nums, nums.Length, 0, used, new List<int>(), res);
            return res;
            //IList<IList<int>> res = new List<IList<int>>();
            //IList<int> tmpLis = new List<int>();
            //Array.Sort(nums);
            //bool[] used = new bool[nums.Length];
            //PermuteUnique_DFS(nums,res,tmpLis,used,0);
            //return res;

        }
        private static void PermuteUnique_DFS(int[] nums, int len, int depth, bool[] used, List<int> path, IList<IList<int>> res)
        {
            if (depth == len)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                if (used[i])
                {
                    continue;
                }

                // 剪枝条件：i > 0 是为了保证 nums[i - 1] 有意义
                // 写 !used[i - 1] 是因为 nums[i - 1] 在深度优先遍历的过程中刚刚被撤销选择
                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                {
                    continue;
                }

                path.Add(nums[i]);
                used[i] = true;

                PermuteUnique_DFS(nums, nums.Length, depth + 1, used, path, res);
                // 回溯部分的代码，和 dfs 之前的代码是对称的
                used[i] = false;
                path.RemoveAt(path.Count-1);
            }
        }


        /// <summary>
        /// 216. 组合总和 III https://leetcode-cn.com/problems/combination-sum-iii/
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> tmpLis = new List<int>();
            int[] arr = new int[] { 1,2,3,4,5,6,7,8,9};
            CombinationSum3_DFS(arr,0,k, n,0,res,tmpLis);
            return res;
        }
        public static void CombinationSum3_DFS(int[] arr,int sum,int k, int n, int start,IList<IList<int>> res, IList<int> tmpLis)
        {
            if (tmpLis.Count>k)
            {
                return;
            }
            if (tmpLis.Count==k&&sum==n)
            {
                res.Add(new List<int>(tmpLis));
            }
            for (int i = start; i < arr.Length&&tmpLis.Count<k&&sum<n; i++)
            {
                sum += arr[i];
                tmpLis.Add(arr[i]);
                CombinationSum3_DFS(arr,sum,k,n, i + 1,res,tmpLis);
                tmpLis.Remove(arr[i]);
                sum -= arr[i];
            }
        }
        /// <summary>
        ///40. 组合总和 II https://leetcode-cn.com/problems/combination-sum-ii/
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> tmpLis = new List<int>();
            Array.Sort(candidates);
            CombinationSum2_DFS(candidates,target,0,0,tmpLis,res);
            return res;
        }
        public static void CombinationSum2_DFS(int[] candidates, int target,int start,int sum, List<int> tmpLis, IList<IList<int>> res)
        {
            if (sum==target)
            {
                res.Add(new List<int>(tmpLis));
                return;
            }
            if (sum>target)
            {
                return;
            }
            for (int i =start; i < candidates.Length; i++)
            {
                if (i>start&& candidates[i]==candidates[i-1])
                {
                    continue;
                }
                tmpLis.Add(candidates[i]);
                sum += candidates[i];
                CombinationSum2_DFS(candidates,target,i+1,sum,tmpLis,res);
                tmpLis.Remove(candidates[i]);
                sum -= candidates[i];
            }
        }

        /// <summary>
        ///77. 组合 https://leetcode-cn.com/problems/combinations/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> tmpLis = new List<int>();
            Combine_DFS(n,k,1,tmpLis,res);
            return res;
        }

        public static void Combine_DFS(int n, int k,int begin,List<int> tmpList,IList<IList<int>> res)
        {
            if (tmpList.Count==k)
            {
                res.Add(new List<int>(tmpList));
            }
            if (tmpList.Count>k)
            {
                return;
            }
            for (int i = begin; i < n - (k - tmpList.Count) +1; i++)
            {
                tmpList.Add(i);
                    
                string tmp = "";
                for (int g = 0; g < tmpList.Count; g++)
                {
                    tmp += tmpList[g] +",";
                }
                Console.WriteLine("前："+tmp);


                Combine_DFS( n,k,i+1,tmpList,res);
    
                tmpList.Remove(i);

                tmp = "";
                for (int g = 0; g < tmpList.Count; g++)
                {
                    tmp += tmpList[g] + ",";
                }
                Console.WriteLine("后：" + tmp);
            }
        }

        /// <summary>
        /// 测试引用类型
        /// </summary>
        public static void testA()
        {
            List<int> lis = new List<int>();
            string str = "";
            int ii = 3;
            testB(lis,str,ii);
        }
        public static void testB(List<int> lis,string str,int ii)
        {
            lis.Add(2);
            str = "1";
            ii = 88;
        }
        /// <summary>
        ///39. 组合总和 https://leetcode-cn.com/problems/combination-sum/
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <returns></returns>

        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> CombinationSum_Res= new List<IList<int>>();
            Array.Sort(candidates);
            List<int> tmpList = new List<int>();
            CombinationSum_DFS(CombinationSum_Res,candidates,tmpList,target,0);
            return CombinationSum_Res;

        }

        public static void CombinationSum_DFS(IList<IList<int>> res, int[] candidates, List<int> tmpList, int target,int start )
        {
            if (target<0)
            {
                return;
            }
            if (target==0)
            {
                res.Add(new List<int>( tmpList));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (candidates[i]>target)
                {
                    break;
                }
                tmpList.Add(candidates[i]);
                CombinationSum_DFS(res,candidates,tmpList,target-candidates[i],i);
                tmpList.Remove(candidates[i]);
            }
        }
        /// <summary>
        ///78. 子集  https://leetcode-cn.com/problems/subsets/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> Subsets_res;
        public static IList<IList<int>> Subsets(int[] nums)
        {
            
            Subsets_res = new List<IList<int>>();
            List<int> temp = new List<int>();
            Subsets_DFS(nums,0,temp);
            return Subsets_res;
        }
        public static void Subsets_DFS(int[] nums,int start,List<int> temp)
        {
            Subsets_res.Add(new List<int>(temp) );
            for (int i = start; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                Subsets_DFS(nums,i+1,temp);
                temp.Remove(nums[i]);
            }
        }
        /// <summary>
        /// 55. 跳跃游戏 https://leetcode-cn.com/problems/jump-game/
        /// </summary>
        /// <returns></returns>
        public static bool CanJump(int[] nums)
        {
            int distance = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (i<=distance)
                {
                    distance = Math.Max(distance,nums[i]+i);
                }
            }
            return distance+1 >= nums.Length;
        }
        /// <summary>
        ///64. 最小路径和  https://leetcode-cn.com/problems/minimum-path-sum/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MinPathSum(int[][] grid)
        {
            #region dp
            ////dp
            //int m = grid.Length, n = grid[0].Length;
            //int[][] dp = new int[m][];
            //for (int i = 0; i < dp.Length; i++)
            //{
            //    dp[i] = new int[n];
            //}

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i-1<0&&j-1<0)
            //        {
            //            dp[i][j] = grid[i][j];
            //        }
            //        else if (i-1>-1&&j-1>-1)
            //        {
            //            dp[i][j] = grid[i][j] + Math.Min(dp[i-1][j],dp[i][j-1]);
            //        }
            //        else
            //        {
            //            if (i - 1 > -1)
            //            {
            //                dp[i][j] += grid[i][j] + dp[i - 1][j];
            //            }
            //            else if (j - 1 > -1)
            //            {
            //                dp[i][j] += grid[i][j] + dp[i][j - 1];
            //            }
            //        }

            //    }
            //}
            //return dp[m - 1][n - 1];
            #endregion

            ////DFS  memo
            int m = grid.Length, n = grid[0].Length;
            int[][] memoArr = new int[m][];
            for (int i = 0; i < m; i++)
            {
                memoArr[i] = new int[n];
            }
            return MinPathSum_DFS(grid, m, n, 0, 0, memoArr);
        }
        public static int MinPathSum_DFS(int[][] grid, int m, int n, int x, int y, int[][] memo)
        {
            if (!(x < m && y < n))
            {
                return int.MaxValue;
            }
            if (x == m - 1 && y == n - 1)
            {
                return grid[x][y];
            }

            int right = x + 1 >= m ? int.MaxValue : (memo[x + 1][y] > 0 ? (memo[x + 1][y]) : MinPathSum_DFS(grid, m, n, x + 1, y, memo));
            int down = y + 1 >= n ? int.MaxValue : (memo[x][y + 1] > 0 ? (memo[x][y + 1]) : MinPathSum_DFS(grid, m, n, x, y + 1, memo));
            memo[x][y] = grid[x][y] + Math.Min(right, down);
            return memo[x][y];

        }
        /// <summary>
        /// 12. 整数转罗马数字 https://leetcode-cn.com/problems/integer-to-roman/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntToRoman(int num)
        {
            int index = 0;
            string[] romaArr = new string[] { "I", "V", "X", "L", "C", "D", "M" };
            string res = "";
            while (num > 0)
            {
                int curr = num % 10;
                string currStr = "";
                if (curr != 0)
                {
                    if (curr > 0 && curr < 4)
                    {
                        for (int i = 0; i < curr; i++)
                        {
                            currStr += romaArr[index];
                        }
                    }
                    else if (curr == 4)
                    {
                        currStr += romaArr[index] + romaArr[index + 1];
                    }
                    else if (curr >= 5 && curr < 9)
                    {
                        currStr += romaArr[index + 1];
                        if (curr > 5 && curr < 9)
                        {
                            for (int i = 0; i < curr - 5; i++)
                            {
                                currStr += romaArr[index];
                            }
                        }
                    }
                    else//9
                    {
                        currStr += romaArr[index] + romaArr[index + 2];
                    }
                    res = currStr + res;
                }
                index += 2;
                num /= 10;
            }
            return res;


        }
        /// <summary>
        /// 62. 不同路径 https://leetcode-cn.com/problems/unique-paths/
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int UniquePaths(int m, int n)
        {
            int[][] dp = new int[m][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[n];
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i][j] = 1;
                    }
                    else
                    {
                        //dp[i][j] += (i - 1 > -1 ? dp[i - 1][j] : 0) + ((j-1)>-1?dp[i][j-1]:0);
                        dp[i][j] += dp[i - 1][j] + dp[i][j - 1];
                    }

                }
            }
            return dp[m - 1][n - 1];
        }

        /// <summary>
        ///24. 两两交换链表中的节点  https://leetcode-cn.com/problems/swap-nodes-in-pairs/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode rest = head.next.next;
            ListNode newHead = head.next;
            newHead.next = head;
            head.next = SwapPairs(rest);
            return newHead;
        }
        /// <summary>
        /// 46. 全排列 https://leetcode-cn.com/problems/permutations/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> PermuteLis;
        public static IList<IList<int>> Permute(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
                return PermuteLis;

            bool[] used = new bool[n];
            PermuteLis = new List<IList<int>>();
            Permute_DFS(new List<int> { }, used, nums, 0, nums.Length);
            return PermuteLis;
        }
        public static void Permute_DFS(List<int> path, bool[] used, int[] nums, int currDepth, int n)
        {
            if (currDepth == n)
            {
                //List<int> temp = new List<int>();
                //for (int i = 0; i < n; i++)
                //{
                //    temp.Add(path[i]);
                //}
                PermuteLis.Add(new List<int>(path));

                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    path.Add(nums[i]);
                    Permute_DFS(path, used, nums, currDepth + 1, n);
                    used[i] = false;
                    path.Remove(nums[i]);
                }
            }

        }
        /// <summary>
        ///5817. 判断字符串是否可分解为值均等的子串  https://leetcode-cn.com/problems/check-if-a-string-is-decomposble-to-value-equal-substrings/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDecomposable(string s)
        {
            int i = 0, j = 1, twoCount = 0;
            while (i < s.Length)
            {
                j = i + 1;
                while (j < s.Length && s[i] == s[j])
                    j++;
                if ((j - i) % 3 == 1)
                    return false;
                else if ((j - i) % 3 == 2)
                {
                    twoCount++;
                    if (twoCount > 1)
                    {
                        return false;
                    }
                }
                i = j;
            }
            return twoCount == 1;
        }
        /// <summary>
        /// 1302. 层数最深叶子节点的和 https://leetcode-cn.com/problems/deepest-leaves-sum/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        /// 
        public static int DeepestLeavesSum_Sum = 0;
        public static int DeepestLeavesSum_MaxDepth = -1;
        public static int DeepestLeavesSum(TreeNode root)
        {

            #region BFS 

            //////BFS
            //if (root == null)
            //    return 0;

            //int sum = 0;
            //LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            //queue.AddLast(root);
            //while (queue.Count>0)
            //{
            //    int currCount = queue.Count();
            //    sum = 0;
            //    while (currCount>0)
            //    {
            //        TreeNode curr = queue.First();
            //        queue.RemoveFirst();
            //        sum +=curr.val;
            //        if (curr.left!=null)
            //        {
            //            queue.AddLast(curr.left);
            //        }
            //        if (curr.right!=null)
            //        {
            //            queue.AddLast(curr.right);
            //        }
            //        currCount--;
            //    }
            //}
            //return sum;
            #endregion

            DeepestLeavesSum_DFS2(root, 0);
            return DeepestLeavesSum_Sum;


            ////DFS
            //int maxDepth = DeepestLeavesSum_GetDepth(root, 0);

            //DeepestLeavesSum_DFS(root,1, maxDepth);


            //return DeepestLeavesSum_Sum;
        }
        public static void DeepestLeavesSum_DFS2(TreeNode root, int currDepth)
        {
            if (root == null)
            {
                return;
            }
            if (currDepth > DeepestLeavesSum_MaxDepth)
            {
                DeepestLeavesSum_Sum = root.val;
                DeepestLeavesSum_MaxDepth = currDepth;

            }
            else if (currDepth == DeepestLeavesSum_MaxDepth)
            {
                DeepestLeavesSum_Sum += root.val;
            }
            DeepestLeavesSum_DFS2(root.left, currDepth + 1);
            DeepestLeavesSum_DFS2(root.right, currDepth + 1);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static void DeepestLeavesSum_DFS(TreeNode root, int currDepth, int maxDepth)
        {

            if (root == null)
            {
                return;
            }
            if (currDepth == maxDepth)
            {
                DeepestLeavesSum_Sum += root.val;
            }
            DeepestLeavesSum_DFS(root.left, currDepth + 1, maxDepth);
            DeepestLeavesSum_DFS(root.right, currDepth + 1, maxDepth);

        }

        public static int DeepestLeavesSum_GetDepth(TreeNode root, int currDepth)
        {
            if (root == null)
            {
                return currDepth;
            }
            currDepth++;
            int leftDept = currDepth, rightDept = currDepth;

            if (root.left != null)
            {
                leftDept = DeepestLeavesSum_GetDepth(root.left, leftDept);
            }
            if (root.right != null)
            {
                rightDept = DeepestLeavesSum_GetDepth(root.right, rightDept);
            }
            return Math.Max(leftDept, rightDept);
        }


        /// <summary>
        /// 面试题 08.09. 括号 https://leetcode-cn.com/problems/bracket-lcci/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> res = new List<string>();

            GenerateParenthesis_DFS(n, n, "", ref res);
            return res;
        }
        public static void GenerateParenthesis_DFS(int lRemain, int rRemain, string path, ref IList<string> res)
        {
            if (lRemain == 0 && rRemain == 0)
            {
                res.Add(path);
                return;
            }
            if (lRemain > rRemain)
            {
                return;
            }
            if (lRemain >= 0)
            {
                GenerateParenthesis_DFS(lRemain - 1, rRemain, path + "(", ref res);
            }
            if (0 < rRemain)
            {
                GenerateParenthesis_DFS(lRemain, rRemain - 1, path + ")", ref res);
            }
        }

        /// <summary>
        /// 5800. 基于排列构建数组 https://leetcode-cn.com/problems/build-array-from-permutation/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] BuildArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] += 1000 * (nums[nums[i]] % 1000);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] /= 1000;
            }
            return nums;

            //int[] res = new int[nums.Length] ;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    res[i] = nums[nums[i]];
            //}
            //return res;
        }
        /// <summary>
        ///1828. 统计一个圆中点的数目  https://leetcode-cn.com/problems/queries-on-number-of-points-inside-a-circle/
        /// </summary>
        /// <param name="points"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] res = new int[queries.Length];
            for (int j = 0; j < queries.Length; j++)
            {
                for (int i = 0; i < points.Length; i++)
                {
                    int a = points[i][0], b = points[i][1],
                        x = queries[j][0], y = queries[j][1], z = queries[j][2];
                    if (Math.Sqrt(Math.Pow(Math.Abs(a - x), 2) + Math.Pow(Math.Abs(b - y), 2)) <= z)
                    {
                        res[j]++;
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// 1791. 找出星型图的中心节点 https://leetcode-cn.com/problems/find-center-of-star-graph/
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        public static int FindCenter(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            {
                return edges[0][0];
            }
            else
            {
                return edges[0][1];
            }

            //int n = edges.Length;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < edges.Length; i++)
            //{
            //    for (int j = 0; j < edges[i].Length; j++)
            //    {
            //        if (dic.ContainsKey(edges[i][j]))
            //        {
            //            dic[edges[i][j]]++;
            //        }
            //        else
            //        {
            //            dic.Add(edges[i][j],1);
            //        }
            //    }
            //}
            //int res = -1;
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key]==n)
            //    {
            //        return key;
            //    }
            //}
            //return res;
        }

        /// <summary>
        /// 1909. 删除一个元素使数组严格递增 https://leetcode-cn.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CanBeIncreasing(int[] nums)
        {
            int decreaseCount = 0;
            for (int i = 1; i < nums.Length && decreaseCount < 2; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    decreaseCount++;
                    if (i - 1 > 0 && nums[i] <= nums[i - 2])
                    {
                        nums[i] = nums[i - 1];
                    }
                }
            }
            return decreaseCount < 2;
        }

        /// <summary>
        /// 937. 重新排列日志文件 https://leetcode-cn.com/problems/reorder-data-in-log-files/
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public static string[] ReorderLogFiles(string[] logs)
        {


            Array.Sort(logs, (a, b) =>
            {

                string[] arrA = a.Split(new char[] { ' ' }, 2);
                string[] arrB = b.Split(new char[] { ' ' }, 2);
                bool isADigit = Char.IsDigit(arrA[1][0]),
                isBDigit = Char.IsDigit(arrB[1][0]);
                if (!isADigit && !isBDigit)
                {
                    if (!arrA[1].Equals(arrB[1]))
                    {
                        return arrA[1].CompareTo(arrB[1]);
                    }
                    else
                    {
                        return arrA[0].CompareTo(arrB[0]);
                    }
                }
                else if (isADigit && isBDigit)
                {
                    return 0;
                }
                else if (!isADigit)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });
            return logs;
        }

        /// <summary>
        ///1913. 两个数对之间的最大乘积差 https://leetcode-cn.com/problems/maximum-product-difference-between-two-pairs/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxProductDifference(int[] nums)
        {
            int max1 = -1, max2 = -2, min1 = int.MaxValue, min2 = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max1)
                {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max2 = nums[i];
                }
                if (nums[i] < min1)
                {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (nums[i] < min2)
                {
                    min2 = nums[i];
                }
            }
            return max1 * max2 - min2 * min1;
        }
        /// <summary>
        /// LCS 01. 下载插件 https://leetcode-cn.com/problems/Ju9Xwi/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int LeastMinutes(int n)
        {
            //DP
            int[] dp = new int[n + 1];
            dp[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                dp[i] = dp[(i + 1) / 2] + 1;
            }
            return dp[n];

            //////Greedy Algorithms
            //int bandwidth = 1, increaseTime = 0;
            //while (n>0)
            //{
            //    if (n / bandwidth > 1)
            //    {
            //        bandwidth *= 2;
            //    }
            //    else
            //    {
            //        n -=bandwidth;
            //    }
            //    increaseTime++;
            //}
            //return increaseTime;


            ////Math
            //int bandwidth = 1,increaseTime=0;
            //while (bandwidth<n)
            //{
            //    bandwidth *= 2;
            //    increaseTime++;
            //}
            //return increaseTime + 1;
        }
        /// <summary>
        /// 1560. 圆形赛道上经过次数最多的扇区 https://leetcode-cn.com/problems/most-visited-sector-in-a-circular-track/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="rounds"></param>
        /// <returns></returns>
        public static IList<int> MostVisited(int n, int[] rounds)
        {
            List<int> ret = new List<int>();
            int length = rounds.Length;
            int start = rounds[0], end = rounds[length - 1];
            if (start <= end)
            {
                for (int i = start; i <= end; i++)
                {
                    ret.Add(i);
                }
            }
            else
            {
                for (int i = 1; i <= end; i++)
                {
                    ret.Add(i);
                }
                for (int i = start; i <= n; i++)
                {
                    ret.Add(i);
                }
            }
            return ret;
        }

        /// <summary>
        ///https://leetcode-cn.com/problems/number-of-days-between-two-dates/  1360. 日期之间隔几天
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        /// 
        public static int[] DaysBetweenDates_Months = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 },
            DaysBetweenDates_days = new int[] { 365, 366 };
        public static int DaysBetweenDates(String date1, String date2)
        {


            string[] arr1 = date1.Split('-'),
                      arr2 = date2.Split('-');
            int year1 = int.Parse(arr1[0]), month1 = int.Parse(arr1[1]), day1 = int.Parse(arr1[2]),
                year2 = int.Parse(arr2[0]), month2 = int.Parse(arr2[1]), day2 = int.Parse(arr2[2]);

            int diff1 = DaysBetweenDates_Gap(year1, month1, day1),
                 diff2 = DaysBetweenDates_Gap(year2, month2, day2);

            return Math.Abs(diff1 - diff2);
        }
        public static int DaysBetweenDates_Gap(int year, int month, int day)
        {
            int sum = 0;
            for (int i = 1971; i < year; i++)
            {
                sum += DaysBetweenDates_days[isLeapYear(i)];
            }
            int flag = isLeapYear(year);
            for (int i = 0; i < month; i++)
            {
                if (i == 2)
                {
                    sum += DaysBetweenDates_Months[i] + flag;
                }
                else
                {
                    sum += DaysBetweenDates_Months[i];
                }
            }
            return sum + day;
        }

        public static int isLeapYear(int year)
        {
            return ((year % 100 != 0 && year % 4 == 0) || year % 400 == 0) ? 1 : 0;
        }

        /// <summary>
        ///1033. 移动石子直到连续 https://leetcode-cn.com/problems/moving-stones-until-consecutive/
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int[] NumMovesStones(int a, int b, int c)
        {
            int x = Math.Min(a, Math.Min(b, c)),
                z = Math.Max(a, Math.Max(b, c)),
                y = a + b + c - x - z;
            if (z - y == 1 && y - x == 1)
                return new int[] { 0, 0 };
            if (z - y <= 2 || y - x <= 2)
                return new int[] { 1, z - x - 2 };
            return new int[] { 2, z - x - 2 };

        }

        /// <summary>
        ///LCP 07. 传递信息 https://leetcode-cn.com/problems/chuan-di-xin-xi/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="relation"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int NumWays(int n, int[][] relation, int k)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < relation.Length; i++)
            {
                if (dic.ContainsKey(relation[i][0]))
                {
                    dic[relation[i][0]].Add(relation[i][1]);
                }
                else
                {
                    dic[relation[i][0]] = new List<int>() { relation[i][1] };
                }
            }
            NumWays_DS(n, dic, k, 0, 0);
            return NumWays_Res;

        }
        public static int NumWays_Res = 0;
        public static void NumWays_DS(int n, Dictionary<int, List<int>> dic, int k, int frequency, int currPerson)
        {

            if (frequency == k)
            {
                if (currPerson == n - 1)
                {
                    NumWays_Res++;
                }
                return;
            }
            if (!dic.ContainsKey(currPerson))
            {
                return;
            }
            foreach (var nextPerson in dic[currPerson])
            {
                NumWays_DS(n, dic, k, frequency + 1, nextPerson);
            }
        }

        /// <summary>
        ///剑指 Offer 62. 圆圈中最后剩下的数字  https://leetcode-cn.com/problems/yuan-quan-zhong-zui-hou-sheng-xia-de-shu-zi-lcof/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int LastRemaining(int n, int m)
        {
            List<int> lis = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lis.Add(i + 1);
            }
            while (lis.Count > 1)
            {
                lis.RemoveAt(lis.Count >= m ? m - 1 : lis.Count % m - 1);
            }
            return lis[0];
        }
        /// <summary>
        ///492. 构造矩形 https://leetcode-cn.com/problems/construct-the-rectangle/
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public static int[] ConstructRectangle(int area)
        {
            int w = (int)Math.Sqrt(area), l = 0;
            for (; w > 0; w--)
            {
                l = area / w;
                if (l * w == area)
                {
                    return new int[] { l, area / l };
                }
            }
            return new int[] { l, w };
        }

        /// <summary>
        /// 1275. 找出井字棋的获胜者 https://leetcode-cn.com/problems/find-winner-on-a-tic-tac-toe-game/
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        public static string Tictactoe(int[][] moves)
        {
            int[] count = new int[8];//0-2row 3-5col 6-7diagonal
            int n = moves.Length;
            for (int i = n - 1; i > -1; i -= 2)
            {
                count[moves[i][0]]++;
                count[moves[i][1] + 3]++;
                if (moves[i][0] == moves[i][1])
                    count[6]++;
                if (moves[i][0] + moves[i][1] == 2)
                    count[7]++;

                if (count[moves[i][0]] == 3 || count[moves[i][1] + 3] == 3 || count[6] == 3 || count[7] == 3)
                {
                    return n % 2 == 0 ? "B" : "A";
                }

            }
            return n == 9 ? "Draw" : "Pending";


        }
        /// <summary>
        /// 661. 图片平滑器 https://leetcode-cn.com/problems/image-smoother/
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static int[][] ImageSmoother(int[][] img)
        {
            #region Simulation
            int n = img.Length, m = img[0].Length;
            int[][] res = new int[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new int[m];
            }

            int[] testArrX = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 },
                  testArrY = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int currSum = 0, testX = 0, testY = 0, validCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    currSum = img[i][j];
                    validCount = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        testX = i + testArrX[k];
                        testY = j + testArrY[k];
                        if (testX > -1 && testY > -1 && testX < n && testY < m)
                        {
                            currSum += img[testX][testY];
                            validCount++;
                        }
                    }
                    res[i][j] = currSum / (validCount + 1);
                }
            }
            return res;


            #endregion
        }
        /// <summary>
        /// 1260. 二维网格迁移 https://leetcode-cn.com/problems/shift-2d-grid/
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int n = grid.Length, m = grid[0].Length;
            int[][] resArr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] curr = new int[m];
                for (int j = 0; j < m; j++)
                {
                    curr[j] = 0;
                }
                resArr[i] = curr;
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    resArr[(i + (j + k) / m) % n][(j + k) % m] = grid[i][j];
                }
            }
            return resArr as IList<IList<int>>;




            //int n = grid.Length, m = grid[0].Length;
            //while (k-- > 0)
            //{
            //    int pre = grid[n - 1][m - 1];
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            int temp = grid[i][j];
            //            grid[i][j] = pre;
            //            pre = temp;
            //        }
            //    }
            //}

            //IList<IList<int>> res = new List<IList<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    IList<int> currRow = new List<int>();
            //    for (int j = 0; j < m; j++)
            //    {
            //        currRow.Add(grid[i][j]);
            //    }
            //    res.Add(currRow);
            //}
            //return res;
        }


        /// <summary>
        ///874. 模拟行走机器人  https://leetcode-cn.com/problems/walking-robot-simulation/
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="obstacles"></param>
        /// <returns></returns>
        public static int RobotSim(int[] commands, int[][] obstacles)
        {
            int currDire = 0, currX = 0, currY = 0, res = 0;
            int[] direY = new int[] { 1, 0, -1, 0 },
                  direX = new int[] { 0, 1, 0, -1 };
            HashSet<KeyValuePair<int, int>> set = new HashSet<KeyValuePair<int, int>>();

            for (int i = 0; i < obstacles.Length; i++)
            {
                set.Add(new KeyValuePair<int, int>(obstacles[i][0], obstacles[i][1]));
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] > 0)
                {

                    for (int j = 1; j <= commands[i]; j++)
                    {
                        int nextX = currX + direX[currDire], nextY = currY + direY[currDire];
                        if (set.Contains(new KeyValuePair<int, int>(nextX, nextY)))
                        {
                            break;
                        }
                        currX = nextX;
                        currY = nextY;
                        res = Math.Max(res, currX * currX + currY * currY);
                    }
                }
                else
                {
                    currDire = commands[i] == -1 ? (currDire + 1) % 4 : (currDire + 3) % 4;
                }
            }
            return res;
        }

        /// <summary>
        /// 1903. 字符串中的最大奇数 https://leetcode-cn.com/problems/largest-odd-number-in-string/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string LargestOddNumber(string num)
        {
            string res = "";
            for (int i = num.Length - 1; i > -1; i--)
            {
                int curr = num[i] - '0';
                if (curr % 2 != 0)
                {
                    return num.Substring(0, i + 1);
                }
            }
            return res;
        }

        /// <summary>
        ///1897. 重新分配字符使所有字符串都相等  https://leetcode-cn.com/problems/redistribute-characters-to-make-all-strings-equal/
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static bool MakeEqual(string[] words)
        {
            int[] frequency = new int[26];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    frequency[words[i][j] - 'a']++;
                }
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] % words.Length != 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// LCS 02. 完成一半题目 https://leetcode-cn.com/problems/WqXACV/
        /// </summary>
        /// <param name="questions"></param>
        /// <returns></returns>
        public static int HalfQuestions(int[] questions)
        {
            int[] arr = new int[1001];
            for (int i = 0; i < questions.Length; i++)
            {
                arr[questions[i]]++;
            }
            Array.Sort(arr, (x, y) => { return y.CompareTo(x); });

            int res = 0, sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                res++;
                if (sum >= questions.Length / 2)
                {
                    break;
                }
            }
            return res;
        }

        /// <summary>
        /// 1763. 最长的美好子字符串 https://leetcode-cn.com/problems/longest-nice-substring/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestNiceSubstring(string s)
        {
            int n = s.Length;
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                int up = 0, low = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] >= 'a')
                    {
                        low |= 1 << s[j] - 'a';
                    }
                    else
                    {
                        up |= 1 << s[j] - 'A';
                    }
                    if (up == low && j - i + 1 > res.Length)
                    {
                        res = s.Substring(i, j - i + 1);
                    }
                }
            }
            return res;
        }


        /// <summary>
        ///1893. 检查是否区域内所有整数都被覆盖  https://leetcode-cn.com/problems/check-if-all-the-integers-in-a-range-are-covered/
        /// </summary>
        /// <param name="ranges"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool IsCovered(int[][] ranges, int left, int right)
        {
            int[] diff = new int[52]; ;   // 差分数组
            foreach (int[] range in ranges)
            {
                ++diff[range[0]];
                --diff[range[1] + 1];
            }
            // 前缀和
            int curr = 0;
            for (int i = 1; i <= 50; ++i)
            {
                curr += diff[i];
                if (i >= left && i <= right && curr <= 0)
                {
                    return false;
                }
            }
            return true;
            //int[] arr = new int[51];
            //for (int i = left; i <= right; i++)
            //{
            //    arr[i]++;
            //}

            //for (int i = 0; i < ranges.Length; i++)
            //{
            //    for (int j = ranges[i][0]; j <=ranges[i][1]; j++)
            //    {
            //        if (arr[j] != 0)
            //            arr[j] = 0;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != 0)
            //        return false;
            //}
            //return true;
        }
        /// <summary>
        ///1876. 长度为三且各字符不同的子字符串  https://leetcode-cn.com/problems/substrings-of-size-three-with-distinct-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountGoodSubstrings(string s)
        {
            int res = 0;
            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i] != s[i + 1] && s[i + 1] != s[i + 2] && s[i] != s[i + 2])
                {
                    res++;
                }
            }
            return res;

        }

        /// <summary>
        /// 733. 图像渲染 https://leetcode-cn.com/problems/flood-fill/  
        /// </summary>
        /// <param name="image"></param>
        /// <param name="sr"></param>
        /// <param name="sc"></param>
        /// <param name="newColor"></param>
        /// <returns></returns>
        public static int[][] FloodFill_Image;
        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor)
            {
                return image;
            }
            FloodFill_Image = image;

            DS_FloodFill(sr, sc, newColor, image[sr][sc]);
            return FloodFill_Image;
        }
        public static void DS_FloodFill(int sr, int sc, int newColor, int oriColor)
        {
            if (sr >= FloodFill_Image.Length || sc >= FloodFill_Image[0].Length || sr < 0 || sc < 0 || FloodFill_Image[sr][sc] != oriColor)
            {
                return;
            }
            FloodFill_Image[sr][sc] = newColor;

            DS_FloodFill(sr - 1, sc, newColor, oriColor);
            DS_FloodFill(sr + 1, sc, newColor, oriColor);
            DS_FloodFill(sr, sc - 1, newColor, oriColor);
            DS_FloodFill(sr, sc + 1, newColor, oriColor);
        }

        /// <summary>
        ///1566. 重复至少 K 次且长度为 M 的模式  https://leetcode-cn.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool ContainsPattern(int[] arr, int m, int k)
        {
            int n = arr.Length;
            for (int i = 0; i < n - m * k + 1; i++)
            {
                int j = i + m;
                for (; j < i + m * k; j++)
                {
                    if (arr[j] != arr[j - m])
                        break;
                }
                if (j == i + m * k)
                    return true;
            }
            return false;

            //bool res = false;
            //for (int i = 0; i <= arr.Length-m; i++)
            //{
            //    int j = i;
            //    string curr = "",compare="";
            //    bool isSame = true;
            //    for (; j < arr.Length&&j<i+m; j++)
            //    {
            //        curr += arr[j];
            //    }
            //    int g = j,sameCount=1;

            //    while (g<arr.Length)
            //    {
            //        for (; g < arr.Length && g < j + m; g++)
            //        {
            //            compare += arr[g];
            //        }
            //        j = g;
            //        if (compare!=curr)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            sameCount++;
            //            if (sameCount >= k)
            //            {
            //                return true;
            //            }
            //        }
            //        compare = "";
            //    }
            //    if (sameCount >=k)
            //    {
            //        return true;
            //    }

            //}
            //return res;
        }

        /// <summary>
        /// LCP 28. 采购方案 https://leetcode-cn.com/problems/4xy4Wx/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int PurchasePlans(int[] nums, int target)
        {
            //桶排序+双指针
            long mod = 1000000007, res = 0;

            int[] bucket = new int[100001];
            //Array.Sort(nums);
            for (int g = 0; g < nums.Length; g++)
            {
                bucket[nums[g]]++;
            }
            int i = 0, j = 0;
            while (i < nums.Length)
            {
                while (bucket[j] == 0)
                {
                    j++;
                }
                while (bucket[j] > 0)
                {
                    nums[i++] = j;
                    bucket[j]--;
                }
            }

            i = 0;
            j = nums.Length - 1;
            while (i < j)
            {
                if (nums[i] + nums[j] > target)
                {
                    j--;
                }
                else
                {
                    res += j - i;
                    i++;
                }
            }
            return (int)(res % mod);

            ////二分查找
            //long mod = 1000000007, res = 0;
            //Array.Sort(nums);
            //int diff = 0,j=0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    diff = target - nums[i];
            //    if (diff>=nums[i])
            //    {
            //      j = PurchasePlans_BinarySearch(nums, target - nums[i]);
            //        res = (res + j - i - 1) % mod;
            //    }
            //}
            //return (int)res;

        }

        public static int PurchasePlans_BinarySearch(int[] nums, int tartget)
        {
            int left = 0, right = nums.Length, middle = left + (right - left) / 2;
            while (left < right)
            {
                middle = left + (right - left) / 2;
                if (nums[middle] <= tartget)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }
            return left;
        }

        /// <summary>
        /// 1779. 找到最近的有相同 X 或 Y 坐标的点 https://leetcode-cn.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public static int NearestValidPoint(int x, int y, int[][] points)
        {
            int min = int.MaxValue, minIndex = -1;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    int curr = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if (min > curr)
                    {
                        min = curr;
                        minIndex = i;
                    }
                }

            }
            return minIndex;
        }
        /// <summary>
        /// LCP 22. 黑白方格画  https://leetcode-cn.com/problems/ccw6C7/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public static int PaintingPlan(int n, int k)
        {

            if (k == 0) return 1;
            if (k < n) return 0;
            if (k == n * n) return 1;
            int i; //行
            int j;  //列  
            int res = 0;
            for (i = 0; i < n; i++)
            {
                float x = (k - n * i) / (n - i);
                if (x != (int)x)  //判断x是否为整数
                    continue;
                j = (int)x;
                res += Factorial(n, i) * Factorial(n, j);
            }
            return res;
            //float temp = 0;
            //int res = 0, j = 0;
            ////M*n+N*n-M*N=k;
            //for (int i = 0; i < n; i++)
            //{
            //    temp = (k - n * i) / (n - i);
            //    if ((int)temp == temp)
            //    {
            //        j = (int)temp;
            //        res += Factorial(n, j) * Factorial(n, i);
            //    }
            //}
            //return res;

        }

        /// <summary>
        /// 排列
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Factorial(int n, int m)
        {
            if (m == 0)
                return 1;
            int up = 1, down = 1, t = n - m + 1;
            while (n >= t)
            {
                up *= n--;

            }
            while (m > 0)
            {
                down *= m--;
            }
            return up / down;

            //return sub_Factorial(n) / (sub_Factorial(m) * sub_Factorial(n - m));
        }
        /// <summary>
        /// 阶乘
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int sub_Factorial(int num)
        {
            int res = 1;
            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;

        }
        /// <summary>
        /// 1880. 检查某单词是否等于两单词之和 https://leetcode-cn.com/problems/check-if-word-equals-summation-of-two-words/
        /// </summary>
        /// <param name="firstWord"></param>
        /// <param name="secondWord"></param>
        /// <param name="targetWord"></param>
        /// <returns></returns>
        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            return sub_IsSumEqual(firstWord) + sub_IsSumEqual(secondWord) == sub_IsSumEqual(targetWord);
        }
        public static int sub_IsSumEqual(string Word)
        {
            int final = 0, curr = 0;
            for (int i = 0; i < Word.Length; i++)
            {
                final *= 10;
                final += Word[i] - 'a';
            }
            return final;

        }

        /// <summary>
        ///1629. 按键持续时间最长的键 https://leetcode-cn.com/problems/slowest-key/
        /// </summary>
        /// <param name="releaseTimes"></param>
        /// <param name="keysPressed"></param>
        /// <returns></returns>
        public static char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            int curr = 0, max = releaseTimes[0];
            char res = keysPressed[0];
            for (int i = 1; i < keysPressed.Length; i++)
            {
                curr = releaseTimes[i] - releaseTimes[i - 1];
                if (curr > max)
                {
                    res = keysPressed[i];
                    max = curr;
                }
                else if (curr == max && keysPressed[i] > res)
                {
                    res = keysPressed[i];
                    max = curr;
                }
            }
            return res;

        }
        /// <summary>
        /// 1646. 获取生成数组中的最大值 https://leetcode-cn.com/problems/get-maximum-in-generated-array/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetMaximumGenerated(int n)
        {
            if (n < 2) return n;

            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            int max = 1;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = arr[i / 2];

                }
                else
                {
                    arr[i] = arr[(i - 1) / 2] + arr[(i - 1) / 2 + 1];
                }
                max = Math.Max(max, arr[i]);
            }
            return max;
        }

        /// <summary>
        /// 1037. 有效的回旋镖 https://leetcode-cn.com/problems/valid-boomerang/
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static bool IsBoomerang(int[][] points)
        {
            return (points[1][1] - points[0][1]) * (points[2][0] - points[0][0]) != (points[2][1] - points[0][1]) * (points[1][0] - points[0][0]);
        }

        /// <summary>
        /// 面试题 16.05. 阶乘尾数  https://leetcode-cn.com/problems/factorial-zeros-lcci/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int TrailingZeroes2(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n / 5;
                n = n / 5;
            }
            return count;
        }
        /// <summary>
        /// 1796. 字符串中第二大的数字  https://leetcode-cn.com/problems/second-largest-digit-in-a-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int SecondHighest(string s)
        {
            int max = -1, secondMax = -1, curr = 0;
            for (int i = 0; i < s.Length; i++)
            {
                curr = s[i] - '0';
                if (s[i] <= '9' && s[i] >= '0')
                {
                    if (curr > max)
                    {
                        secondMax = max;
                        max = curr;
                    }
                    else if (curr != max && curr > secondMax)
                    {
                        secondMax = curr;
                    }
                }
            }
            return secondMax;
        }

        /// <summary>
        /// 1441. 用栈操作构建数组 https://leetcode-cn.com/problems/build-an-array-with-stack-operations/
        /// </summary>
        /// <param name="target"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> BuildArray(int[] target, int n)
        {
            List<string> resLis = new List<string>();
            int index = 0, Count = 0;
            for (int i = 1; i <= n && Count < target.Length; i++)
            {

                if (target[index] == i)
                {
                    resLis.Add("Push");
                    index++;
                    Count++;
                }
                else
                {
                    resLis.Add("Push");
                    resLis.Add("Pop");
                }
            }
            return resLis;
        }

        /// <summary>
        /// 1592. 重新排列单词间的空格 https://leetcode-cn.com/problems/rearrange-spaces-between-words/
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReorderSpaces(string text)
        {
            int spaceCount = 0;
            List<string> lisStr = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    string currStr = "";
                    while (i < text.Length && text[i] != ' ')
                    {
                        currStr += text[i++];
                    }
                    lisStr.Add(currStr);
                    i--;
                }
                else
                {
                    spaceCount++;
                }
            }
            int newWidth = lisStr.Count == 1 ? spaceCount : spaceCount / (lisStr.Count - 1);
            string strNewSpace = "";
            while (newWidth > 0)
            {
                strNewSpace += " ";
                newWidth--;
            }
            int endWidth = lisStr.Count == 1 ? spaceCount : spaceCount % (lisStr.Count - 1);
            string strEndSpace = "";
            while (endWidth > 0)
            {
                strEndSpace += " ";
                endWidth--;
            }

            string strRes = "";
            for (int i = 0; i < lisStr.Count - 1; i++)
            {
                strRes += lisStr[i] + strNewSpace;
            }


            strRes += lisStr[lisStr.Count - 1] + strEndSpace;

            return strRes;



        }
        /// <summary>
        /// 495. 提莫攻击 https://leetcode-cn.com/problems/teemo-attacking/
        /// </summary>
        /// <param name="timeSeries"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int last = 0;
            for (int i = 0; i < timeSeries.Length - 1; i++)
            {
                if (timeSeries[i] + duration > timeSeries[i + 1])
                {
                    last += timeSeries[i + 1] - timeSeries[i];
                }
                else
                {
                    last += duration;
                }
            }


            return last + duration;
        }

        /// <summary>
        /// 1051. 高度检查器 https://leetcode-cn.com/problems/height-checker/
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int HeightChecker(int[] heights)
        {
            #region BucketSort
            int count = 0;
            int[] arr = new int[101];
            for (int i = 0; i < heights.Length; i++)
            {
                arr[heights[i]]++;
            }
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    if (i != heights[j])
                    {
                        count++;
                    }
                    j++;
                    arr[i]--;
                }
            }
            return count;

            #endregion

            #region BruteForce
            //int count = 0;
            //int[] newArr =new int[heights.Length];
            //for (int i = 0; i < heights.Length; i++)
            //{
            //    newArr[i] = heights[i];
            //}
            //Array.Sort(newArr,(a,b)=> { return a.CompareTo(b); });
            //for (int i = 0; i < heights.Length; i++)
            //{
            //    count += heights[i] != newArr[i] ? 1 : 0;
            //}
            //return count;
            #endregion
        }
        /// <summary>
        /// 1668. 最大重复子字符串  https://leetcode-cn.com/problems/maximum-repeating-substring/
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static int MaxRepeating(string sequence, string word)
        {
            int count = 0;
            string strNew = word;
            while (sequence.Contains(strNew))
            {
                count++;
                strNew += word;
            }
            return count;
        }

        /// <summary>
        /// 338. 比特位计数 https://leetcode-cn.com/problems/counting-bits/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CountBits(int n)
        {

            #region DP
            int[] res = new int[n + 1];
            res[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    res[i] = res[i / 2];
                }
                else
                {
                    res[i] = res[i - 1] + 1;
                }
            }
            return res;

            #endregion

            #region Force

            //int[] res = new int[n + 1];
            //for (int i = 0; i <= n; i++)
            //{
            //    res[i]= CountBits_Each(i);
            //}
            //return res;
            #endregion
        }
        public static int CountBits_Each(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        /// <summary>
        /// 504. 七进制数 https://leetcode-cn.com/problems/base-7/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ConvertToBase7(int num)
        {
            string res = "";
            bool isNegative = false;
            if (num < 0)
            {
                isNegative = true;
                num = Math.Abs(num);
            }
            while (num > 0)
            {
                res += num % 7;
                num /= 7;
            }
            return new String((isNegative ? (res + "-") : (res)).Reverse().ToArray());
        }

        /// <summary>
        /// 面试题 16.15. 珠玑妙算 https://leetcode-cn.com/problems/master-mind-lcci/
        /// </summary>
        /// <param name="solution"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int[] MasterMind(string solution, string guess)
        {
            int real = 0, fake = 0;
            int[] arr = new int[26];
            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == guess[i])
                {
                    real++;
                }
                else
                {
                    if (arr[solution[i] - 'A'] < 0)
                        fake++;
                    arr[solution[i] - 'A']++;

                    if (arr[guess[i] - 'A'] > 0)
                        fake++;
                    arr[guess[i] - 'A']--;

                }
            }
            return new int[] { real, fake };
        }
        /// <summary>
        /// 717. 1比特与2比特字符 https://leetcode-cn.com/problems/1-bit-and-2-bit-characters/
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static bool IsOneBitCharacter(int[] bits)
        {
            int i = 0;
            for (; i < bits.Length - 1; i++)
            {
                i += bits[i] == 1 ? 1 : 0;
            }
            return i == bits.Length - 1;
        }
        /// <summary>
        /// 1869. 哪种连续子字符串更长 https://leetcode-cn.com/problems/longer-contiguous-segments-of-ones-than-zeros/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckZeroOnes(string s)
        {
            char pre = s[0], curr = '0';
            int maxOne = s[0] == '1' ? 1 : 0, maxZero = s[0] == '0' ? 1 : 0, currLen = 1;
            for (int i = 1; i < s.Length; i++)
            {
                curr = s[i];
                if (curr == pre)
                {
                    currLen++;
                }
                else
                {
                    if (pre == '1')
                    {
                        maxOne = Math.Max(currLen, maxOne);
                    }
                    else
                    {
                        maxZero = Math.Max(currLen, maxZero);
                    }
                    currLen = 1;
                }
                pre = curr;
            }
            if (s[s.Length - 1] == '0')
            {
                maxZero = Math.Max(maxZero, currLen);
            }
            else
            {
                maxOne = Math.Max(maxOne, currLen);
            }
            return maxOne > maxZero;
        }

        /// <summary>
        ///252. 会议室https://leetcode-cn.com/problems/meeting-rooms/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => { return x[0].CompareTo(y[0]); });

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i - 1][1] > intervals[i][0])
                {
                    return false;
                }
            }
            return true;
            #region BruteForce

            //int[] arr = new int[1000001];
            //for (int i = 0; i < intervals.Length; i++)
            //{
            //    for (int j = intervals[i][0]; j < intervals[i][1]; j++)
            //    {
            //        if (arr[j]==1)
            //        {
            //            return false;
            //        }
            //        arr[j]++;
            //    }
            //}
            //return true;

            #endregion
        }

        /// <summary>
        /// 1837. K 进制表示下的各位数字总和 https://leetcode-cn.com/problems/sum-of-digits-in-base-k/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SumBase(int n, int k)
        {
            int res = 0;
            while (n > 0)
            {
                res += n % k;
                n /= k;
            }
            return res;

        }
        /// <summary>
        /// 1859. 将句子排序 https://leetcode-cn.com/problems/sorting-the-sentence/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string SortSentence(string s)
        {
            string[] strArr = s.Split(), sortedArr = new string[10];
            int n = strArr.Length, m = strArr[0].Length;
            string strRes = "";
            for (int i = 0; i < n; i++)
            {
                m = strArr[i].Length;
                sortedArr[strArr[i][m - 1] - '0'] = strArr[i].Substring(0, m - 1);
            }
            for (int i = 0; i < sortedArr.Length; i++)
            {
                strRes += sortedArr[i] + " ";
            }
            return strRes.Trim();
            #region array


            #endregion

            #region dic


            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //foreach (var curr in strArr)
            //{
            //    dic.Add(int.Parse(curr.Substring(curr.Length-1,1)),curr.Substring(0,curr.Length-1));
            //}
            ////dic=dic.OrderBy(i=>i.Key).ToDictionary(x=>x.Key,x=>x.Value);
            ////var sortDic = from curr in dic orderby curr.Key ascending select curr;
            ////dic = sortDic.ToDictionary(x=>x.Key,x=>x.Value);

            ////foreach (var key in dic.Keys)
            ////{
            ////    strRes += dic[key] + " ";
            ////}
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    strRes += dic[i + 1] + " ";
            //}
            //return strRes.TrimEnd();
            #endregion



        }

        /// <summary>
        /// 1854. 人口最多的年份 https://leetcode-cn.com/problems/maximum-population-year/
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public static int MaximumPopulation(int[][] logs)
        {
            ///差分
            int[] d = new int[101];
            for (int i = 0; i < logs.Length; i++)
            {
                d[logs[i][0] - 1950] += 1;
                d[logs[i][1] - 1950] -= 1;
            }
            int curr = 0, resYear = 0, max = 0;
            for (int i = 0; i <= 100; i++)
            {
                curr += d[i];
                if (curr > max)
                {
                    max = curr;
                    resYear = i;
                }
            }
            return resYear + 1950;
            ///双循环暴力
            //int[] yearArr = new int[101];
            //int max = 0, resYear = 2050;
            //for (int i = 0; i < logs.Length; i++)
            //{
            //    for (int j = logs[i][0]-1950; j < logs[i][1]-1950; j++)
            //    {
            //        yearArr[j]++;
            //        if (yearArr[j] > max||(yearArr[j]==max&&resYear>1950+j))
            //        {
            //            max = yearArr[j];
            //            resYear = 1950 + j;
            //        }
            //    }
            //}
            //return resYear;
        }
        /// <summary>
        /// 1228. 等差数列中缺失的数字 https://leetcode-cn.com/problems/missing-number-in-arithmetic-progression/
        /// </summary>
        public static int MissingNumber4(int[] arr)
        {
            #region BinarySearch
            int diff = (arr[arr.Length - 1] - arr[0]) / arr.Length,
                left = 0, right = arr.Length - 1, middle = left + (right - left) / 2;
            while (left < right - 1)
            {
                middle = left + (right - left) / 2;
                if (arr[middle] - arr[left] == diff * (middle - left))
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }
            return (arr[left] + arr[right]) / 2;


            #endregion
            #region Math
            //int currSum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    currSum += arr[i];
            //}
            //return (arr[arr.Length - 1] + arr[0]) * (arr.Length+1) / 2-currSum;

            #endregion

            #region BruteForce


            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int curr = arr[i] - arr[i - 1];
            //    if (!dic.ContainsKey(curr))
            //        dic.Add(curr, 1);
            //    else
            //        dic[curr]++;
            //}
            //int target = 0;
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key] == 1)
            //    {
            //        target = key;
            //        break;
            //    }
            //}
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i]-arr[i-1]==target)
            //    {
            //        return arr[i] - target / 2;
            //    }
            //}
            //return -1;
            #endregion
        }
        /// <summary>
        /// 1331. 数组序号转换 https://leetcode-cn.com/problems/rank-transform-of-an-array/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] ArrayRankTransform(int[] arr)
        {
            //还可以复制一个数组排序后，循环对比二分查找
            int[] temp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            Array.Sort(temp);
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int sameCount = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (!dic.ContainsKey(temp[i]))
                    dic.Add(temp[i], i + 1 - sameCount);
                if (i != 0 && temp[i] == temp[i - 1])
                    sameCount++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = dic[arr[i]];

            }
            return arr;
        }
        /// <summary>
        /// 1118. 一月有多少天  https://leetcode-cn.com/problems/number-of-days-in-a-month/
        /// </summary>
        /// <param name="Y"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int NumberOfDays(int Y, int M)
        {
            if (M == 2)
                return Y % 4 == 0 || Y % 400 == 0 ? 28 : 29;
            else
                switch (M)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        return 31;
                    default:
                        return 30;
                }
        }
        /// <summary>
        /// 1582. 二进制矩阵中的特殊位置  https://leetcode-cn.com/problems/special-positions-in-a-binary-matrix/
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int NumSpecial(int[][] mat)
        {
            int m = mat.Length, n = mat[0].Length;
            int[] rowArr = new int[m], colArr = new int[n];
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        rowArr[i]++;
                        colArr[j]++;
                    }
                }
            }
            int res = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1 && rowArr[i] == 1 && colArr[j] == 1)
                        res++;
                }
            }
            return res;
            int countRow = 0, countCol = 0;
            for (int i = 0; i < rowArr.Length; i++)
            {
                if (rowArr[i] == 1)
                    countRow++;
            }
            for (int i = 0; i < colArr.Length; i++)
            {
                if (colArr[i] == 1)
                    countCol++;
            }
            return countCol * countRow;

        }
        /// <summary>
        /// 1694. 重新格式化电话号码 https://leetcode-cn.com/problems/reformat-phone-number/
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ReformatNumber(string number)
        {
            string temp = "", res = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    temp += number[i];
                }
            }
            int count = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (count % 3 == 0 && count != 0)
                {
                    res += "-";
                }
                res += temp[i];
                count++;
            }
            if ((count - 4) % 3 == 0)
            {
                char[] tempArr = res.ToCharArray();
                char c = tempArr[res.Length - 2];
                tempArr[res.Length - 2] = tempArr[res.Length - 3];
                tempArr[res.Length - 3] = c;
                res = new String(tempArr);
            }
            return res;
        }

        /// <summary>
        /// 1608. 特殊数组的特征值 https://leetcode-cn.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SpecialArray(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length <= nums[0]) return nums.Length;
            int x = nums.Length - 1;
            int i = 1;
            while (x > 0)
            {
                if (x <= nums[i] && x > nums[i - 1])
                {
                    return x;
                }
                else
                {
                    x--;
                    i++;
                }
            }
            return -1;
        }

        /// <summary>
        /// 1652. 拆炸弹 https://leetcode-cn.com/problems/defuse-the-bomb/
        /// </summary>
        /// <param name="code"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] Decrypt(int[] code, int k)
        {
            int n = code.Length;
            int[] res = new int[n];

            if (k > 0)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    int curr = i + 1;
                    while (curr <= i + k)
                    {
                        res[i] += code[curr % n];
                        curr++;
                    }
                }
            }
            else if (k < 0)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    int curr = (n - 1 + i), count = -k;
                    while (curr >= 0 && count > 0)
                    {

                        res[i] += code[curr % n];
                        curr--;
                        count--;

                    }
                }
            }
            return res;

        }

        /// <summary>
        /// 953. 验证外星语词典 https://leetcode-cn.com/problems/verifying-an-alien-dictionary/ 
        /// </summary>
        /// <param name="words"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsAlienSorted(string[] words, string order)
        {
            int[] orderIndex = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                orderIndex[order[i] - 'a'] = i;
            }

            for (int i = 1; i < words.Length; i++)
            {
                int index = 0;
                while (index < words[i].Length && index < words[i - 1].Length)
                {
                    if (orderIndex[words[i][index] - 'a'] > orderIndex[words[i - 1][index] - 'a'])
                    {
                        break;
                    }
                    else if (orderIndex[words[i][index] - 'a'] == orderIndex[words[i - 1][index] - 'a'])
                    {
                        index++;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (index < words[i - 1].Length && index == words[i].Length)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 1422. 分割字符串的最大得分 https://leetcode-cn.com/problems/maximum-score-after-splitting-a-string/ 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxScore(string s)
        {
            int max = 0, left = 0, right = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '1')
                    right++;
            }
            left = s[0] == '0' ? 1 : 0;
            max = left + right;
            for (int i = 2; i < s.Length; i++)
            {
                left += s[i - 1] == '0' ? 1 : 0;
                right -= s[i - 1] == '1' ? 1 : 0;
                max = Math.Max(left + right, max);
            }
            return max;

        }

        /// <summary>
        /// 985. 查询后的偶数和 https://leetcode-cn.com/problems/sum-of-even-numbers-after-queries/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int[] res = new int[A.Length];
            int currOddSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    currOddSum += A[i];

            }
            for (int i = 0; i < queries.Length; i++)
            {
                if (A[queries[i][1]] % 2 == 0)
                {
                    int temp = A[queries[i][1]];
                    A[queries[i][1]] += queries[i][0];
                    if (A[queries[i][1]] % 2 == 0)
                    {
                        currOddSum += queries[i][0];
                    }
                    else
                    {
                        currOddSum -= temp;
                    }
                ;
                }
                else
                {
                    A[queries[i][1]] += queries[i][0];
                    if (A[queries[i][1]] % 2 == 0)
                    {
                        currOddSum += A[queries[i][1]];
                    }
                }
                res[i] = currOddSum;

            }
            return res;
        }
        /// <summary>
        /// 5730. 将所有数字用字符替换 https://leetcode-cn.com/problems/replace-all-digits-with-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReplaceDigits(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] <= '9')
                    sb.Append((char)(s[i - 1] + s[i] - '0'));
                else
                    sb.Append((char)s[i]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 1417. 重新格式化字符串 https://leetcode-cn.com/problems/reformat-the-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reformat(string s)
        {
            int countNum = 0, countChar = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] - '9' <= 0)
                    countNum++;
                else
                    countChar++;
            }
            if (Math.Abs(countChar - countNum) > 1)
                return "";

            char[] arr = new char[countChar + countNum];

            if (countChar > countNum) { countChar = 0; countNum = 1; }
            else { countChar = 1; countNum = 0; }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] - '9' <= 0)
                { arr[countNum] = s[i]; countNum += 2; }
                else
                { arr[countChar] = s[i]; countChar += 2; }
            }
            return new String(arr);

            //List<char> lisNum = new List<char>();
            //List<char> lisChar = new List<char>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]-'9'<=0)
            //    {
            //        lisNum.Add(s[i]);
            //    }
            //    else
            //    {
            //        lisChar.Add(s[i]);
            //    }
            //}
            //if (Math.Abs( lisChar.Count-lisNum.Count)>1)
            //{
            //    return "";
            //}
            //bool charOrNumFirst = lisChar.Count >lisNum.Count ? true : false;
            //StringBuilder sb = new StringBuilder();
            //int index = 0;
            //while (index<lisChar.Count||index<lisNum.Count)
            //{
            //    if (charOrNumFirst)
            //    {
            //        if (index < lisChar.Count)
            //        {
            //            sb.Append(lisChar[index]);
            //        }
            //        if (index < lisNum.Count)
            //        {
            //            sb.Append(lisNum[index]);
            //        }
            //    }
            //    else
            //    {
            //        if (index < lisNum.Count)
            //        {
            //            sb.Append(lisNum[index]);
            //        }
            //        if (index < lisChar.Count)
            //        {
            //            sb.Append(lisChar[index]);
            //        }
            //    }

            //    index++;
            //}
            //return sb.ToString();
        }
        /// <summary>
        /// 507. 完美数 https://leetcode-cn.com/problems/perfect-number/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool CheckPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    if (i * i != num)
                    {
                        sum += num / i;
                    }
                }

            }
            return sum - num == num;
        }
        /// <summary>
        ///5. 最长回文子串  https://leetcode-cn.com/problems/longest-palindromic-substring/ 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestPalindrome2(string s)
        {
            #region SpreadFromCenter
            if (string.IsNullOrEmpty(s))
                return "";

            int left = 0, right = 0, currLen = 1, maxStart = 0, maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                left = i - 1;
                right = i + 1;
                currLen = 1;
                while (left > -1 && s[left] == s[i])
                {
                    currLen++;
                    left--;
                }
                while (right < s.Length && s[right] == s[i])
                {
                    currLen++;
                    right++;
                }
                while (left > -1 && right < s.Length && s[left] == s[right])
                {
                    currLen += 2;
                    left--;
                    right++;
                }
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxStart = left;
                }
            }
            return s.Substring(maxStart + 1, maxLen);

            #endregion

            #region BruteForce
            //int max = 0;
            //string res = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = s.Length-1; j >=i; j--)
            //    {
            //        int l = i, r = j;
            //        bool isSubPalindrome = true;
            //        while (l < r)
            //        {
            //            if (s[l] != s[r])
            //            {
            //                isSubPalindrome = false;
            //                break;
            //            }
            //            r--;
            //            l++;
            //        }
            //        if (isSubPalindrome&&max<j-i+1)
            //        {
            //            max = j-i+1;
            //            res = s.Substring(i,j-i+1);
            //        }
            //    }
            //}
            //return res;
            #endregion
        }

        /// <summary>
        /// 598. 范围求和 II https://leetcode-cn.com/problems/range-addition-ii/
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        public static int MaxCount(int m, int n, int[][] ops)
        {
            for (int i = 0; i < ops.Length; i++)
            {
                m = Math.Min(ops[i][0], m);
                n = Math.Min(ops[i][1], n);
            }
            return m * n;
        }

        /// <summary>
        /// 1496. 判断路径是否相交 https://leetcode-cn.com/problems/path-crossing/
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsPathCrossing(string path)
        {
            HashSet<int> set = new HashSet<int>();
            int x = 0, y = 0;
            set.Add(0);
            for (int i = 0; i < path.Length; i++)
            {
                switch (path[i])
                {
                    case 'S':
                        y++;
                        break;
                    case 'N':
                        y--;
                        break;
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                }
                if (set.Contains(x * 10000 + y))
                {
                    return true;
                }
                set.Add(x * 10000 + y);
            }
            return false;
        }
        /// <summary>
        /// 806. 写字符串需要的行数 https://leetcode-cn.com/problems/number-of-lines-to-write-string/
        /// </summary>
        /// <param name="widths"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int[] NumberOfLines(int[] widths, string s)
        {
            int line = 0, currIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (currIndex + widths[s[i] - 'a'] > 100)
                {
                    line++;
                    currIndex = widths[s[i] - 'a'];
                }
                else
                {
                    currIndex += widths[s[i] - 'a'];
                }

            }
            return new int[] { line + 1, currIndex };
        }

        /// <summary>
        /// 1346. 检查整数及其两倍数是否存在 https://leetcode-cn.com/problems/check-if-n-and-its-double-exist/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool CheckIfExist(int[] arr)
        {
            //// Hash
            //HashSet<int> set = new HashSet<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (set.Contains(arr[i] * 2) || (arr[i] % 2 == 0 && set.Contains(arr[i] / 2)))
            //    {
            //        return true;
            //    }
            //    set.Add(arr[i]);
            //}
            //return false;


            //binarySearch
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    int l = i, r = arr.Length - 1, m = l + (r - l) / 2;
                    while (l < r)
                    {
                        m = l + (r - l) / 2;
                        if (arr[m] == arr[i] * 2 && m != i)
                        {
                            return true;
                        }
                        else if (arr[m] > arr[i] * 2)
                        {
                            r = m - 1;
                        }
                        else
                        {
                            l = m + 1;
                        }
                    }
                }
                else
                {
                    int l = i, r = 0, m = l + (r - l) / 2;
                    while (l >= r)
                    {
                        m = l + (r - l) / 2;
                        if (arr[m] == arr[i] * 2 && m != i)
                        {
                            return true;
                        }
                        else if (arr[m] < arr[i] * 2)
                        {
                            r = m + 1;
                        }
                        else
                        {
                            l = m - 1;
                        }
                    }
                }

            }
            return false;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i!=j&&(arr[i]*2==arr[j]||arr[j]*2==arr[i]))
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
        }
        /// <summary>
        /// 868. 二进制间距 https://leetcode-cn.com/problems/binary-gap/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int BinaryGap(int n)
        {
            int maxLen = 0, currLen = 0, curr = 0, per = 1;
            while (n > 0 && (n & 1) == 0)
            {
                n >>= 1;
            }
            while (n > 0)
            {
                curr = n & 1;
                if (curr == 0)
                {
                    currLen++;
                }
                else
                {
                    maxLen = Math.Max(maxLen, currLen);
                    currLen = 1;
                }

                n >>= 1;
            }
            return maxLen;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/distance-between-bus-stops/ 1184. 公交站间的距离
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int clockWise = 0, counterClockWise = 0, s = Math.Min(start, destination), e = Math.Max(start, destination);
            for (int i = s; i < e; i++)
            {
                clockWise += distance[i];
            }
            for (int i = e; i < distance.Length; i++)
            {
                counterClockWise += distance[i];
            }
            for (int i = 0; i < s; i++)
            {
                counterClockWise += distance[i];
            }
            return Math.Min(counterClockWise, clockWise);
        }



        /// <summary>
        /// 482. 密钥格式化 https://leetcode-cn.com/problems/license-key-formatting/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string LicenseKeyFormatting(string s, int k)
        {
            s = new String(s.Replace("-", "").ToUpper().ToCharArray().Reverse().ToArray());
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 & i % k == 0)
                {
                    res.Append("-");
                }
                res.Append(s[i]);
            }
            string str = res.ToString();
            str = new String(str.ToCharArray().Reverse().ToArray());
            return str;
        }

        /// <summary>
        /// 1185. 一周中的第几天 https://leetcode-cn.com/problems/day-of-the-week/
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string DayOfTheWeek(int day, int month, int year)
        {
            int res = (day + 2 * month + 3 * (month + 1) / 5 + year + year / 4 - year / 100 + year / 400 + 1) % 7;
            string[] strRes = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return strRes[res];
        }

        /// <summary>
        /// 1640. 能否连接形成数组 https://leetcode-cn.com/problems/check-array-formation-through-concatenation/
        /// </summary>
        /// <param name="arr"></param>                                                                  
        /// <param name="pieces"></param>
        /// <returns></returns>
        public static bool CanFormArray(int[] arr, int[][] pieces)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < pieces.Length; i++)
            {
                if (!dic.ContainsKey(pieces[i][0]))
                    dic.Add(pieces[i][0], i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    int curr = arr[i];
                    bool isArr = pieces[dic[curr]].Length > 1;
                    foreach (var p in pieces[dic[curr]])
                    {
                        if (arr[i] == p)
                        {
                            if (isArr)
                            {
                                i++;
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                    i -= isArr ? 1 : 0;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/kth-missing-positive-number/ 1539. 第 k 个缺失的正整数
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindKthPositive(int[] arr, int k)
        {
            int count = 0, index = 0, curr = 1;
            while (count < k && index < arr.Length)
            {
                if (arr[index] != curr)
                {
                    count++;
                }
                else
                {
                    index++;
                }
                curr++;
            }
            curr--;
            while (count < k)
            {
                curr++;
                count++;
            }
            return curr;
        }

        /// <summary>
        /// 1018. 可被 5 整除的二进制前缀 https://leetcode-cn.com/problems/binary-prefix-divisible-by-5/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static IList<bool> PrefixesDivBy5(int[] A)
        {
            long curr = A[0];
            IList<bool> res = new List<bool>();
            res.Add(curr % 5 == 0);
            curr <<= 1;
            for (int i = 1; i < A.Length; i++)
            {
                curr += A[i];
                curr %= 5;
                res.Add(curr % 5 == 0);
                curr <<= 1;
            }
            return res;
        }
        /// <summary>
        /// 1128. 等价多米诺骨牌对的数量  https://leetcode-cn.com/problems/number-of-equivalent-domino-pairs/  
        /// </summary>
        /// <param name="dominoes"></param>
        /// <returns></returns>
        public static int NumEquivDominoPairs(int[][] dominoes)
        {
            if (dominoes.Length < 2)
                return 1;
            int res = 0;
            int[] arr = new int[100];
            for (int i = 0; i < dominoes.Length; i++)
            {
                //Array.Sort(dominoes[i]);
                //res += arr[dominoes[i][0] * 10 + dominoes[i][1]]++;
                res += arr[dominoes[i][0] > dominoes[i][1] ? dominoes[i][1] * 10 + dominoes[i][0] : dominoes[i][0] * 10 + dominoes[i][1]]++;
            }
            return res;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/duplicate-zeros/ 1089. 复写零
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static void DuplicateZeros(int[] arr)
        {
            int i = 0, j = 0;
            while (j < arr.Length)
            {
                if (arr[i] == 0)
                {
                    j++;
                }
                i++;
                j++;
            }
            j--;
            i--;
            while (i > -1)
            {
                if (j < arr.Length)
                    arr[j] = arr[i];
                j--;
                if (arr[i] == 0)
                {
                    arr[j--] = arr[i];
                }
                i--;
            }
        }
        /// <summary>
        /// 1030. 距离顺序排列矩阵单元格  https://leetcode-cn.com/problems/matrix-cells-in-distance-order/
        /// </summary>
        /// <param name="R"></param>
        /// <param name="C"></param>
        /// <param name="r0"></param>
        /// <param name="c0"></param>
        /// <returns></returns>
        public static int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            int[][] res = new int[R * C][];

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    res[C * i + j] = new int[] { i, j };
                }
            }

            Array.Sort(res, (a, b) =>
            {
                return (Math.Abs(a[0] - r0) + Math.Abs(a[1] - c0)) - (Math.Abs(b[0] - r0) + Math.Abs(b[1] - c0));
            });

            return res;
        }

        /// <summary>
        /// 938. 二叉搜索树的范围和 https://leetcode-cn.com/problems/range-sum-of-bst/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static int rangeSumBST2_Sum = 0;
        public static int RangeSumBST2(TreeNode root, int low, int high)
        {
            if (root == null)
                return rangeSumBST2_Sum;
            if (root.val > low)
                RangeSumBST2(root.left, low, high);

            rangeSumBST2_Sum += root.val >= low && root.val <= high ? root.val : 0;

            if (root.val < high)
                RangeSumBST2(root.right, low, high);

            return rangeSumBST2_Sum;
        }
        /// <summary>
        /// 326. 3的幂 https://leetcode-cn.com/problems/power-of-three/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfThree(int n)
        {

            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }

        /// <summary>
        /// 897. 递增顺序搜索树 https://leetcode-cn.com/problems/increasing-order-search-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        ///剪枝
        public static TreeNode increasingBST_Cur = null;
        public static TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode ans = new TreeNode(0);
            increasingBST_Cur = ans;
            IncreasingBST_Inorder(root);
            return ans.right;
        }

        public static void IncreasingBST_Inorder(TreeNode node)
        {
            if (node == null)
                return;

            IncreasingBST_Inorder(node.left);

            node.left = null;
            increasingBST_Cur.right = node;
            increasingBST_Cur = node;

            IncreasingBST_Inorder(node.right);
        }


        //public static TreeNode increasingTreeRes = null;
        //public static TreeNode increasingTreeCurr = null;
        //public static TreeNode IncreasingBST(TreeNode root)
        //{
        //    increasingTreeRes = new TreeNode(-1);
        //    increasingTreeCurr = increasingTreeRes;
        //    DFS_IncreasingBST(root, increasingTreeCurr);
        //    return increasingTreeRes.right;
        //}

        //public static void DFS_IncreasingBST(TreeNode root,TreeNode curr)
        //{
        //    if (root.left!=null)
        //    {
        //        DFS_IncreasingBST(root.left,curr);
        //    }
        //    increasingTreeCurr.right = new TreeNode(root.val);
        //    increasingTreeCurr = increasingTreeCurr.right;
        //    if (root.right != null)
        //    {
        //        DFS_IncreasingBST(root.right,curr);
        //    }
        //}
        /// <summary>
        /// https://leetcode-cn.com/problems/minimum-operations-to-make-the-array-increasing/ 1827. 最少操作使数组递增
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinOperations(int[] nums)
        {
            int operateCount = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    operateCount += nums[i - 1] + 1 - nums[i];
                    nums[i] = nums[i - 1] + 1;
                }
            }
            return operateCount;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/check-if-the-sentence-is-pangram/ 1832. 判断句子是否为全字母句
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static bool CheckIfPangram(string sentence)
        {
            long sum = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                sum |= 1 << (sentence[i] - 'a');
            }
            return sum == (1 << 26) - 1;


            //HashSet<int> set = new HashSet<int>();
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (!set.Contains(sentence[i]))
            //        set.Add(sentence[i]);
            //}
            //return set.Count == 26;



            //int[] arr = new int[26];
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    arr[sentence[i] - 'a']++;
            //}
            //for (int i = 0; i < arr.Length; i++)+
            //{
            //    if (arr[i]==0)
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/hanota-lcci/ 面试题 08.06. 汉诺塔问题
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        public static void Hanota(IList<int> A, IList<int> B, IList<int> C)
        {
            int n = A.Count;
            DFS_Hanota(n, A, B, C);
        }
        public static void DFS_Hanota(int n, IList<int> A, IList<int> B, IList<int> C)
        {
            if (n == 1)
            {
                C.Add(A.Last());
                A.RemoveAt(A.Count - 1);
                return;
            }

            DFS_Hanota(n - 1, A, C, B);    // 将A上面n-1个通过C移到B
            C.Add(A.Last());  // 将A最后一个移到C
            A.RemoveAt(A.Count - 1);          // 这时，A空了
            DFS_Hanota(n - 1, B, A, C);     // 将B上面n-1个通过空的A移到C
        }
        /// <summary>
        /// LCP 02. 分式化简  https://leetcode-cn.com/problems/deep-dark-fraction/
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        public static int[] fraction(int[] cont)
        {
            return DFS_fraction(cont, 0);
        }
        public static int[] DFS_fraction(int[] cont, int index)
        {
            if (index == cont.Length - 1)
            {
                return new int[] { cont[index], 1 };
            }
            int[] ans = DFS_fraction(cont, index + 1);
            return new int[] { cont[index] * ans[0] + ans[1], ans[0] };

        }

        /// <summary>
        /// 811. 子域名访问计数 https://leetcode-cn.com/problems/subdomain-visit-count/
        /// </summary>
        /// <param name="cpdomains"></param>
        /// <returns></returns>
        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            string strCurrDomain = "";
            int currVisits = 0, currIndexOfDot = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
                currVisits = int.Parse(cpdomains[i].Split(' ')[0]);
                strCurrDomain = cpdomains[i].Split(' ')[1];
                currIndexOfDot = 0;

                while (currIndexOfDot > -1)
                {
                    if (!dic.ContainsKey(strCurrDomain))
                    {
                        dic.Add(strCurrDomain, currVisits);
                    }
                    else
                    {
                        dic[strCurrDomain] += currVisits;
                    }
                    currIndexOfDot = strCurrDomain.IndexOf('.');
                    strCurrDomain = strCurrDomain.Substring(currIndexOfDot + 1, strCurrDomain.Length - currIndexOfDot - 1);
                }
            }
            IList<string> res = new List<string>();
            foreach (var key in dic.Keys)
            {
                res.Add(dic[key].ToString() + " " + key);
            }
            return res;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        /// <summary>
        /// 559. N 叉树的最大深度 https://leetcode-cn.com/problems/maximum-depth-of-n-ary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxDepth(Node root)
        {
            if (root == null)
                return 0;
            if (root.children == null || root.children.Count == 0)
                return 1;
            int maxDept = 0;
            foreach (var item in root.children)
            {
                maxDept = Math.Max(maxDept, MaxDepth(item));
            }
            return maxDept + 1;
        }
        ///// <summary>
        ///// 703. 数据流中的第 K 大元素 https://leetcode-cn.com/problems/kth-largest-element-in-a-stream/
        ///// </summary>
        //public class KthLargest
        //{
        //    int kth = 0;
        //    List<int> lis = new List<int>();
        //    public KthLargest(int k, int[] nums)
        //    {
        //        kth = k;
        //        lis = nums.ToList();
        //        lis.Sort();
        //    }

        //    public int Add(int val)
        //    {
        //        int i = 0;
        //        for (; i < lis.Count; i++)
        //        {
        //            if (lis[i]>val)
        //            {

        //                break;
        //            }
        //        }
        //        lis.Insert(i, val);
        //        return lis[lis.Count-kth];
        //    }
        //}
        /// <summary>
        /// https://leetcode-cn.com/problems/er-cha-shu-de-zui-jin-gong-gong-zu-xian-lcof/submissions/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static TreeNode lowestCommonAncestor3(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root;
            TreeNode left = lowestCommonAncestor3(root.left, p, q);
            TreeNode right = lowestCommonAncestor3(root.right, p, q);
            if (left == null) return right;
            if (right == null) return left;
            return root;
        }
        /// <summary>
        /// 剑指 Offer 68 - I. 二叉搜索树的最近公共祖先  https://leetcode-cn.com/problems/er-cha-sou-suo-shu-de-zui-jin-gong-gong-zu-xian-lcof/
        /// </summary>
        /// <param name="S"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static TreeNode lowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode newNode = root;
            while (newNode != null)
            {
                if (newNode.val < p.val && newNode.val < q.val)
                {
                    newNode = newNode.right;
                }
                else if (newNode.val > q.val && newNode.val > p.val)
                {
                    newNode = newNode.left;
                }
                else
                {
                    return newNode;
                }
            }
            return null;
        }
        /// <summary>
        /// 989. 数组形式的整数加法 https://leetcode-cn.com/problems/add-to-array-form-of-integer/
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            int add = 0, sum = 0, index = num.Length - 1;
            IList<int> res = new List<int>();
            while (k > 0 || index > -1)
            {
                int x = k % 10, y = index > -1 ? num[index--] : 0;
                sum = y + x + add;
                res.Add(sum % 10);
                add = (sum - sum % 10) / 10;
                k /= 10;
            }
            if (add != 0) { res.Add(add); }
            return res.Reverse().ToList();
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/rectangle-overlap/ 836. 矩形重叠
        /// </summary>
        /// <param name="rec1"></param>
        /// <param name="rec2"></param>
        /// <returns></returns>
        public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return Math.Min(rec1[2], rec2[2]) > Math.Max(rec1[0], rec2[0]) &&
                 Math.Min(rec1[3], rec2[3]) > Math.Max(rec1[1], rec2[1]);

        }
        /// <summary>
        /// 1822. 数组元素积的符号 https://leetcode-cn.com/problems/sign-of-the-product-of-an-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ArraySign(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum *= nums[i];
            }
            return sum > 0 ? 1 : (sum == 0 ? 0 : -1);
        }
        /// <summary>
        /// 1816. 截断句子 https://leetcode-cn.com/problems/truncate-sentence/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string TruncateSentence(string s, int k)
        {
            int spaceCount = 0, i = 0;
            string res = "";
            s += " ";
            for (; i < s.Length && spaceCount < k; i++)
            {
                if (s[i] == ' ')
                {
                    spaceCount++;
                }
                res += s[i];
            }
            return res.TrimEnd();
        }
        //public class MinStack
        //{
        //    Stack<int> st = null;
        //    int min = int.MaxValue;
        //    public MinStack()
        //    {
        //        st = new Stack<int>();
        //    }

        //    public void Push(int val)
        //    {
        //        if (min>=val)
        //        {
        //            st.Push(min);
        //            min = val;
        //        }
        //        st.Push(val);
        //    }

        //    public void Pop()
        //    {
        //        if (st.Peek()==min)
        //        {
        //           min = st.Pop();
        //        }
        //        st.Pop();
        //    }

        //    public int Top()
        //    {
        //       return  st.Peek();
        //    }

        //    public int GetMin()
        //    {
        //        return min;
        //    }
        //    //Stack<int> st = null, minst = null;
        //    ///** initialize your data structure here. */
        //    //public MinStack()
        //    //{
        //    //    st = new Stack<int>();
        //    //    minst = new Stack<int>();
        //    //}
        //    //public void Push(int x)
        //    //{
        //    //    st.Push(x);
        //    //    if (minst.Count==0)
        //    //    {
        //    //        minst.Push(x);
        //    //    }
        //    //    else
        //    //    {
        //    //        if (minst.Peek()>=x)
        //    //        {
        //    //            minst.Push(x);
        //    //        }
        //    //    }
        //    //}
        //    //public void Pop()
        //    //{
        //    //    if (st.Peek()==minst.Peek())
        //    //    {
        //    //        minst.Pop();
        //    //    }
        //    //    st.Pop();
        //    //}
        //    //public int Top()
        //    //{
        //    //    return st.Peek();
        //    //}
        //    //public int GetMin()
        //    //{
        //    //    return minst.Peek();
        //    //}
        //}

        //public class MyStack
        //{
        //    LinkedList<int> queue = null;
        //    /** Initialize your data structure here. */
        //    public MyStack()
        //    {
        //        queue = new LinkedList<int>();
        //    }

        //    /** Push element x onto stack. */
        //    public void Push(int x)
        //    {
        //        queue.AddLast(x);
        //    }

        //    /** Removes the element on top of the stack and returns that element. */
        //    public int Pop()
        //    {
        //        if (queue.Count > 0)
        //        {
        //            int curr = queue.Last();
        //            queue.RemoveLast();
        //            return curr;
        //        }
        //        else
        //        {
        //            return -1;
        //        }

        //    }

        //    /** Get the top element. */
        //    public int Top()
        //    {
        //        return queue.Last();
        //    }

        //    /** Returns whether the stack is empty. */
        //    public bool Empty()
        //    {
        //        return queue.Count == 0;
        //    }
        //}

        //public static class CQueue
        //{
        //    static Stack st1 = null;
        //    static Stack st2 = null;
        //    public CQueue()
        //    {
        //        st1 = new Stack();
        //        st2 = new Stack();
        //    }

        //    public  void AppendTail(int value)
        //    {
        //        st1.Push(value);
        //    }

        //    public  int DeleteHead()
        //    {
        //        if (st2.Count>0)
        //        {
        //            return (int)st2.Pop();
        //        }
        //        if (st1.Count>0)
        //        {
        //            while (st1.Count>0)
        //            {
        //                st2.Push(st1.Pop());
        //            }
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //        return (int)st2.Pop();
        //    }
        //}
        /// <summary>
        /// https://leetcode-cn.com/problems/longest-word-in-dictionary/ 720. 词典中最长的单词
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string LongestWord(string[] words)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("");
            for (int i = 0; i < words.Length; i++)
            {
                if (!set.Contains(words[i]))
                {
                    set.Add(words[i]);
                }
            }
            int maxLen = 0;
            List<string> maxStrLis = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                string currStr = words[i];
                while (currStr.Length > 0 && set.Contains(currStr.Substring(0, currStr.Length - 1)))
                {
                    currStr = currStr.Substring(0, currStr.Length - 1);
                }
                if (currStr.Length == 0)
                {
                    if (maxLen < words[i].Length)
                    {
                        maxLen = words[i].Length;
                        maxStrLis.Clear();
                        maxStrLis.Add(words[i]);
                    }
                    else if (maxLen == words[i].Length)
                    {
                        maxStrLis.Add(words[i]);
                    }
                }
            }
            maxStrLis.Sort((a, b) =>
            {
                return a.CompareTo(b);
            });
            return maxStrLis.Count > 0 ? maxStrLis[0] : "";
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/check-if-it-is-a-straight-line/ 1232. 缀点成线
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public static bool CheckStraightLine(int[][] coordinates)
        {
            for (int i = 1; i < coordinates.Length - 1; ++i)
            {
                int y1 = coordinates[i][1] - coordinates[i - 1][1];
                int x1 = coordinates[i][0] - coordinates[i - 1][0];
                int y2 = coordinates[i + 1][1] - coordinates[i][1];
                int x2 = coordinates[i + 1][0] - coordinates[i][0];
                if (y1 * x2 != y2 * x1)
                {
                    return false;
                }
            }
            return true;
            //if (coordinates == null || coordinates.Length < 2)
            //    return false;
            //double diffX = (coordinates[1][0] - coordinates[0][0]);
            //double slope = 0;
            //bool isVertical = false;
            //if (diffX!=0)
            //{
            //    slope = diffX == 0 ? 1 : (coordinates[1][1] - coordinates[0][1]) / diffX;
            //}
            //else
            //{
            //    isVertical= true;
            //}

            //for (int i = 1; i < coordinates.Length-1; i++)
            //{
            //    diffX = (coordinates[i + 1][0] - coordinates[i][0]);
            //    if (isVertical)
            //    {
            //        if (diffX != 0)
            //            return false;
            //    }
            //    else
            //    {
            //        if (diffX==0||((double)(coordinates[i + 1][1] - coordinates[i][1]) / (double)(coordinates[i + 1][0] - coordinates[i][0])) != slope)
            //        {
            //            return false;
            //        }
            //    }
            //}
            //return true;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/top-k-frequent-words/ 692. 前K个高频单词
        /// </summary>
        /// <param name="words"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<string> TopKFrequent2(string[] words, int k)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (dic.ContainsKey(words[i]))
                    dic[words[i]]++;
                else
                    dic.Add(words[i], 1);
            }

            var temp = dic.Keys.ToArray();
            Array.Sort(temp, (a, b) =>
            {
                if (dic[a] > dic[b])
                {
                    return -1;
                }
                else if (dic[a] < dic[b])
                {
                    return 1;
                }
                else
                {
                    int len = Math.Min(a.Length, b.Length), index = 0;
                    bool isAsc = false;
                    while (len > index)
                    {
                        if (a[index] > b[index])
                        {
                            isAsc = true;
                            break;
                        }
                        else if (a[index] < b[index])
                        {
                            isAsc = false;
                            break;
                        }
                        else
                        {
                            index++;
                        }

                    }
                    return isAsc ? 1 : -1;
                }
            });

            IList<string> result = new List<string>();
            for (int i = 0; i < k; i++)
            {
                result.Add(temp[i]);
            }
            return result;


        }
        public static IList<string> letterCombinationsLis = new List<string>();
        public static string[] letterCombinationsMap = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        /// <summary>
        /// 17. 电话号码的字母组合  https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static IList<string> LetterCombinations(string digits)
        {
            //DFS
            if (string.IsNullOrEmpty(digits))
                return letterCombinationsLis;

            DFS_LetterCombinations(digits, 0, "");
            return letterCombinationsLis;
            #region BFS


            //IList<string> lis = new List<string>();
            //if (string.IsNullOrEmpty(digits))
            //    return lis;

            //lis.Add("");
            //string[] map = new string[] { "","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
            //LinkedList<string> queue=new LinkedList<string>();

            //int index = 0;
            //while (index<digits.Length)
            //{
            //    string curr =  map[int.Parse(digits[index++].ToString())];
            //    for (int i = 0; i < curr.Length; i++)
            //    {
            //        foreach (var item in lis)
            //        {
            //            queue.AddLast(item+curr[i].ToString());
            //        }

            //    }
            //    lis.Clear();
            //    while (queue.Count > 0)
            //    {
            //        lis.Add(queue.First());
            //        queue.RemoveFirst();
            //    }
            //}
            //return lis;
            #endregion
        }
        public static void DFS_LetterCombinations(string digits, int index, string currStr)
        {
            if (index == digits.Length)
            {
                letterCombinationsLis.Add(currStr);
                return;
            }
            string curr = letterCombinationsMap[int.Parse(digits[index].ToString())];
            for (int i = 0; i < curr.Length; i++)
            {
                DFS_LetterCombinations(digits, index + 1, currStr + curr[i]);
            }
        }
        /// <summary>
        /// 34. 在排序数组中查找元素的第一个和最后一个位置  https://leetcode-cn.com/problems/find-first-and-last-position-of-element-in-sorted-array/ 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1, middle = l + (r - l) / 2;
            while (l <= r)
            {
                middle = l + (r - l) / 2;
                if (nums[middle] == target)
                {
                    int index = middle - 1, left = 0, right = 0;
                    while (index > -1 && nums[index] == target)
                    {
                        index--;
                    }
                    left = index + 1;
                    index = middle + 1;
                    while (index < nums.Length && nums[index] == target)
                    {
                        index++;
                    }
                    right = index - 1;
                    return new int[] { left, right };

                }
                else if (nums[middle] > target)
                {
                    r = middle - 1;
                }
                else
                {
                    l = middle + 1;
                }
            }
            return new int[] { -1, -1 };
        }

        //public class Node
        //{
        //    public int val;
        //    public IList<Node> children;

        //    public Node() { }

        //    public Node(int _val)
        //    {
        //        val = _val;
        //    }

        //    public Node(int _val, IList<Node> _children)
        //    {
        //        val = _val;
        //        children = _children;
        //    }
        //}

        //IList<int> preOrderList = new List<int>();
        ///// <summary>
        ///// https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/ 589. N 叉树的前序遍历
        ///// </summary>
        ///// <param name="root"></param>
        ///// <returns></returns>
        //public IList<int> Preorder(Node root)
        //{
        //   DFSPreOrder(root);
        //    return preOrderList;
        //}
        //public void DFSPreOrder(Node root)
        //{
        //    if (root == null) return;
        //    preOrderList.Add(root.val);

        //    if (root.children!=null)
        //    {
        //        foreach (var child in root.children)
        //        {
        //            DFSPreOrder(child);
        //        }
        //    }
        //}
        /// <summary>
        /// 
        /// 
        /// https://leetcode-cn.com/problems/kth-largest-element-in-an-array/ 215. 数组中的第K个最大元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
        /// <summary>
        /// 506. 相对名次 https://leetcode-cn.com/problems/relative-ranks/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string[] FindRelativeRanks(int[] nums)
        {
            int max = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                max = max < nums[i] ? nums[i] : max;
            }
            int[] arr = new int[max + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]] = i + 1;
            }
            string[] result = new string[nums.Length];
            int index = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    switch (index++)
                    {
                        case 0:
                            result[arr[i] - 1] = "Gold Medal";
                            break;
                        case 1:
                            result[arr[i] - 1] = "Silver Medal";
                            break;
                        case 2:
                            result[arr[i] - 1] = "Bronze Medal";
                            break;
                        default:
                            result[arr[i] - 1] = index.ToString();
                            break;
                    }
                }
            }
            return result;

        }

        /// <summary>
        /// 796. 旋转字符串 https://leetcode-cn.com/problems/rotate-string/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static bool RotateString(string A, string B)
        {
            if (A == B) return true;
            int times = 0;
            while (times < A.Length)
            {
                A = A.Substring(1, A.Length - 1) + A[0].ToString();
                if (A.Equals(B))
                {
                    return true;
                }
                times++;
            }
            return false;
        }
        //class Employee
        //{
        //    public int id;
        //    public int importance;
        //    public IList<int> subordinates;
        //}
        ///// <summary>
        ///// https://leetcode-cn.com/problems/employee-importance/ 690. 员工的重要性
        ///// </summary>
        ///// <param name="employees"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public static int GetImportance(IList<Employee> employees, int id)
        //{
        //    Employee root = null;
        //    foreach (var emp in employees)
        //    {
        //        if (emp.id==id)
        //        {
        //            root = emp;
        //            break;
        //        }
        //    }
        //    int result = root.importance;
        //    foreach (var sub in root.subordinates)
        //    {
        //        result += GetImportance(employees,sub);
        //    }
        //    return result;
        //}
        /// <summary>
        /// https://leetcode-cn.com/problems/n-th-tribonacci-number/ 1137. 第 N 个泰波那契数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n < 3) return 1;
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            int curr = 3;
            while (curr <= n)
            {
                arr[curr] = arr[curr - 1] + arr[curr - 2] + arr[curr - 3];
                curr++;
            }
            return arr[n];
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/largest-number-at-least-twice-of-others/ 747. 至少是其他数字两倍的最大数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int DominantIndex(int[] nums)
        {
            int max = -1, secondmax = -1, index = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] > max)
                {
                    secondmax = max;
                    max = nums[i];
                    index = i;
                }
                else if (nums[i] > secondmax)
                {
                    secondmax = nums[i];
                }
            }
            if (max >= secondmax * 2)
            {
                return index;
            }
            else
            {
                return -1;
            }


            //int max = -1,index=0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]>max)
            //    {
            //        max = nums[i];
            //        index = i;
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]!=max&&nums[i]*2>max)
            //    {
            //        return -1;
            //    }
            //}
            //return index;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/number-of-longest-increasing-subsequence/ 673. 最长递增子序列的个数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindNumberOfLIS(int[] nums)
        {
            if (nums.Length == 1)
                return 1;

            int[] dp = new int[nums.Length], count = new int[nums.Length];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = count[i] = 1;
            }
            int maxlen = 0;
            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                            count[i] = count[j];
                        }
                        else if (dp[j] + 1 == dp[i])
                        {
                            count[i] += count[j];
                        }
                    }
                }
                maxlen = Math.Max(maxlen, dp[i]);
            }
            int result = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                if (dp[i] == maxlen)
                {
                    result += count[i];
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/longest-continuous-increasing-subsequence/ 674. 最长连续递增序列
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int max = 1, curr = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    curr += 1;
                    max = Math.Max(curr, max);
                }
                else
                {
                    curr = 1;
                }
            }
            return max;

        }
        /// <summary>
        /// 264. 丑数 II https://leetcode-cn.com/problems/ugly-number-ii/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NthUglyNumber2(int n)
        {

            int l2 = 0, l3 = 0, l5 = 0, min = 0;
            int[] dp = new int[n];
            dp[0] = 1;
            for (int i = 1; i < dp.Length; i++)
            {
                min = Math.Min(Math.Min(dp[l2] * 2, dp[l3] * 3), dp[l5] * 5);
                dp[i] = min;
                if (min == dp[l2] * 2)
                    l2++;
                if (min == dp[l3] * 3)
                    l3++;
                if (min == dp[l5] * 5)
                    l5++;
            }
            return dp[n - 1];

            //int count = 1,curr=2;
            //while (count<n)
            //{
            //    if (IsUgly(curr))
            //    {
            //        count++;
            //    }
            //    curr++;
            //}
            //return curr-1;
        }

        /// <summary>
        /// 263. 丑数 https://leetcode-cn.com/problems/ugly-number/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsUgly(int n)
        {
            while (n % 2 == 0)
            {
                n /= 2;
            }
            while (n % 5 == 0)
            {
                n /= 5;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/count-primes/ 204. 计数质数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountPrimes(int n)
        {
            bool[] arr = new bool[n + 1];
            int result = 0;
            for (int i = 2; i < n; i++)
            {
                if (!arr[i])
                {
                    result++;
                    for (int j = i + i; j < n; j += i)
                    {
                        arr[j] = true;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/greatest-common-divisor-of-strings/ 1071. 字符串的最大公因子
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string GcdOfStrings(string str1, string str2)
        {
            if ((str1 + str2) != (str2 + str1))
                return "";

            // 辗转相除法求gcd。
            return str1.Substring(0, gcd(str1.Length, str2.Length));

            ////枚举法
            //for (int i = Math.Min(str1.Length,str2.Length); i >0; i--)
            //{
            //    if ((str1.Length%i==0)&&(str2.Length%i==0))
            //    {
            //        string curr = str1.Substring(0,i);
            //        if (CheckGcdOfStrings(curr,str1)&&CheckGcdOfStrings(curr,str2))
            //        {
            //            return curr;
            //        }
            //    }
            //}
            //return "";
        }
        private static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
        public static bool CheckGcdOfStrings(string x, string str)
        {
            int times = str.Length / x.Length;
            string strAppend = "";
            for (int i = 0; i < times; i++)
            {
                strAppend += x;
            }
            return strAppend == str;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/shun-shi-zhen-da-yin-ju-zhen-lcof/ 剑指 Offer 29. 顺时针打印矩阵   https://leetcode-cn.com/problems/spiral-matrix/  54. 螺旋矩阵
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[] SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return new int[0] { };
            int down = matrix.Length, right = matrix[0].Length, left = -1, up = -1, index = 0, i = 0, j = 0;
            int[] result = new int[down * right];
            while (index < result.Length)
            {

                while (index < result.Length && j < right)
                {
                    result[index++] = matrix[i][j++];
                }
                j--;
                i++;
                up++;

                while (index < result.Length && i < down)
                {
                    result[index++] = matrix[i++][j];
                }
                i--;
                j--;
                right--;

                while (index < result.Length && j > left)
                {
                    result[index++] = matrix[i][j--];
                }
                j++;
                i--;
                down--;

                while (index < result.Length && i > up)
                {
                    result[index++] = matrix[i--][j];
                }
                i++;
                j++;
                left++;
            }
            return result;
        }
        /// <summary>
        /// 19. 删除链表的倒数第 N 个结点 https://leetcode-cn.com/problems/remove-nth-node-from-end-of-list/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode pre = new ListNode(-1), slow = pre, fast = pre;
            pre.next = head;
            while (n > 0)
            {
                fast = fast.next;
                n--;
            }
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return pre.next;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/add-two-numbers/ 2. 两数相加
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode result = new ListNode(-1), curr = result;
            int preAdd = 0, temp = 0;
            while (l1 != null || l2 != null || preAdd != 0)
            {
                temp = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + preAdd;
                ListNode tempNode = new ListNode(temp % 10);
                curr.next = tempNode;
                curr = curr.next;
                preAdd = temp / 10 > 0 ? temp / 10 : 0;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }
            return result.next;

            ///位数限制，错误
            //long num1 = 0, num2 = 0, count1 = 0,count2=0;
            //while (l1!=null)
            //{
            //    num1 += long.Parse((l1.val * Math.Pow(10,count1++)).ToString());
            //    l1 = l1.next;
            //}
            //while (l2 != null)
            //{
            //    num2 += long.Parse((l2.val * Math.Pow(10, count2++)).ToString());
            //    l2 = l2.next;
            //}
            //long total = num1 + num2;

            //if (total == 0)
            //    return new ListNode(0);


            //ListNode result = new ListNode(-1),curr=result;
            //result.next = curr;
            //while (total>0)
            //{
            //     ListNode temp = new ListNode(int.Parse((total % 10).ToString()));
            //    curr.next = temp;
            //    curr = curr.next;
            //    total /= 10;
            //}
            //return result.next;

        }

        /// <summary>
        /// 面试题 16.01. 交换数字 https://leetcode-cn.com/problems/swap-numbers-lcci/
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] SwapNumbers(int[] numbers)
        {
            numbers[0] ^= numbers[1];
            numbers[1] ^= numbers[0];
            numbers[0] ^= numbers[1];
            return numbers;
            //return new int[] { numbers[1],numbers[0]};
        }
        /// <summary>
        /// 反转链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseListNode(ListNode head)
        {
            ListNode pre = null, curr = head;
            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = pre;
                pre = curr;
                curr = temp;
            }
            return pre;

        }
        /// <summary>
        /// /https://leetcode-cn.com/problems/palindrome-linked-list-lcci/ 面试题 02.06. 回文链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsPalindrome4(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            //判断链表长度是否是奇数
            if (fast != null)
            {
                slow = slow.next;
            }
            //翻转
            slow = ReverseListNode(slow);

            fast = head;
            while (slow != null)
            {
                if (slow.val != fast.val)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next;
            }
            return true;


            //List<int> lis = new List<int>();
            //while (head!=null)
            //{
            //    lis.Add(head.val);
            //    head = head.next;
            //}
            //int l = 0, r = lis.Count - 1;
            //while (l<=r)
            //{
            //    if (lis[l]!=lis[r])
            //    {
            //        return false;
            //    }
            //    l++;
            //    r--;
            //}
            //return true;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/determine-color-of-a-chessboard-square/ 1812. 判断国际象棋棋盘中一个格子的颜色
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public static bool SquareIsWhite(string coordinates)
        {
            return (coordinates[0] - 'a') % 2 == 1 ? (coordinates[1] - '1') % 2 == 0
           : (coordinates[1] - '1') % 2 == 1;

        }
        /// <summary>
        ///https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list-ii/ 82. 删除排序链表中的重复元素II
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode DeleteDuplicates2(ListNode head)
        {
            ListNode newHead = new ListNode(-1);
            newHead.next = head;
            ListNode pre = newHead, cur = newHead.next;
            while (cur != null && cur.next != null)
            {
                if (cur.next.val == pre.next.val)
                {
                    while (cur.next != null && cur.next.val == pre.next.val)
                    {
                        cur = cur.next;
                    }
                    pre.next = cur.next;
                    cur = cur.next;
                }
                else
                {
                    pre = pre.next;
                    cur = cur.next;
                }
            }
            return newHead.next;


            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //ListNode curr = head;
            //while (curr != null)
            //{
            //    if (dic.ContainsKey(curr.val))
            //    {
            //        dic[curr.val]++;
            //    }
            //    else
            //    {
            //        dic.Add(curr.val,1);
            //    }
            //    curr = curr.next;
            //}

            //ListNode newHead = new ListNode(-1);
            //newHead.next = head;
            //ListNode pre = newHead, cur = newHead.next;
            //while (cur != null)
            //{
            //    if (dic[cur.val]>1)
            //    {
            //        pre.next = cur.next;
            //        cur = cur.next;
            //    }
            //    else
            //    {
            //        pre = pre.next;
            //        cur = cur.next;
            //    }
            //}
            //return newHead.next;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/  83. 删除排序链表中的重复元素
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode DeleteDuplicates(ListNode head)
        {
            HashSet<int> set = new HashSet<int>();
            ListNode newHead = new ListNode(-1);
            newHead.next = head;
            ListNode pre = newHead, curr = newHead.next;
            while (curr != null)
            {
                if (!set.Contains(curr.val))
                    set.Add(curr.val);
                else
                {
                    pre.next = curr.next;
                    curr = curr.next;
                    continue;
                }
                if (curr != null)
                {
                    curr = curr.next;
                }
                pre = pre.next;
            }
            return newHead.next;
        }
        /// <summary> 
        /// 剑指 Offer 18. 删除链表的节点 https://leetcode-cn.com/problems/shan-chu-lian-biao-de-jie-dian-lcof/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ListNode DeleteNode(ListNode head, int val)
        {

            ListNode newHead = new ListNode(-1);
            newHead.next = head;
            ListNode pre = newHead, curr = newHead.next;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    pre.next = curr.next;
                    return newHead.next;
                }
                pre = pre.next;
                curr = curr.next;
            }
            return newHead.next;

            //ListNode pre = head, curr = head.next;
            //if (head != null && head.val == val)
            //{
            //    return head.next;
            //}
            //while (curr!=null)
            //{
            //    if (curr.val==val)
            //    {
            //        pre.next = curr.next;
            //        return head;
            //    }
            //    pre = pre.next;
            //    curr = curr.next;
            //}
            //return head;
        }

        /// <summary>
        /// 剑指 Offer 52. 两个链表的第一个公共节点   https://leetcode-cn.com/problems/liang-ge-lian-biao-de-di-yi-ge-gong-gong-jie-dian-lcof/
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode curr1 = headA, curr2 = headB;

            while (curr1 != curr2)
            {
                curr1 = curr1 == null ? headB : curr1.next;
                curr2 = curr2 == null ? headA : curr2.next;
            }
            return curr1;


        }
        /// <summary>
        /// https://leetcode-cn.com/problems/queue-reconstruction-by-height/ 406. 根据身高重建队列
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public static int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, (a, b) =>
            {
                if (a[0] > b[0])
                {
                    return -1;
                }
                else if (a[0] == b[0])
                {
                    if (a[1] > b[1])
                    {
                        return 1;
                    }
                    else if (a[1] == b[1])
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }

                }
                else
                {
                    return 1;
                }

            });

            List<int[]> list = new List<int[]>();
            for (int i = 0; i < people.Length; i++)
            {
                list.Insert(people[i][1], people[i]);
            }
            return list.ToArray();
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/most-common-word/ 819. 最常见的单词
        /// </summary>
        /// <param name="paragraph"></param>
        /// <param name="banned"></param>
        /// <returns></returns>
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string[] arr = paragraph.Replace(",", " ").Replace(".", " ").Replace(":", " ").Replace(";", " ").Replace("'", " ").Replace("!", " ").Replace("?", " ").Replace("!", " ").Replace("  ", " ").Split(' ');
            int max = -1;//!?',;.
            string word = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim(',').Trim('.').ToLower();
                bool isBanned = false;
                for (int j = 0; j < banned.Length; j++)
                {
                    if (banned[j] == arr[i])
                    {
                        isBanned = true;
                        break;
                    }
                }
                if (isBanned)
                {
                    continue;
                }
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                    if (max < dic[arr[i]])
                    {
                        max = dic[arr[i]];
                        word = arr[i];
                    }
                }
                else
                {
                    dic.Add(arr[i], 1);
                    if (max < dic[arr[i]])
                    {
                        max = dic[arr[i]];
                        word = arr[i];

                    }
                }
            }
            return word;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/x-of-a-kind-in-a-deck-of-cards/ 914. 卡牌分组
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public static bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < deck.Length; i++)
            {
                if (set.ContainsKey(deck[i]))
                {
                    set[deck[i]]++;
                }
                else
                {
                    set.Add(deck[i], 1);
                }
            }
            int count = -1, num = -1;
            foreach (var key in set.Keys)
            {
                if (set[key] == 1)
                {
                    return false;
                }
                else
                {
                    if (count == -1)
                    {
                        num = set[key];
                        count++;
                    }
                    else
                    {
                        num = GCD(num, set[key]);
                    }
                }
            }
            return num > 1;
        }
        /// <summary>
        /// 求最大公约数 辗转相除法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/ 1576. 替换所有的问号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ModifyString(string s)
        {
            string words = "abcdefghijklmnopqrstuvwxyz";
            char[] arr = ("0" + s + "0").ToArray();
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == '?')
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (!(words[j] == arr[i + 1] || words[j] - 'a' == arr[i + 1] - 'a' - 1 || words[j] - 'a' == arr[i - 1] - 'a' + 1 || words[j] == arr[i - 1]))
                        {
                            arr[i] = words[j];
                            break;
                        }
                    }
                }
            }
            return new String(arr, 1, arr.Length - 2);
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/buddy-strings/ 859. 亲密字符串
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool BuddyStrings(string a, string b)
        {
            if (a.Length != b.Length)
                return false;
            if (a.Equals(b))
            {
                int[] words = new int[26];
                for (int i = 0; i < a.Length; i++)
                {
                    words[a[i] - 'a']++;
                    if (words[a[i] - 'a'] > 1)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {


                char diff1 = '0', diff2 = '0';
                int index1 = 0, index2 = a.Length - 1;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        if (diff1 == '0')
                        {
                            diff1 = a[i];
                            diff2 = b[i];
                            index1 = i;
                        }
                        else
                        {
                            if (b[i] != diff1 || a[i] != diff2)
                            {
                                return false;
                            }
                            index2 = i;
                        }
                    }
                }
                char[] arrA = a.ToArray(), arrB = b.ToArray();
                char temp = arrA[index1];
                arrA[index1] = arrA[index2];
                arrA[index2] = temp;
                return new String(arrA).Equals(b);
            }


        }
        /// <summary>
        /// https://leetcode-cn.com/problems/check-if-all-1s-are-at-least-length-k-places-away/ 1437. 是否所有 1 都至少相隔 k 个元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool KLengthApart(int[] nums, int k)
        {
            int pre = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (pre != -1 && i - pre - 1 < k)
                    {
                        return false;
                    }
                    pre = i;
                }
            }
            return true;
            //int distance = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]==1)
            //    {
            //        if (distance<k)
            //        {
            //            return false;
            //        }
            //        distance = 0;
            //    }
            //    else
            //    {
            //        distance++;
            //    }
            //}
            //return true;
        }
        /// <summary>
        /// 645. 错误的集合 https://leetcode-cn.com/problems/set-mismatch/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] FindErrorNums(int[] nums)
        {
            int repeat = 0, missing = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                {
                    repeat = Math.Abs(nums[i]);
                }
                else
                {
                    nums[Math.Abs(nums[i]) - 1] *= -1;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    missing = i + 1;
                }
            }
            return new int[] { repeat, missing };


            //int[] mp=new int[nums.Length];
            //int repeat = 0, missing = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    mp[nums[i]-1 ]++;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (mp[i] == 2)
            //    {
            //        repeat = i + 1;
            //    }
            //    else if (mp[i]==0)
            //    {
            //        missing = i + 1;
            //    }
            //}
            //return new int[] { repeat, missing };



            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //int repeat=0,missing=0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!dic.ContainsKey(nums[i]))
            //    {
            //        dic.Add(nums[i],1);
            //    }
            //    else
            //    {
            //        dic[nums[i]]++;
            //    }
            //}
            //for (int i = 1; i <=nums.Length; i++)
            //{
            //    if (dic.ContainsKey(i))
            //    {
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/fair-candy-swap/ 888. 公平的糖果棒交换
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] FairCandySwap(int[] A, int[] B)
        {
            int sumA = 0, sumB = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
                set.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                sumB += B[i];
            }
            int diff = (sumA - sumB) / 2;
            for (int i = 0; i < B.Length; i++)
            {
                if (set.Contains(B[i] + diff))
                {
                    return new int[] { B[i] + diff, B[i] };
                }
            }
            return new int[] { };
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/ 1784. 检查二进制字符串字段
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckOnesSegment(string s)
        {
            if (s.Length == 1)
                return true;
            bool isContinuty = true;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    isContinuty = false;
                }
                else
                {
                    if (!isContinuty)
                    {
                        return false;
                    }
                }

            }

            return true;

        }

        /// <summary>
        /// 807. 保持城市天际线 https://leetcode-cn.com/problems/max-increase-to-keep-city-skyline/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int m = grid.Length, addCount = 0;
            int[] maxInRow = new int[m], maxInCol = new int[m];

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    maxInRow[r] = Math.Max(maxInRow[r], grid[r][c]);
                    maxInCol[c] = Math.Max(maxInCol[c], grid[r][c]);
                }
            }
            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    addCount += Math.Min(maxInRow[r], maxInCol[c]) - grid[r][c];
                }
            }

            //for (int i = 0; i <m; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (maxInRow[i] < grid[i][j])
            //        {
            //            maxInRow[i] = grid[i][j];
            //        }
            //    }
            //}
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (maxInCol[i]<grid[j][i])
            //        {
            //            maxInCol[i] = grid[j][i];
            //        }
            //    }
            //}

            //        for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        addCount += Math.Min(maxInRow[i], maxInCol[j]) - grid[i][j];
            //    }
            //}


            return addCount;
        }



        /// <summary>
        /// https://leetcode-cn.com/problems/largest-unique-number/  1133. 最大唯一数
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int LargestUniqueNumber(int[] A)
        {
            int max = -1, times = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                {
                    dic.Add(A[i], 1);
                }
                else
                {
                    dic[A[i]]++;
                }
            }
            foreach (var key in dic.Keys)
            {
                if (dic[key] == 1)
                {
                    max = key > max ? key : max;
                }
            }
            return max;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/number-of-different-integers-in-a-string/ 1805. 字符串中不同整数的数目
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int NumDifferentIntegers(string word)
        {
            string curr = "";
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] - '9' <= 0)
                {
                    while (i < word.Length && word[i] - '0' == 0)
                    {
                        i++;
                    }
                    while (i < word.Length && word[i] - '9' <= 0)
                    {
                        curr += word[i++];
                    }

                    if (!set.Contains(curr))
                    {
                        set.Add(curr);
                    }
                    curr = "";
                }

            }
            return set.Count;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/degree-of-an-array/ 697. 数组的度
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int[]> dic = new Dictionary<int, int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], new int[] { 1, i, i });
                }
                else
                {
                    dic[nums[i]][0]++;
                    dic[nums[i]][2] = i;
                }
            }

            int minLen = 0, maxNum = 0;
            foreach (var key in dic.Keys)
            {
                if (dic[key][0] > maxNum)
                {
                    maxNum = dic[key][0];
                    minLen = dic[key][2] - dic[key][1] + 1;
                }
                else if (dic[key][0] == maxNum)
                {
                    if (minLen > dic[key][2] - dic[key][1] + 1)
                    {
                        minLen = dic[key][2] - dic[key][1] + 1;
                    }
                }
            }
            return minLen;

            //List<int> maxList = new List<int>();
            //int max = 0;
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key][0]>=max)
            //    {
            //        max = dic[key][0];
            //    }
            //}
            //int min = int.MaxValue;
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key][0]==max)
            //    {
            //        min = Math.Min(min,dic[key][2]-dic[key][1]+1);
            //    }
            //}
            //return min;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/reshape-the-matrix/ 566. 重塑矩阵
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            int m = nums.Length, n = nums[0].Length;
            if (m * n != r * c)
                return nums;

            int[][] result = new int[r][];
            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }
            for (int i = 0; i < r * c; i++)
            {
                result[i / c][i % c] = nums[i / n][i % n];
            }
            return result;


            //if (nums.Length * nums[0].Length < r * c) return nums;

            //int[] tempArr = new int[nums.Length*nums[0].Length];
            //int index = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums[i].Length; j++)
            //    {
            //        tempArr[index++] = nums[i][j];
            //    }
            //}

            //index = 0;
            //int[][] result = new int[r][];
            //for (int i = 0; i < r; i++)
            //{
            //    int[] temp = new int[c];
            //    for (int j = 0; j < c; j++)
            //    {
            //         temp[j]= tempArr[index++];
            //    }
            //    result[i] = temp;

            //}
            //return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/ransom-note/ 383. 赎金信
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            int[] mag = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                mag[magazine[i] - 'a']++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (mag[ransomNote[i] - 'a'] == 0)
                {
                    return false;
                }
                mag[ransomNote[i] - 'a']--;
            }
            return true;
        }

        /// <summary>
        ///https://leetcode-cn.com/problems/repeated-substring-pattern/ 459. 重复的子字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool RepeatedSubstringPattern(string s)
        {
            return false;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/factorial-trailing-zeroes/ 172. 阶乘后的零
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int TrailingZeroes(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n / 5;
                n = n / 5;
            }
            return count;
        }
        /// <summary>
        /// 896. 单调数列 https://leetcode-cn.com/problems/monotonic-array/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool IsMonotonic(int[] A)
        {
            bool isAsc = true, isDesc = true;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < A[i + 1])
                {
                    isAsc = false;
                }
                else if (A[i] > A[i + 1])
                {
                    isDesc = false;
                }
            }
            return isAsc || isDesc;

            //if (A.Length == 1)
            //    return true;

            //bool isAsc = true;
            //int index = 1;
            //while (A[index]==A[index-1])
            //{
            //    index++;
            //}
            //isAsc = A[index - 1] < A[index];
            //if (isAsc)
            //{
            //    for (int i = 1; i < A.Length; i++)
            //    {
            //        if (A[i] < A[i - 1])
            //        {
            //            return false;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i < A.Length; i++)
            //    {
            //        if (A[i] > A[i - 1])
            //        {
            //            return false;
            //        }
            //    }
            //}
            //return true;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/isomorphic-strings/ 205. 同构字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsIsomorphic(string s, string t)
        {



            if (s.Length != t.Length)
                return false;

            int[] mp1 = new int[128];
            int[] mp2 = new int[128];
            for (int i = 0; i < s.Length; i++)
            {
                if (mp1[s[i]] != mp2[t[i]])
                {
                    return false;
                }
                else if (mp1[s[i]] == 0)
                {
                    mp1[s[i]] = i + 1;
                    mp2[t[i]] = i + 1;

                }
            }
            return true;


            //return IsIsomorphicHelper(s).Equals( IsIsomorphicHelper(t));

            //Dictionary<char, char> dic12 = new Dictionary<char, char>();
            //Dictionary<char, char> dic21 = new Dictionary<char, char>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!dic12.ContainsKey(s[i])&&!dic21.ContainsKey(t[i]))
            //    {
            //        dic12.Add(s[i],t[i]);
            //        dic21.Add(t[i], s[i]);
            //    }
            //    else
            //    {
            //        if (!(dic12.ContainsKey(s[i])&&dic12[s[i]]==t[i]&&dic21.ContainsKey(t[i]) && dic21[t[i]] == s[i]))
            //        {
            //            return false;
            //        }
            //    }
            //}
            //return true;
        }
        public static string IsIsomorphicHelper(string s)
        {
            int[] map = new int[128];
            int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 0)
                {
                    map[s[i]] = count;
                    count++;
                }
                sb.Append(map[s[i]]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-product-of-three-numbers/ 628. 三个数的最大乘积
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaximumProduct(int[] nums)
        {
            ////排序
            //Array.Sort(nums);
            //return Math.Max(nums[0]*nums[1]*nums[nums.Length-1],nums[nums.Length-1]* nums[nums.Length - 2] * nums[nums.Length - 3] );

            ////不排序

            int max1 = -1001, max2 = -1001, max3 = -1001,
                min1 = 1001, min2 = 1001;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max3)
                {
                    max1 = max2;
                    max2 = max3;
                    max3 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max1 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] > max1)
                {
                    max1 = nums[i];
                }
                if (nums[i] < min1)
                {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (nums[i] < min2)
                {
                    min2 = nums[i];
                }
            }
            return Math.Max(min2 * min1 * max3, max1 * max2 * max3);
        }
        /// <summary>
        /// 剑指 Offer 10- II. 青蛙跳台阶问题 https://leetcode-cn.com/problems/qing-wa-tiao-tai-jie-wen-ti-lcof/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NumWays(int n)
        {
            if (n == 0 || n == 1) return 1;

            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;
            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 2] % 1000000007 + dp[i - 1] % 1000000007;
            }

            return dp[n - 1];
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/remove-linked-list-elements/ 203. 移除链表元素
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode sentinel = new ListNode(0);
            sentinel.next = head;

            ListNode prev = sentinel, curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                    prev.next = curr.next;
                else
                    prev = curr;
                curr = curr.next;
            }
            return sentinel.next;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/relative-sort-array/ 1122. 数组的相对排序
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dic.ContainsKey(arr1[i]))
                {
                    dic.Add(arr1[i], 1);
                }
                else
                {
                    dic[arr1[i]]++;
                }
            }
            Array.Sort(arr1);
            int[] res = new int[arr1.Length];
            int index = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                while (dic[arr2[i]] > 0)
                {
                    res[index++] = arr2[i];
                    dic[arr2[i]]--;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                while (dic[arr1[i]] > 0)
                {
                    res[index++] = arr1[i];
                    dic[arr1[i]]--;
                }
            }
            return res;


        }

        /// <summary>
        /// https://leetcode-cn.com/problems/projection-area-of-3d-shapes/ 883. 三维形体投影面积
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int ProjectionArea(int[][] grid)
        {
            int maxRow = 0, maxCol = 0, res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] > 0)
                        res++;
                    maxRow = Math.Max(maxRow, grid[i][j]);
                    maxCol = Math.Max(maxCol, grid[j][i]);
                }
                res += maxRow + maxCol;
            }
            return res;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/n-repeated-element-in-size-2n-array/submissions/ 961. 重复 N 次的元素
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int RepeatedNTimes(int[] A)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                {
                    dic.Add(A[i], 1);
                }
                else
                {
                    dic[A[i]]++;
                    if (dic[A[i]] > A.Length / 2 - 1)
                    {
                        return A[i];
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/shortest-word-distance/ 243. 最短单词距离
        /// </summary>
        /// <param name="wordsDict"></param>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int ShortestDistance(string[] wordsDict, string word1, string word2)
        {
            int result = wordsDict.Length, l = -1, r = -1;
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (wordsDict[i] == word1)
                {
                    l = i;
                }
                else if (wordsDict[i] == word2)
                {
                    r = i;
                }
                if (l != -1 && r != -1)
                {
                    result = Math.Min(result, Math.Abs(r - l));
                }

            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/shortest-word-distance-iii/ 245. 最短单词距离 III
        /// </summary>
        /// <param name="wordsDict"></param>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int ShortestWordDistance(string[] wordsDict, string word1, string word2)
        {
            if (word1 != word2)
            {
                int result = wordsDict.Length, l = -1, r = -1;
                for (int i = 0; i < wordsDict.Length; i++)
                {
                    if (wordsDict[i] == word1)
                    {
                        l = i;
                    }
                    else if (wordsDict[i] == word2)
                    {
                        r = i;
                    }
                    if (l != -1 && r != -1)
                    {
                        result = Math.Min(result, Math.Abs(r - l));
                    }

                }
                return result;
            }
            else
            {
                bool l = true;
                int left = -1, right = -1, result = 0;
                for (int i = 0; i < wordsDict.Length; i++)
                {
                    if (wordsDict[i] == word1)
                    {
                        if (l)
                        {

                            left = i;
                            l = false;
                        }
                        else
                        {
                            right = i;
                            l = true;
                        }
                    }
                    if (left != -1 && right != -1)
                    {
                        result = Math.Min(result, Math.Abs(right - left));
                    }
                }
                return result;
            }
        }
        /// <summary>

        /// <summary>
        /// https://leetcode-cn.com/problems/mean-of-array-after-removing-some-elements/ 1619. 删除某些元素后的数组均值
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double TrimMean(int[] arr)
        {
            Array.Sort(arr);
            int rate = int.Parse((arr.Length * 0.05).ToString());
            double sum = 0;
            for (int i = rate; i < arr.Length - rate; i++)
            {
                sum += arr[i];
            }
            return sum / (double.Parse((arr.Length * 0.9).ToString()));
        }
        /// <summary>
        /// 347. 前 K 个高频元素 https://leetcode-cn.com/problems/top-k-frequent-elements/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }
            int[][] matrix = new int[dic.Keys.Count][];
            int index = 0;
            foreach (var key in dic.Keys)
            {
                matrix[index] = new int[] { key, dic[key] };
                index++;
            }
            Array.Sort(matrix, (a, b) =>
            {
                if (a[1] > b[1])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });
            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = matrix[i][0];
            }
            return result;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/shortest-unsorted-continuous-subarray/ 581. 最短无序连续子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindUnsortedSubarray(int[] nums)
        {
            int max = nums[0], min = nums[nums.Length - 1], left = 0, right = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < max)
                {
                    right = i;
                }
                else
                {
                    max = nums[i];
                }

                if (nums[nums.Length - 1 - i] > min)
                {
                    left = nums.Length - 1 - i;
                }
                else
                {
                    min = nums[nums.Length - 1 - i];
                }
            }
            return right - left + 1;
        }
        private static void testAction()
        {
            var actionlist = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                actionlist.Add(() => Console.WriteLine(i + ""));
            }
            foreach (var action in actionlist)
            {
                action();
            }

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/zui-chang-bu-han-zhong-fu-zi-fu-de-zi-zi-fu-chuan-lcof/ 剑指 Offer 48. 最长不含重复字符的子字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring2(string s)
        {
            int left = 0, result = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    left = Math.Max(left, dic[s[i]] + 1);
                    dic[s[i]] = i;
                }
                result = Math.Max(result, i - left + 1);
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/check-if-one-string-swap-can-make-strings-equal/ 1790. 仅执行一次字符串交换能否使两个字符串相等
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool AreAlmostEqual(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            int diffCount = 0, d1 = 0, d2 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    diffCount++;
                    if (diffCount == 1)
                    {
                        d1 = i;
                    }
                    else if (diffCount == 2)
                    {
                        d2 = i;
                        if (s1[d1] != s2[d2] || s1[d2] != s2[d1])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/find-pivot-index/ 724. 寻找数组的中心下标
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int PivotIndex(int[] nums)
        {
            int left = 0, right = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                right += nums[i];
            }
            int index = 1;
            while (index < nums.Length)
            {
                if (left == right)
                {
                    return index - 1;
                }
                left += nums[index - 1];
                right -= nums[index];

                index++;
            }
            return left == right ? index - 1 : -1;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/continuous-subarray-sum/   523. 连续的子数组和
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            int[] sum = new int[nums.Length + 1];
            Dictionary<int, int> set = new Dictionary<int, int>();
            set.Add(0, -1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
                int mod = k == 0 ? sum[i + 1] : sum[i + 1] % k;
                if (set.ContainsKey(mod))
                {
                    if (i - set[mod] > 1)
                        return true;
                }
                else
                {
                    set.Add(mod, i);
                }

            }

            return false;

            //if (k == 0)
            //{
            //    for (int i = 1; i < nums.Length; i++)
            //    {
            //        if (nums[i - 1] == nums[i] && nums[i] == 0)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}

            //int[] pre=new int[nums.Length+1];
            //HashSet<int> set = new HashSet<int>();
            //set.Add(0);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    pre[i + 1] = pre[i] + nums[i];
            //    int mod = pre[i + 1] % k;
            //    if (set.Contains(mod))
            //    {
            //        return true;
            //    }
            //    if (!set.Contains(mod))
            //    {
            //        set.Add(mod);
            //    }
            //}
            //return false;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/subarray-product-less-than-k/ 713. 乘积小于K的子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
                return 0;

            int result = 0, times = 1;
            int left = 0, right = 0;
            while (right < nums.Length)
            {
                times *= nums[right];
                while (times >= k)
                {
                    times /= nums[left];
                    left++;
                }
                result += right - left + 1;
                right++;
            }
            return result;

        }


        /// <summary>
        /// https://leetcode-cn.com/problems/subarray-sum-equals-k/ 560. 和为K的子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySum(int[] nums, int k)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] sum = new int[nums.Length + 1];
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
                if (sum[i + 1] == k)
                {
                    result++;
                    if (nums[i] == k)
                    {
                        result++;
                    }
                }
                else if (dic.ContainsKey(sum[i + 1] - k))
                {
                    result++;


                }
                if (!dic.ContainsKey(sum[i + 1]))
                {
                    dic.Add(sum[i + 1], i + 1);
                }

            }
            return result;

            ///题目没限制正整数，有负数的情况下不好用滑动窗口
            //if (nums == null || nums.Length == 0) return 0;

            //int l = 0, r = 0, sum = 0, res = 0;
            //while (l<nums.Length&&r<nums.Length)
            //{
            //    sum += nums[r];
            //    if (sum>k)
            //    {
            //        sum -= nums[l] + nums[r];
            //        l++;
            //    }
            //    else if (sum==k)
            //    {
            //        res++;
            //        sum -= nums[l]+nums[r];
            //        l++;
            //    }
            //    else
            //    {
            //        r++;
            //    }
            //}
            //return res;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/minimum-size-subarray-sum/ 209. 长度最小的子数组
        /// </summary>
        /// <param name="target"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int l = 0, r = 0, sum = 0, result = int.MaxValue;
            while (r < nums.Length)
            {
                sum += nums[r];
                if (sum >= target)
                {
                    result = Math.Min(result, r - l + 1);

                    sum -= nums[l];
                    sum -= nums[r];
                    l++;
                }
                else
                {
                    r++;
                }
            }
            return result;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-size-subarray-sum-equals-k/ 325. 和等于 k 的最长子数组长度
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxSubArrayLen(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] sum = new int[nums.Length + 1];
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
                if (sum[i + 1] == k)
                {
                    res = i + 1;
                    if (!dic.ContainsKey(sum[i + 1]))
                    {
                        dic.Add(sum[i + 1], i + 1);
                    }
                }
                else if (dic.ContainsKey(sum[i + 1] - k))
                {
                    res = Math.Max(res, i + 1 - dic[sum[i + 1] - k]);
                }
                else if (!dic.ContainsKey(sum[i + 1]))
                {
                    dic.Add(sum[i + 1], i + 1);
                }
            }
            return res;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/perform-string-shifts/ 1427. 字符串的左右移
        /// </summary>
        /// <param name="s"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        public static string StringShift(string s, int[][] shift)
        {
            LinkedList<char> queue = new LinkedList<char>();
            for (int i = 0; i < s.Length; i++)
            {
                queue.AddLast(s[i]);
            }
            for (int i = 0; i < shift.Length; i++)
            {

                int times = shift[i][1];
                if (shift[i][0] == 1)//move to right
                {

                    while (times > 0)
                    {
                        char temp = queue.Last();
                        queue.RemoveLast();
                        queue.AddFirst(temp);
                        times--;
                    }

                }
                else
                {
                    //move to left
                    while (times > 0)
                    {
                        char temp = queue.First();
                        queue.RemoveFirst();
                        queue.AddLast(temp);
                        times--;
                    }
                }
            }
            string strResult = "";
            while (queue.Count > 0)
            {
                strResult += queue.First();
                queue.RemoveFirst();
            }
            return strResult;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/contiguous-array/ 525. 连续数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, -1);
            int count = 0, result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i] == 1 ? 1 : -1;
                if (dic.ContainsKey(count))
                {
                    result = Math.Max(result, i - dic[count]);
                }
                else
                {
                    dic.Add(count, i);
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/fruit-into-baskets/ 904. 水果成篮
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static int TotalFruit(int[] tree)
        {
            int l = -1, r = 0, res = 0, count = 0;
            for (int i = 0; i < tree.Length; i++)
            {
                if (tree[i] == tree[r])
                {
                    count++;
                }
                else
                {
                    if (l < 0 || tree[i] == tree[l])
                        count++;
                    else
                    {
                        res = Math.Max(count, res);
                        count = i - r + 1;
                    }

                    l = r;
                    r = i;
                }
            }
            res = Math.Max(count, res);
            return res;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/number-of-subarrays-with-bounded-maximum/ 795. 区间子数组个数
        /// </summary>
        /// <param name="A"></param>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        public static int NumSubarrayBoundedMax(int[] A, int L, int R)
        {

            int t1 = 0, t2 = 0;
            int n = A.Length;
            for (int right = 0, left = 0; right < n;)
            {
                if (A[right] <= R)
                {
                    ++right;
                    t1 += right - left;
                }
                else
                {
                    ++right;
                    left = right;
                }
            }
            for (int right = 0, left = 0; right < n;)
            {
                if (A[right] < L)
                {
                    ++right;
                    t2 += right - left;
                }
                else
                {
                    ++right;
                    left = right;
                }
            }
            return t1 - t2;

            //if (A==null || A.Length < 1) return 0;
            //int len = A.Length;
            //int ans = 0;
            //int l = 0, r = 0;
            //while (r < len)
            //{
            //    if (L <= A[r] && A[r] <= R)
            //    { //情况一
            //        ans += r - l + 1;
            //        r++;
            //    }
            //    else if (A[r] < L)
            //    { // 情况二
            //        int t = r - 1;
            //        while (t >= l && A[t] < L) t--;
            //        ans += t - l + 1;
            //        r++;
            //    }
            //    else
            //    {  // 情况三
            //        l = r + 1;
            //        r++;
            //    }
            //}
            //return ans;


            //int left = 0, right = 0,currMax=int.MinValue,res=0;
            //HashSet<int> set = new HashSet<int>();
            //while (right<A.Length)
            //{
            //    currMax=Math.Max(currMax,A[right]);
            //    if (A[right]<=R&&A[right]>=L)
            //    {
            //        set.Add(A[right]);
            //    }
            //    if (currMax<=R&&currMax>=L)
            //    {
            //        right++;
            //        res++;
            //    }
            //    else
            //    {

            //        while (left<=right)
            //        {
            //            if (set.Contains(A[left]))
            //            {
            //                set.Remove(A[left]);
            //            }
            //            if (set.Count > 0)
            //            {
            //                left++;
            //                res++;
            //            }
            //            else
            //            {
            //                break;
            //            }

            //        }
            //        right++;
            //        left = right;

            //        set.Clear();
            //        currMax = int.MinValue;
            //    }
            //}
            //return res;


        }
        /// <summary>
        /// https://leetcode-cn.com/problems/count-number-of-nice-subarrays/ 1248. 统计「优美子数组」
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int NumberOfSubarrays(int[] nums, int k)
        {
            int l = 0, r = 0, currCount = 0, result = 0, lastOdd = 0, nextOdd = 0;
            while (r < nums.Length)
            {
                if (nums[r++] % 2 == 1)
                {
                    currCount++;
                }
                if (currCount == k)
                {

                    nextOdd = r;
                    while (r < nums.Length && nums[r] % 2 == 0)
                    {
                        r++;
                    }

                    lastOdd = 0;
                    while (nums[l] % 2 == 0)
                    {
                        lastOdd++;
                        l++;
                    }

                    result += (lastOdd + 1) * (r - nextOdd + 1);

                    l++;
                    currCount--;
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-length-of-repeated-subarray/ 718. 最长重复子数组
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int FindLength(int[] A, int[] B)
        {
            int n = A.Length, m = B.Length;
            int[][] dp = new int[n + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[m + 1];
            }
            int ans = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (A[i] == B[j])
                    {
                        dp[i][j] = dp[i + 1][j + 1] + 1;
                    }
                    else
                    {
                        dp[i][j] = 0;
                    }

                    ans = Math.Max(ans, dp[i][j]);
                }
            }
            return ans;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/shu-zu-zhong-shu-zi-chu-xian-de-ci-shu-lcof/  剑指 Offer 56 - I. 数组中数字出现的次数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SingleNumbers(int[] nums)
        {

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum ^= nums[i];
            }
            int firstDiff = 1;
            while ((sum & firstDiff) == 0)
            {
                firstDiff <<= 1;
            }
            int a = 0, b = 0;
            foreach (var num in nums)
            {
                if ((num & firstDiff) == 0)
                {
                    a ^= num;
                }
                else
                {
                    b ^= num;
                }
            }
            return new int[] { a, b };


            //List<int> res = new List<int>();
            //Array.Sort(nums);
            //if (nums[0]!=nums[1])
            //{
            //    res.Add(nums[0]);
            //}
            //for (int i = 1; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
            //    {
            //        res.Add(nums[i]);
            //    }
            //}
            //if (nums[nums.Length-2] != nums[nums.Length-1])
            //{
            //    res.Add(nums[nums.Length - 1]);
            //}
            //return res.ToArray();



            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //    {
            //        dic[nums[i]]++;
            //    }
            //    else
            //    {
            //        dic.Add(nums[i],1);
            //    }
            //}
            //List<int> res = new List<int>();
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key]==1)
            //    {
            //        res.Add(key);
            //    }
            //}
            //return res.ToArray();
        }




        /// <summary>
        /// https://leetcode-cn.com/problems/largest-number/ 179. 最大数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string LargestNumber(int[] nums)
        {
            Array.Sort(nums, (a, b) =>
            {
                if (long.Parse(a.ToString() + b.ToString()) < long.Parse(b.ToString() + a.ToString()))
                {
                    return -1;
                }

                else
                {
                    return 1;
                }
            });
            string strResult = "";
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                strResult += nums[i].ToString();
            }
            return strResult.IndexOf('0') == 0 && strResult.Length > 1 ? strResult.Substring(zeroCount - 1, strResult.Length - zeroCount + 1) : strResult;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/ba-shu-zu-pai-cheng-zui-xiao-de-shu-lcof/ 剑指 Offer 45. 把数组排成最小的数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string MinNumber(int[] nums)
        {
            Array.Sort(nums, (a, b) =>
            {
                if (long.Parse(a.ToString() + b.ToString()) < long.Parse(b.ToString() + a.ToString()))
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });
            string strResult = "";
            for (int i = 0; i < nums.Length; i++)
            {
                strResult += nums[i].ToString();
            }
            return strResult;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/jian-sheng-zi-lcof/ 剑指 Offer 14- I. 剪绳子
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CuttingRope(int n)
        {
            if (n < 5)
            {
                switch (n)
                {
                    case 1:
                    case 2:
                        return 1;
                    case 3:
                        return 2;
                    case 4:
                        return 4;
                }
            }
            long timeRes = 1;
            if (n % 3 == 2)
            {
                int n1 = (n - 2) / 3;
                while (n1 > 0)
                {
                    timeRes = 3 * timeRes % 1000000007;
                    n1--;
                }
                timeRes *= 2;
                //timeRes = (long)Math.Pow(3, n1) * 2;
            }
            else if (n % 3 == 0)
            {
                int n2 = n / 3;
                while (n2 > 0)
                {
                    timeRes = 3 * timeRes % 1000000007;
                    n2--;
                }
            }
            else if (n % 3 == 1)
            {
                int n3 = (n - 4) / 3;
                while (n3 > 0)
                {
                    timeRes = 3 * timeRes % 1000000007;
                    n3--;
                }
                timeRes *= 4;
            }

            return int.Parse((timeRes % 1000000007).ToString());

        }


        /// <summary>
        /// https://leetcode-cn.com/problems/chou-shu-lcof/ 剑指 Offer 49. 丑数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NthUglyNumber(int n)
        {
            int[] dp = new int[n];
            dp[0] = 1;
            int a = 0, b = 0, c = 0;
            for (int i = 1; i < n; i++)
            {
                int n1 = dp[a] * 2, n2 = dp[b] * 3, n3 = dp[c] * 5;
                dp[i] = Math.Min(Math.Min(n1, n2), n3);
                if (dp[i] == n1)
                    a++;
                if (dp[i] == n2)
                    b++;
                if (dp[i] == n3)
                    c++;
            }
            return dp[n - 1];
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/arithmetic-subarrays/ 1630. 等差子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            IList<bool> res = new List<bool>();
            for (int i = 0; i < l.Length; i++)
            {
                int left = l[i], right = r[i];
                int[] currArr = new int[right - left + 1];
                Array.ConstrainedCopy(nums, left, currArr, 0, currArr.Length); //nums.Skip(1).Take(right - left + 1).ToArray();
                Array.Sort(currArr);
                int diff = currArr[1] - currArr[0];
                bool currResult = true;
                for (int j = 1; j < currArr.Length; j++)
                {
                    if (currArr[j] - currArr[j - 1] != diff)
                    {
                        currResult = false;
                        break;
                    }
                }
                res.Add(currResult);

            }
            return res;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-points-you-can-obtain-from-cards/ 1423. 可获得的最大点数
        /// </summary>
        /// <param name="cardPoints"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxScore(int[] cardPoints, int k)
        {

            int currSum = 0, min = 0, len = cardPoints.Length - k, total = 0;
            int l = 0, r = 0;
            for (; r < len; r++)
            {
                currSum += cardPoints[r];
            }
            min = currSum;
            while (r < cardPoints.Length)
            {

                currSum += cardPoints[r] - cardPoints[l];
                min = Math.Min(currSum, min);
                r++;
                l++;
            }
            for (int i = 0; i < cardPoints.Length; i++)
            {
                total += cardPoints[i];
            }
            return total - min;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-average-subarray-i/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double FindMaxAverage(int[] nums, int k)
        {
            int l = 0, r = k - 1;
            double sum = 0, avg = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            avg = sum / k;
            r++;
            while (r < nums.Length)
            {
                sum += nums[r] - nums[l];
                avg = Math.Max((sum / k), avg);
                r++;
                l++;
            }
            return avg;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/largest-subarray-length-k/ 1708. 长度为 K 的最大子数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] LargestSubarray(int[] nums, int k)
        {
            int max = 0, index = 0;
            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }

            }
            int[] res = new int[k];
            for (int i = index; i < index + k; i++)
            {
                res[i - index] = nums[i];
            }
            return res;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/high-five/  1086. 前五科的均分
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static int[][] HighFive(int[][] items)
        {
            Array.Sort(items, (a, b) =>
            {
                if (a[0] > b[0])
                {
                    return 1;
                }
                else if (a[0] < b[0])
                {
                    return -1;
                }
                else
                {
                    if (a[1] > b[1])
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }

            });
            int currStu = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < items.Length; i++)
            {
                if (!set.Contains(items[i][0]))
                {
                    set.Add(items[i][0]);
                }
            }
            int[][] newItems = new int[set.Count][];
            set.Clear();
            for (int i = 0; currStu < newItems.Length && i < items.Length; i++)
            {
                if (set.Contains(items[i][0]))
                {
                    continue;
                }
                if (newItems[currStu] == null)
                {
                    int count = 0, currSum = 0, currIndex = items[i][0];
                    while (count < 5)
                    {

                        currSum += items[i][1];

                        if (count != 4)
                        {
                            i++;
                        }
                        count++;
                    }
                    newItems[currStu] = new int[] { items[i - 1][0], currSum / 5 };
                    currStu++;
                    set.Add(items[i - 1][0]);
                }
            }
            return newItems;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/minimum-operations-to-reduce-x-to-zero/ 1658. 将 x 减到 0 的最小操作数
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MinOperations3(int[] nums, int x)
        {
            int n = nums.Length;
            Dictionary<int, int> l_presum = new Dictionary<int, int>();
            Dictionary<int, int> r_presum = new Dictionary<int, int>();
            int l_sum = 0;
            for (int i = 0; i < n; i++)
            {
                l_sum += nums[i];
                if (l_sum > x)
                {
                    break;
                }
                l_presum.Add(l_sum, i + 1);
            }
            int r_sum = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                r_sum += nums[i];
                if (r_sum > x)
                {
                    break;
                }
                r_presum.Add(r_sum, n - i);
            }

            int l_steps = 0, r_steps = 0;

            l_steps = l_presum.ContainsKey(x) ? l_presum[x] : int.MaxValue;
            r_steps = r_presum.ContainsKey(x) ? r_presum[x] : int.MaxValue;

            int cur = Math.Min(l_steps, r_steps);

            foreach (var left in l_presum.Keys)
            {
                if (r_presum.ContainsKey(x - left))
                {
                    int l = l_presum[left];
                    int r = r_presum[x - left];
                    if (l + r <= n)
                    {
                        cur = Math.Min(cur, l + r);
                    }
                }
            }
            return cur != int.MaxValue ? cur : -1;

            //int maxPart = -1;
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //    sum += nums[i];
            //int currentSum = 0;
            //int left = 0;
            //int right = 0;
            //while (left < nums.Length)
            //{
            //    // 如果右边未到尽头，不断先向右探测片段，如果大于目标sum-x则左边移动直到结束
            //    if (right < nums.Length)
            //    {
            //        currentSum += nums[right++];
            //    }
            //    while (currentSum > sum - x && left < nums.Length)
            //    {
            //        currentSum -= nums[left++];
            //    }
            //    if (currentSum == sum - x)
            //    {
            //        maxPart = Math.Max(maxPart, right - left);
            //    }
            //    if (right == nums.Length)
            //    {
            //        left++;
            //    }
            //}
            //return maxPart == -1 ? -1 : nums.Length - maxPart;

            ////滑动窗口 SlideWindow 求最长子数组
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //    sum += nums[i];

            //sum = sum - x;
            //if (sum == 0) return nums.Length;
            //if (sum < 0) return -1;

            //int l = 0, r = 0, maxLen = -1, currSum = 0;
            //while (l < nums.Length && r < nums.Length)
            //{
            //    while (r < nums.Length && currSum < sum)
            //    {
            //        currSum += nums[r];
            //        if (currSum < sum)
            //        {
            //            r++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    maxLen = currSum == sum ? Math.Max(maxLen, r - l + 1) : maxLen;
            //    r += currSum == sum ? 1 : 0;
            //    currSum -=nums[l++];
            //}
            //return maxLen == nums.Length || maxLen == -1 ? -1 : nums.Length - maxLen;
        }
        /// <summary>
        /// 454. 四数相加 II https://leetcode-cn.com/problems/4sum-ii/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            int result = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (dic.ContainsKey(A[i] + B[j]))
                        dic[A[i] + B[j]]++;
                    else
                        dic.Add(A[i] + B[j], 1);
                }
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    if (dic.ContainsKey(-1 * (C[i] + D[j])))
                    {
                        result += dic[-1 * (C[i] + D[j])];

                    }
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/koko-eating-bananas/ 875. 爱吃香蕉的珂珂
        /// </summary>
        /// <param name="piles"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public static int MinEatingSpeed(int[] piles, int h)
        {
            int minSpeed = 1, maxSpeed = int.MaxValue;
            for (int i = 0; i < piles.Length; i++)
            {
                maxSpeed += piles[i];
            }
            while (minSpeed < maxSpeed)
            {
                int middle = minSpeed + (maxSpeed - minSpeed) / 2;

                int costHours = 0, index = 0;

                for (index = 0; index < piles.Length; index++)
                {
                    costHours += piles[index] % middle == 0 ? piles[index] / middle : piles[index] / middle + 1;
                }

                if (costHours <= h)
                {
                    maxSpeed = middle;
                }
                else
                {
                    minSpeed = middle + 1;
                }
            }
            return minSpeed;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/capacity-to-ship-packages-within-d-days/  1011. 在 D 天内送达包裹的能力
        /// </summary>
        /// <param name="weights"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static int ShipWithinDays(int[] weights, int D)
        {

            int min = 0, max = 0, middle = min + (max - min) / 2, day = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                max += weights[i];
                min = Math.Max(min, weights[i]);
            }
            while (min < max)
            {
                middle = min + (max - min) / 2;
                day = 0;
                int currWeight = 0, index = 0;
                while (index < weights.Length)
                {
                    while (index < weights.Length && currWeight + weights[index] <= middle)
                    {
                        currWeight += weights[index++];
                    }
                    day++;
                    currWeight = 0;
                }
                if (day == D)
                {
                    max = middle;
                }
                else if (day < D)
                {
                    max = middle;
                }
                else
                {
                    min = middle + 1;
                }

            }
            return min;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/single-element-in-a-sorted-array/ 540. 有序数组中的单一元素
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNonDuplicate(int[] nums)
        {
            int l = 0, r = nums.Length - 1, middle = l + (r - l) / 2;
            while (l <= r)
            {
                middle = l + (r - l) / 2;
                if (middle - 1 > -1 && nums[middle - 1] == nums[middle])
                {
                    if ((middle - 1) % 2 == 0 && (nums.Length - 1 - middle) % 2 != 0)
                    {
                        l = middle + 1;
                    }
                    else
                    {
                        r = middle - 1;
                    }
                }
                else
                {
                    if (middle + 1 < nums.Length && nums[middle + 1] == nums[middle])
                    {
                        if ((middle) % 2 == 0)
                        {
                            l = middle + 1;
                        }
                        else
                        {
                            r = middle - 1;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return nums[middle];

            ////暴力
            //if (nums==null||nums.Length==0)
            //    return -1;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i]==nums[i-1])
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        return nums[i-1];
            //    }
            //}
            //return -1;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/kth-smallest-element-in-a-sorted-matrix/ 378. 有序矩阵中第 K 小的元素
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int KthSmallest(int[][] matrix, int k)
        {
            int n = matrix.Length, m = matrix[0].Length;
            int l = matrix[0][0], r = matrix[n - 1][m - 1];

            while (l <= r)
            {
                int middle = l + (r - l) / 2;
                if (GetCountKthSmallest(matrix, middle) < k)
                {
                    l = middle + 1;
                }
                else
                {
                    r = middle - 1;

                }
            }
            return l;
            //暴力
            //int n = matrix.Length, m = matrix[0].Length;
            //int[] arr = new int[n * m];
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        arr[index++] = matrix[i][j];
            //    }
            //}
            //Array.Sort(arr);
            //return arr[k - 1];
        }

        public static int GetCountKthSmallest(int[][] matrix, int tartget)
        {
            int count = 0;
            int row = matrix.Length - 1, col = 0;
            while (row >= 0 && col < matrix[0].Length)
            {
                if (matrix[row][col] <= tartget)
                {
                    count += row + 1;
                    col++;
                }
                else
                {
                    row--;
                }
            }
            return count;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/longest-increasing-subsequence/ 300. 最长递增子序列
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = 1;
            }
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);
                    }
                }
                result = Math.Max(dp[i], result);
            }
            return result;
        }

        /// <summary>
        /// 1252. 奇数值单元格的数目 https://leetcode-cn.com/problems/cells-with-odd-values-in-a-matrix/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="indices"></param>
        /// <returns></returns>
        public static int oddCells(int n, int m, int[][] indices)
        {
            int result = 0;
            int[,] arr = new int[n, m];

            for (int i = 0; i < indices.Length; i++)
            {
                int row = indices[i][0], col = indices[i][1];
                for (int k = 0; k < n; k++)
                {
                    arr[k, col]++;
                }
                for (int g = 0; g < m; g++)
                {
                    arr[row, g]++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] % 2 == 1)
                        result++;
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/missing-element-in-sorted-array/ 1060. 有序数组中的缺失元素
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MissingElement(int[] nums, int k)
        {
            int len = nums.Length;

            for (int i = 1; i < len; i++)
            {
                int loss = nums[i] - nums[i - 1] - 1;
                if (loss >= k)
                {
                    return nums[i - 1] + k;
                }
                else
                {
                    k = k - loss;
                }
            }

            return nums[len - 1] + k;
            //int l = 0, r = nums.Length - 1, m = l + (r - l) / 2, diff = nums[0];
            //while (l <= r)
            //{
            //    m = l + (r - l) / 2;
            //    if (nums[m] == diff + m)
            //    {
            //        l = m + 1;
            //    }
            //    else
            //    {
            //        r = m - 1;
            //    }
            //}
            //List<int> lis = new List<int>();

            //while (lis.Count < k)
            //{
            //    for (int i = 0; i < nums[r] - nums[l] - 1; i++)
            //    {
            //        lis.Add(nums[l] + i + 1);
            //    }
            //    l = r; r = l + 1;
            //    if (r >= nums.Length)
            //    {
            //        break;
            //    }
            //}
            //if (k > lis.Count)
            //{
            //    int foreachTime = k - lis.Count;
            //    for (int i = 0; i < foreachTime; i++)
            //    {
            //        lis.Add(nums[nums.Length - 1] + i + 1);
            //    }
            //}
            //return lis[k - 1];
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/find-smallest-common-element-in-all-rows/ 1198. 找出所有行中最小公共元素

        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int SmallestCommonElement(int[][] mat)
        {
            int min = mat[0][0];
            for (int i = 0; i < mat[0].Length; i++)
            {
                min = mat[0][i];
                bool same = false;
                int index = -1;
                for (int j = 1; j < mat.Length; j++)
                {
                    int l = 0, r = mat[j].Length - 1;
                    index = -1;
                    same = false;
                    while (l <= r)
                    {
                        int m = l + (r - l) / 2;
                        if (mat[j][m] == mat[0][i])
                        {
                            index = m;
                            same = true;
                            break;
                        }
                        else if (mat[j][m] > mat[0][i])
                        {
                            r = m - 1;
                        }
                        else
                        {
                            l = m + 1;
                        }
                    }
                    if (index < 0)
                    {
                        break;
                    }
                }

                if (same)
                {
                    return min;
                }
            }
            return min;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/find-all-the-lonely-nodes/ 1469. 寻找所有的独生节点
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> GetLonelyNodes(TreeNode root)
        {
            IList<int> resultLis = new List<int>();
            DFS_GetLonelyNodes(root, resultLis);
            return resultLis;
        }

        public static void DFS_GetLonelyNodes(TreeNode root, IList<int> resultLis)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    if (root.right == null)
                    {
                        resultLis.Add(root.left.val);
                    }
                    DFS_GetLonelyNodes(root.left, resultLis);
                }
                if (root.right != null)
                {
                    if (root.left == null)
                    {
                        resultLis.Add(root.right.val);
                    }
                    DFS_GetLonelyNodes(root.right, resultLis);
                }
            }
        }
        ///// <summary>
        ///// https://leetcode-cn.com/problems/search-in-a-sorted-array-of-unknown-size/ 702. 搜索长度未知的有序数组
        ///// </summary>
        ///// <param name="reader"></param>
        ///// <param name="target"></param>
        ///// <returns></returns>
        //public static int Search(ArrayReader reader, int target)
        //{
        //    int len = 1;
        //    while (reader.Get(len) != 2147483647)
        //    {
        //        len *= 2;
        //    }
        //    int l = 0, r = len - 1, m = l + (r - l) / 2;
        //    while (l <= r)
        //    {
        //        m = l + (r - l) / 2;
        //        int val = reader.Get(m);
        //        if (val == target)
        //        {
        //            return m;
        //        }
        //        else if (val < target)
        //        {
        //            l = m + 1;
        //        }
        //        else
        //        {
        //            r = m - 1;
        //        }
        //    }
        //    return -1;
        //}
        private static double closestValueDiff = double.MaxValue;
        private static int closestValueResult = -1;
        /// <summary>
        /// https://leetcode-cn.com/problems/closest-binary-search-tree-value/ 270. 最接近的二叉搜索树值
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int ClosestValue(TreeNode root, double target)
        {
            int l = root.val, r = root.val;
            while (root != null)
            {
                if (target < root.val)
                {
                    r = root.val;
                    root = root.left;
                }
                else if (target > root.val)
                {
                    l = root.val;
                    root = root.right;
                }
                else
                    return root.val;
            }
            return Math.Abs(target - l) < Math.Abs(r - target) ? l : r;

            //if (root!=null)
            //{
            //    double curr = (double)root.val;
            //    if (Math.Abs(target-curr)<closestValueDiff)
            //    {
            //        closestValueDiff = Math.Abs(target - curr);
            //        closestValueResult = root.val;
            //    }
            //    if (curr==target)
            //    {
            //        return root.val;
            //    }
            //    if (root.left != null)
            //    {
            //        ClosestValue(root.left, target);
            //    }
            //    if (root.right != null)
            //    {
            //        ClosestValue(root.right, target);
            //    }
            //}

            //return closestValueResult;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/fixed-point/ 1064. 不动点
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FixedPoint(int[] arr)
        {
            //binarySearch
            int l = 0, r = arr.Length - 1, m = l + (r - l) / 2;
            while (l <= r)
            {
                m = l + (r - l) / 2;
                if (arr[m] >= m)
                {
                    r = m - 1;
                }
                else if (arr[m] < m)
                {
                    l = m + 1;
                }
            }
            if (l != arr.Length && arr[l] == l)
            {
                return l;
            }
            return -1;


            //暴力
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]==i)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }
        /// <summary>
        /// test 查找 target 出现的第 1 个位置 https://leetcode-cn.com/problems/find-first-and-last-position-of-element-in-sorted-array/solution/da-jia-bu-yao-kan-labuladong-de-jie-fa-fei-chang-2/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static int findFirstPosition(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    // ① 不可以直接返回，应该继续向左边找，即 [left..mid - 1] 区间里找
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    // 应该继续向右边找，即 [mid + 1, right] 区间里找
                    left = mid + 1;
                }
                else
                {
                    // 此时 nums[mid] > target，应该继续向左边找，即 [left..mid - 1] 区间里找
                    right = mid - 1;
                }
            }

            // 此时 left 和 right 的位置关系是 [right, left]，注意上面的 ①，此时 left 才是第 1 次元素出现的位置
            // 因此还需要特别做一次判断
            if (left != nums.Length && nums[left] == target)
            {
                return left;
            }
            return -1;
        }

        /// <summary>
        /// 1150. 检查一个数是否在数组中占绝大多数 https://leetcode-cn.com/problems/check-if-a-number-is-majority-element-in-a-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsMajorityElement(int[] nums, int target)
        {

            //双指针
            int i = 0, j = nums.Length - 1;

            while (nums[i] != target)
            {
                i++;
            }
            while (nums[j] != target)
            {
                j--;
            }
            return j - i + 1 > nums.Length / 2;




            ///暴力
            //int currCount = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]==target)
            //    {
            //        for (int j = i; j < nums.Length&&nums[j]==target; j++)
            //        {
            //            currCount++;
            //        }
            //        break;
            //    }
            //}
            //return currCount > nums.Length / 2;
        }

        /// <summary>
        /// 测试二分查找小于tartget的数量
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="tartget"></param>
        /// <returns></returns>
        private static int testBinarySearch(int[] arr, int tartget)
        {
            int result = 0, l = 0, r = arr.Length - 1, middle = l + (r - l) / 2;
            while (l <= r)
            {
                middle = l + (r - l) / 2;
                if (arr[middle] > tartget)
                {
                    r = middle - 1;
                }
                else if (arr[middle] < tartget)
                {
                    l = middle + 1;
                }
                else
                {
                    l++;
                }
            }
            return r + 1;

        }

        /// <summary>
        /// https://leetcode-cn.com/problems/2vYnGI/ LCP 18. 早餐组合
        /// </summary>
        /// <param name="staple"></param>
        /// <param name="drinks"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int BreakfastNumber(int[] staple, int[] drinks, int x)
        {
            int result = 0;
            int mod = (int)(1e9 + 7);
            Array.Sort(drinks);

            for (int i = 0; i < staple.Length; ++i)
            {
                if (staple[i] < x)
                {
                    int left = 0, right = drinks.Length, target = x - staple[i];
                    while (left < right)
                    {
                        int middle = left + (right - left) / 2;
                        if (drinks[middle] <= target)
                        {
                            left = middle + 1;
                        }
                        else
                        {
                            right = middle;
                        }

                    }
                    result += left;
                    result %= mod;
                }
                else
                {
                    continue;
                }
            }
            result %= mod;
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/sum-of-unique-elements/ 1748. 唯一元素的和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (dic[nums[i]] == 1)
                    {
                        sum -= nums[i];
                    }
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                    sum += nums[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/non-decreasing-array/  665. 非递减数列
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CheckPossibility(int[] nums)
        {
            int count = 0, peek = int.MaxValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    count++;
                    if (count > 1)
                    {
                        return false;
                    }

                    peek = nums[i];
                }
                if (nums[i] > peek)
                {
                    peek = nums[i];
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 1742. 盒子中小球的最大数量 https://leetcode-cn.com/problems/maximum-number-of-balls-in-a-box/
        /// </summary>
        /// <param name="lowLimit"></param>
        /// <param name="highLimit"></param>
        /// <returns></returns>
        public static int CountBalls(int lowLimit, int highLimit)
        {
            int max = 0;
            int[] arr = new int[highLimit];
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int temp = i, currSum = 0;
                while (temp > 0)
                {
                    currSum += temp % 10;
                    temp /= 10;
                }
                arr[currSum - 1]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(arr[i], max);
            }
            return max;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-nesting-depth-of-two-valid-parentheses-strings/ 1111. 有效括号的嵌套深度
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int[] MaxDepthAfterSplit(string seq)
        {
            return null;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/armstrong-number/ 1134. 阿姆斯特朗数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsArmstrong(int n)
        {
            int sum = 0, curr = 0, temp = n, len = 0;
            while (temp > 0)
            {
                len++;
                temp /= 10;
            }
            temp = n;
            while (temp > 0)
            {
                curr = temp % 10;
                sum += (int)Math.Pow(curr, len);
                temp /= 10;
            }
            return sum == n;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/count-items-matching-a-rule/ 1773. 统计匹配检索规则的物品数量
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ruleKey"></param>
        /// <param name="ruleValue"></param>
        /// <returns></returns>
        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int index = 2, result = 0;
            if (ruleKey == "color")
                index = 1;
            else if (ruleKey == "type")
                index = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i][index] == ruleValue)
                {
                    result++;
                }
            }
            return result;
        }
        /// <summary>
        /// 1769. 移动所有球到每个盒子所需的最小操作数 https://leetcode-cn.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
        /// </summary>
        /// <param name="boxes"></param>
        /// <returns></returns>
        public static int[] MinOperations(string boxes)
        {
            int leftMove = 0, leftCount = 0, rightMove = 0, rightCount = 0;
            int[] result = new int[boxes.Length];
            for (int i = 1; i < boxes.Length; i++)
            {
                rightCount += boxes[i] - '0';
                rightMove += (boxes[i] - '0') * i;
            }
            result[0] = rightMove;
            for (int i = 1; i < boxes.Length; i++)
            {
                leftMove += leftCount + (boxes[i - 1] - '0');
                leftCount += (boxes[i - 1] - '0');

                rightCount -= (boxes[i] - '0');
                rightMove -= rightCount + (boxes[i] - '0');


                result[i] = leftMove + rightMove;
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/latest-time-by-replacing-hidden-digits/ 1736. 替换隐藏数字得到的最晚时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string MaximumTime(string time)
        {
            char[] arr = time.ToCharArray();
            if (arr[0] == '?')
            {
                arr[0] = '2';
            }
            if (arr[1] == '?')
            {
                if (arr[0] == '2')
                {
                    arr[1] = '3';
                }
                else
                {
                    arr[1] = '9';
                }
            }
            if (arr[3] == '?')
            {
                arr[3] = '5';
            }
            if (arr[4] == '?')
            {
                arr[4] = '9';

            }
            return new String(arr);
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/minimum-changes-to-make-alternating-binary-string/ 1758. 生成交替二进制字符串的最少操作数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MinOperations2(string s)
        {
            //分别判断奇偶位为1的情况
            int ct1 = 0, ct2 = 0;
            for (int i = s.Length - 1; i > -1; i--)
            {
                if (s[i] % 2 == i % 2)
                {
                    ct1++;
                }
                else
                {
                    ct2++;
                }
            }
            return Math.Min(ct1, ct2);
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/how-many-apples-can-you-put-into-the-basket/ 1196. 最多可以买到的苹果数量
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MaxNumberOfApples(int[] arr)
        {
            Array.Sort(arr);
            int total = 5000, count = 0;
            for (int i = 0; i < arr.Length && total - arr[i] > 0; i++)
            {
                total -= arr[i];
                count++;
            }
            return count;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/calculate-money-in-leetcode-bank/ 1716. 计算力扣银行的钱
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int TotalMoney(int n)
        {
            int currMon = 1, sum = 0;
            while (n > 0)
            {
                int num = Math.Min(7, n);
                for (int i = currMon; i < currMon + num; i++)
                {
                    sum += i;
                }
                currMon++;
                n -= num;
            }
            return sum;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-units-on-a-truck/submissions/  题目描述  1710. 卡车上的最大单元数
        /// </summary>
        /// <param name="boxTypes"></param>
        /// <param name="truckSize"></param>
        /// <returns></returns>
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int result = 0, index = 0;

            int[][] testMatrix = new int[boxTypes.Length][];
            boxTypes.CopyTo(testMatrix, 0);

            Array.Sort(boxTypes, (y, x) => (y[1] - x[1]));
            Array.Sort(testMatrix, (x, y) => (y[1] - x[1]));
            Array.Sort(testMatrix, (x, y) => (x[1] - y[1]));

            while (truckSize > 0 && index < boxTypes.Length)
            {
                int num = Math.Min(truckSize, boxTypes[index][0]);
                truckSize -= num;
                result += num * boxTypes[index][1];
                index++;
            }
            return result;
        }

        /// <summary>
        /// 74. 搜索二维矩阵 https://leetcode-cn.com/problems/search-a-2d-matrix/
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int n = matrix.Length, m = matrix[0].Length;

            int l = 0, r = m * n - 1;
            while (l <= r)
            {
                int middle = (l + r) / 2;
                if (matrix[middle / n][middle % n] == target)
                {
                    return true;
                }
                else if (target > matrix[middle / n][middle % n])
                {
                    l = middle + 1;
                }
                else
                {
                    r = middle - 1;
                }
            }
            return false;
        }
        /// <summary>
        /// 240. 搜索二维矩阵 II https://leetcode-cn.com/problems/search-a-2d-matrix-ii/
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix2(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0) return false;

            int row = matrix.Length - 1, col = 0;
            while (row >= 0 && col < matrix[0].Length)
            {
                if (matrix[row][col] == target)
                {
                    return true;
                }
                else if (matrix[row][col] > target)
                {
                    row--;
                }
                else
                {
                    col++;
                }
            }

            return false;
        }
        /// <summary>
        /// 11. 盛最多水的容器 https://leetcode-cn.com/problems/container-with-most-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea(int[] height)
        {
            int area = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                if (height[l] < height[r])
                {
                    area = Math.Max(area, height[l] * (r - l));
                    l++;
                }
                else
                {
                    area = Math.Max(area, height[r] * (r - l));
                    r--;
                }

            }
            return area;

            ////暴力法1
            //int area = 0;
            //for (int i = 0; i < height.Length; i++)
            //{
            //    for (int j = i+1; j < height.Length; j++)
            //    {
            //        area = Math.Max(area,Math.Min( height[i],height[j])*(j-i));
            //    }
            //}
            //return area;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/find-closest-lcci/  面试题 17.11. 单词距离
        /// </summary>
        /// <param name="words"></param>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int FindClosest(string[] words, string word1, string word2)
        {
            int l = -1, r = -1, closest = int.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word1)
                {
                    l = i;
                    closest = (r != -1 ? Math.Min(closest, Math.Abs(r - l)) : closest);
                }
                else if (words[i] == word2)
                {
                    r = i;
                    closest = (r != -1 ? Math.Min(closest, Math.Abs(r - l)) : closest);
                }
            }

            return closest;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/string-rotation-lcci/ 面试题 01.09. 字符串轮转               
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool IsFlipedString(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            string temp = s1 + s2;
            if (temp.IndexOf(s1) < 0)
                return false;

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;

        }

        /// <summary>
        /// https://leetcode-cn.com/problems/word-pattern/ 290. 单词规律
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool WordPattern(string pattern, string s)
        {
            string[] arrStr = s.Split(' ');
            if (arrStr.Length != pattern.Length) return false;

            Dictionary<string, char> dic = new Dictionary<string, char>();
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < arrStr.Length; i++)
            {
                if (!dic.ContainsKey(arrStr[i]))
                {
                    if (set.Contains(pattern[i]))
                    {
                        return false;
                    }
                    dic.Add(arrStr[i], pattern[i]);
                    set.Add(pattern[i]);
                }
                else
                {
                    if (dic[arrStr[i]] != pattern[i])
                    {
                        return false;
                    }
                }
            }
            //Dictionary<char, string> dic2 = new Dictionary<char, string>();
            //for (int i = 0; i < pattern.Length; i++)
            //{
            //    if (!dic2.ContainsKey(pattern[i]))
            //    {
            //        dic2.Add(pattern[i],arrStr[i]);
            //    }
            //    else
            //    {
            //        if (dic2[pattern[i]]!=arrStr[i])
            //        {
            //            return false;
            //        }
            //    }
            //}
            return true;
        }
        /// <summary>
        /// 剑指 Offer 56 - II. 数组中数字出现的次数 II https://leetcode-cn.com/problems/shu-zu-zhong-shu-zi-chu-xian-de-ci-shu-ii-lcof/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber2(int[] nums)
        {
            //位运算
            int result = 0;
            int[] count = new int[32];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 31; j > -1; j--)
                {
                    count[j] += nums[i] % 2;
                    nums[i] >>= 1;
                }
            }
            for (int i = 31; i > -1; i--)
            {
                count[i] %= 3;
            }
            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                if (i == 29)
                {

                }
                result += count[i];

            }
            return result;

            //if (nums.Length == 1) return nums[0];
            //Array.Sort(nums);
            //if (nums[0] != nums[1]) return nums[0];
            //for (int i = 1; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
            //        return nums[i];
            //}
            //if (nums[nums.Length - 1] != nums[nums.Length - 2]) return nums[nums.Length - 1];
            //return -1;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/two-sum/  1. 两数之和
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum3(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]) && dic[target - nums[i]] != i)
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }
            return null;
        }
        /// <summary>
        /// 15. 三数之和  https://leetcode-cn.com/problems/3sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSum2(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0) return result;

            Array.Sort(nums);
            if (nums[0] > 0)
            {
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int target = -1 * nums[i];
                int l = i + 1, r = nums.Length - 1;
                Dictionary<int, int> dic = new Dictionary<int, int>();
                while (l < r)
                {
                    if (nums[l] + nums[r] == target)
                    {
                        result.Add(new List<int> { nums[l], nums[r], nums[i] });
                        while (l < r && nums[l] == nums[l + 1]) l++;
                        while (l < r && nums[r] == nums[r - 1]) r--;
                        l++;
                        r--;
                    }
                    else if (nums[l] + nums[r] < target)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// 剑指 Offer 05. 替换空格 https://leetcode-cn.com/problems/ti-huan-kong-ge-lcof/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReplaceSpace(string s)
        {
            //原地修改

            //1.加长长度
            int spaceCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    spaceCount++;
            }
            char[] arr = new char[s.Length + spaceCount * 2];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i];
            }
            //2.覆盖
            int slow = s.Length - 1 + spaceCount * 2, fast = s.Length - 1;
            while (fast >= 0)
            {
                if (arr[fast] == ' ')
                {
                    arr[slow] = '0';
                    arr[slow - 1] = '2';
                    arr[slow - 2] = '%';
                    slow -= 3;
                }
                else
                {
                    arr[slow] = arr[fast];
                    slow--;
                }
                fast--;
            }
            string strResult = new String(arr);
            return strResult;
            //char[] arr = new char[s.Length * 3];
            //int index = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ')
            //    {
            //        arr[index++] = '%';
            //        arr[index++] = '2';
            //        arr[index++] = '0';
            //    }
            //    else
            //    {
            //        arr[index++] = s[i];
            //    }
            //}
            //return new String(arr, 0, index);

        }
        /// <summary>
        /// 1165. 单行键盘 https://leetcode-cn.com/problems/single-row-keyboard/
        /// </summary>
        /// <param name="keyboard"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int CalculateTime(string keyboard, string word)
        {
            int time = 0, preIndex = 0, currIndex = 0;
            int[] indexArr = new int[26];
            for (int i = 0; i < keyboard.Length; i++)
            {
                indexArr[keyboard[i] - 'a'] = i + 1;
            }
            for (int i = 0; i < word.Length; i++)
            {
                currIndex = indexArr[word[i] - 'a'] - 1;
                time += Math.Abs(currIndex - preIndex);
                preIndex = currIndex;
            }
            return time;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/find-the-highest-altitude/1732. 找到最高海拔
        /// </summary>
        /// <param name="gain"></param>
        /// <returns></returns>
        public static int LargestAltitude(int[] gain)
        {
            int max = 0, curr = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                curr += gain[i];
                max = Math.Max(curr, max);
            }
            return max;
        }
        /// <summary>
        /// 760. 找出变位映射 https://leetcode-cn.com/problems/find-anagram-mappings/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] AnagramMappings(int[] A, int[] B)
        {
            int[] resultArr = new int[A.Length];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++)
            {
                dic[B[i]] = i;
            }
            for (int i = 0; i < A.Length; i++)
            {
                resultArr[i] = dic[A[i]];
            }
            return resultArr;
            //int[] resultArr = new int[A.Length];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int curr = A[i];
            //    for (int j = 0; j < B.Length; j++)
            //    {
            //        if (curr==B[j])
            //        {
            //            resultArr[i] = j;
            //        }
            //    }
            //}
            //return resultArr;
        }
        /// <summary>
        /// 1099. 小于 K 的两数之和 https://leetcode-cn.com/problems/two-sum-less-than-k/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int TwoSumLessThanK(int[] nums, int k)
        {
            if (nums.Length <= 1) return -1;

            Array.Sort(nums);

            int l = 0, r = nums.Length - 1, maxSum = -1;
            while (l < r)
            {
                if (nums[l] + nums[r] >= k)
                {
                    r--;
                }
                else
                {
                    maxSum = Math.Max(maxSum, nums[l] + nums[r]);
                    l++;
                }
            }


            //int i = nums.Length-1,maxSum=-1;
            //while (nums[i] >= k)
            //{
            //    i--;
            //}
            //while (i>1)
            //{
            //    for (int j = i-1; j >-1; j--)
            //    {
            //        int currSum = nums[i] + nums[j];
            //        if (currSum < k)
            //        {
            //            maxSum = Math.Max(currSum, maxSum);
            //        }
            //    }
            //    i--;
            //}
            return maxSum;
        }

        /// <summary>
        /// 1474. 删除链表 M 个节点之后的 N 个节点 https://leetcode-cn.com/problems/delete-n-nodes-after-m-nodes-of-a-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ListNode DeleteNodes(ListNode head, int m, int n)
        {
            ListNode slow = head;
            while (slow != null)
            {
                for (int i = 1; i < m; i++)
                {
                    slow = slow.next;
                }
                if (slow == null)
                {
                    break;
                }
                ListNode fast = slow;
                for (int i = 0; i < n && fast != null; i++)
                {
                    fast = fast.next;
                }
                if (fast == null)
                {
                    slow.next = fast;
                    break;
                }
                slow.next = fast.next;
                slow = fast.next;
            }
            return head;
        }
        /// <summary>
        /// 1180. 统计只含单一字母的子串 https://leetcode-cn.com/problems/count-substrings-with-only-one-distinct-letter/
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int CountLetters(string S)
        {
            if (S.Length == 1) return 1;

            int result = 0, count = 1;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i - 1] == S[i])
                {
                    count++;
                }
                else
                {
                    result += count * (count + 1) / 2;
                    count = 1;
                }
            }
            result += count * (count + 1) / 2;
            return result;
            //if (S.Length == 1) return 1;

            //int result = 0,currCharLen=1;
            //char currChar = S[0];
            //for (int i = 1; i < S.Length; i++)
            //{
            //    if (currChar==S[i])
            //    {
            //        currCharLen++;
            //        if (i == S.Length - 1)
            //        {
            //            result += (currCharLen * (currCharLen + 1)) / 2; ;
            //        }
            //    }
            //    else
            //    {
            //        result += (currCharLen * (currCharLen + 1)) / 2;
            //        currChar = S[i];
            //        currCharLen = 1;
            //        if (i==S.Length-1)
            //        {
            //            result += (currCharLen * (currCharLen + 1)) / 2; ;
            //        }
            //    }
            //}
            //return result;

        }

        /// <summary>
        /// 1752. 检查数组是否经排序和轮转得到 https://leetcode-cn.com/problems/check-if-array-is-sorted-and-rotated/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CheckRotateArray(int[] nums)
        {
            bool isSorted = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            if (isSorted)
            {
                return true;
            }
            int count = 0;
            for (int i = 0; i < nums.Length - 1 && count < 2; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    count++;
                }
            }
            return count < 2 && nums[nums.Length - 1] + 1 == nums[0];



            //string strAppend = "",strOriginal="";
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    strAppend += nums[i].ToString()+",";
            //}
            //strAppend += strAppend;
            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    strOriginal += nums[i].ToString() + ",";
            //}
            //return strAppend.IndexOf(strOriginal)>-1;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/intersection-of-three-sorted-arrays/ 1213. 三个有序数组的交集
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="arr3"></param>
        /// <returns></returns>
        public static IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            IList<int> lis = new List<int>();
            int[] timesArr = new int[2001];
            for (int i = 0; i < arr1.Length; i++)
            {
                timesArr[arr1[i]]++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                timesArr[arr2[i]]++;
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                timesArr[arr3[i]]++;
            }

            for (int i = 0; i < timesArr.Length; i++)
            {
                if (timesArr[i] == 3)
                {
                    lis.Add(i);
                }
            }
            return lis;

            //int i=0,j=0,k=0;
            //IList<int> lis = new List<int>();

            //while (i<arr1.Length&&j<arr2.Length&&k<arr3.Length)
            //{
            //    int a = arr1[i];
            //    int b = arr2[j];
            //    int c = arr3[k];
            //    if (a == b && b == c)
            //    {
            //        lis.Add(a);
            //    }
            //    if (a > b || a > c)
            //    {
            //        i--;
            //    }
            //    if (b > a || b > c)
            //    {
            //        j--;
            //    }
            //    if (c > a || c > b)
            //    {
            //        k--;
            //    }
            //    i++;
            //    j++;
            //    k++;
            //}
            //return lis;
        }
        //static int ressumNums = 0;
        //public static int sumNums(int n)
        //{
        //    bool x = n > 1 && sumNums(n - 1) > 0;
        //    ressumNums += n;
        //    return ressumNums;
        //}

        /// <summary>
        /// 1052. 爱生气的书店老板 https://leetcode-cn.com/problems/grumpy-bookstore-owner/
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="grumpy"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            int max = 0, sum = 0, start = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                sum += grumpy[i] == 0 ? customers[i] : 0;
            }
            while (start < grumpy.Length - X + 1)
            {
                int curr = 0;
                for (int i = start; i < start + X; i++)
                {
                    curr += grumpy[i] == 1 ? customers[i] : 0;
                }
                max = Math.Max(curr, max);
                start++;
            }

            return sum + max;
        }
        /// <summary>
        /// 1768. 交替合并字符串 https://leetcode-cn.com/problems/merge-strings-alternately/
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static string MergeAlternately(string word1, string word2)
        {
            int i = 0;
            string strResult = "";
            while (i < word1.Length || i < word2.Length)
            {
                strResult += i < word1.Length ? word1[i].ToString() : "";
                strResult += i < word2.Length ? word2[i].ToString() : "";
                i++;
            }
            return strResult;
        }
        public static string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static Random tinyUrlRan = new Random();
        //public static Dictionary<string, string> dicTinyUrl = new Dictionary<string, string>();
        //public static string GetTinyUrlString()
        //{
        //    string strCodedUrl = "";
        //    for (int i = 0; i < 6; i++)
        //    {
        //        strCodedUrl += alphabet[tinyUrlRan.Next(62)];
        //    }
        //    return strCodedUrl;
        //}
        ///// <summary>
        ///// 535. TinyURL 的加密与解密 https://leetcode-cn.com/problems/encode-and-decode-tinyurl/
        ///// </summary>
        ///// <param name="longUrl"></param>
        ///// <returns></returns>
        //public static string encodeTinyURL(string longUrl)
        //{
        //    string key = GetTinyUrlString();
        //    if (!dicTinyUrl.ContainsKey(key))
        //    {
        //        dicTinyUrl.Add(key, longUrl);
        //    }
        //    return "http://tinyurl.com/" + key;

        //}
        //// Decodes a shortened URL to its original URL.
        //public static string decodeTinyURL(string shortUrl)
        //{
        //    string key = shortUrl.Replace("http://tinyurl.com/", "");
        //    return dicTinyUrl[key];
        //}
        /// <summary>
        /// 766. 托普利茨矩阵 https://leetcode-cn.com/problems/toeplitz-matrix/
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static bool IsToeplitzMatrix(int[][] matrix)
        {

            int n = matrix[0].Length, m = matrix.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (matrix[j][i] != matrix[j + 1][i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 1720. 解码异或后的数组  https://leetcode-cn.com/problems/decode-xored-array/
        /// </summary>
        /// <param name="encoded"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public int[] Decode(int[] encoded, int first)
        {
            int[] code = new int[encoded.Length + 1];
            code[0] = first;
            for (int i = 1; i < code.Length; i++)
            {
                code[i] = code[i - 1] ^ encoded[i - 1];
            }
            return code;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/1689. 十-二进制数的最少数目
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int MinPartitions(string n)
        {
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int curr = n[i] - '0';
                result = Math.Max(curr, result);
            }
            return result;
        }
        /// <summary>
        /// 1725. 可以形成最大正方形的矩形数目 https://leetcode-cn.com/problems/number-of-rectangles-that-can-form-the-largest-square/
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        public static int CountGoodRectangles(int[][] rectangles)
        {
            int maxlen = 0, result = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                int curr = Math.Min(rectangles[i][0], rectangles[i][1]);
                if (curr > maxlen)
                {
                    maxlen = curr;
                    result = 1;
                }
                else if (curr == maxlen)
                {
                    result++;
                }

            }
            return result;

        }
        public static string RemoveVowels(string s)
        {
            string strTemp = "aeiou ";
            for (int i = 0; i < strTemp.Length; i++)
            {
                s = s.Replace(strTemp[i].ToString(), "");
            }
            return s;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/count-binary-substrings/  696. 计数二进制子串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CountBinarySubstrings(string s)
        {
            int result = 0, left = 0;
            List<int> lis = new List<int>();
            while (left < s.Length)
            {
                char curr = s[left];
                int count = 0;
                while (left < s.Length && s[left] == curr)
                {
                    count++;
                    left++;
                }
                lis.Add(count);
            }

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (i != s.Length - 1&&s[i] != s[left])
            //    {
            //        lis.Add(i - left);
            //        left = i;
            //    }
            //    else if (i == s.Length - 1)
            //    {
            //        if (s[i] == s[left])
            //        {
            //            lis.Add( i - left + 1);
            //        }
            //        else
            //        {
            //            lis.Add( i - left );
            //            lis.Add(1);
            //        }

            //    }
            //}
            for (int i = 1; i < lis.Count; i++)
            {
                result += Math.Min(lis[i], lis[i - 1]);
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/number-of-students-unable-to-eat-lunch/  1700. 无法吃午餐的学生数量
        /// </summary>
        /// <param name="students"></param>
        /// <param name="sandwiches"></param>
        /// <returns></returns>
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            int[] stuLike = new int[2];
            for (int i = 0; i < students.Length; i++)
            {
                stuLike[students[i]]++;
            }
            for (int i = 0; i < students.Length; i++)
            {
                if (stuLike[sandwiches[i]] == 0)
                {
                    break;
                }
                stuLike[sandwiches[i]]--;
            }
            return stuLike[0] + stuLike[1];
            //LinkedList<int> queueSan = new LinkedList<int>(),queueStu=new LinkedList<int>();
            //for (int i = 0; i < students.Length; i++)
            //{
            //    queueStu.AddLast(students[i]);
            //}
            //for (int i = 0; i < sandwiches.Length; i++)
            //{
            //    queueSan.AddLast(sandwiches[i]);
            //}
            //while (queueSan.Count!=0)
            //{
            //    if (queueSan.First()==queueStu.First())
            //    {
            //        queueStu.RemoveFirst();
            //        queueSan.RemoveFirst();
            //    }
            //    else 
            //    {
            //        int firstVal = queueStu.First();
            //        bool isSame = true ;
            //        foreach (var item in queueStu)
            //        {
            //            if (item!=firstVal)
            //            {
            //                isSame = false;
            //            }
            //        }
            //        if (isSame) return queueStu.Count;

            //        int temp = queueStu.First();
            //        queueStu.RemoveFirst();
            //        queueStu.AddLast(temp);
            //    }
            //}
            //return queueStu.Count;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/excel-sheet-column-title/ 168. Excel表列名称
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                int temp = n % 26;
                sb.Insert(0, (char)(temp + 'A' - 1));
                n /= 26;
            }
            return sb.ToString();
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/summary-ranges/ 228. 汇总区间
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();
            if (nums.Length == 0) return result;


            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (j == nums.Length - 1 || nums[j] + 1 != nums[j + 1])
                {
                    string tempStr = nums[i].ToString();
                    if (i != j)
                    {
                        tempStr += "->";
                        tempStr += nums[j];
                    }


                    result.Add(tempStr);
                    i = j + 1;
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/coin-change/    322. 零钱兑换
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static int CoinChange(int[] coins, int amount)
        {
            // 给 0 占位
            int[] dp = new int[amount + 1];

            // 注意：因为要比较的是最小值，这个不可能的值就得赋值成为一个最大值
            //Array.fill(dp, amount + 1);
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = amount + 1;
            }

            // 理解 dp[0] = 0 的合理性，单独一枚硬币如果能够凑出面值，符合最优子结构
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i - coin >= 0 && dp[i - coin] != amount + 1)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
                    }
                }
            }

            if (dp[amount] == amount + 1)
            {
                dp[amount] = -1;
            }
            return dp[amount];
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/positions-of-large-groups/ 830. 较大分组的位置
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IList<IList<int>> LargeGroupPositions(string s)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (s.Length == 1)
            {
                return result;
            }
            int left = 0, right = 1;
            while (right < s.Length)
            {
                if (s[right] == s[right - 1])
                {
                    right++;
                }
                else
                {
                    if (right - left > 2)
                    {
                        result.Add(new List<int> { left, right - 1 });
                    }
                    left = right;
                    right++;
                }
            }
            if (right - left > 2)
            {
                result.Add(new List<int> { left, right - 1 });
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/permutation-in-string/  567. 字符串的排列
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            int[] s1map = new int[26];
            int[] s2map = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                s1map[s1[i] - 'a']++;
                s2map[s2[i] - 'a']++;
            }
            for (int i = 0; i < (s2.Length - s1.Length); i++)
            {
                if (matches(s1map, s2map))
                    return true;
                s2map[s2[i + s1.Length] - 'a']++;
                s2map[s2[i] - 'a']--;
            }
            return matches(s1map, s2map);
        }
        public static bool matches(int[] s1map, int[] s2map)
        {
            for (int i = 0; i < 26; i++)
            {
                if (s1map[i] != s2map[i])
                    return false;
            }
            return true;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/determine-if-string-halves-are-alike/  1704. 判断字符串的两半是否相似
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HalvesAreAlike(string s)
        {
            string strYuan = "aeiouAEIOU";
            int count = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (strYuan.IndexOf(s[i]) > -1)
                {
                    count++;
                }
            }
            for (int i = s.Length / 2; i < s.Length; i++)
            {
                if (strYuan.IndexOf(s[i]) > -1)
                {
                    count--;
                }
            }
            return count == 0;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/maximum-nesting-depth-of-the-parentheses/  1614. 括号的最大嵌套深度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxDepth(string s)
        {
            int result = 0, curr = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':

                        curr++;
                        break;
                    case ')':
                        result = Math.Max(curr, result);
                        curr--;
                        break;

                    default:
                        break;
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetc
        /// <summary>
        /// https://leetcode-cn.com/problems/fibonacci-number/  509. 斐波那契数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int p = 0, q = 0, r = 1;
            for (int i = 2; i <= n; ++i)
            {
                p = q;
                q = r;
                r = p + q;
            }
            return r;
            //if (n == 0) return 0;
            //if (n == 1) return 1;

            //return Fib(n-1)+Fib(n-2);

            //if (n == 0) return 0;
            //if (n == 1) return 1;

            //int[] arr = new int[n + 1];
            //arr[1] = 1;
            //for (int i = 2; i < arr.Length; i++)
            //{
            //    arr[i] = arr[i - 1] + arr[i - 2];
            //}
            //return arr[arr.Length - 1];
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/ 3. 无重复字符的最长子串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int left = 0, result = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    left = Math.Max(left, dic[s[i]] + 1);
                    dic[s[i]] = i;
                }
                result = Math.Max(result, i - left + 1);
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/valid-palindrome-ii/ 680. 验证回文字符串 Ⅱ
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ValidPalindrome(string s)
        {
            //for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            //{
            //    if (s[i] != s[j])
            //    {
            //        //分两种情况，一是右边减一，二是左边加一
            //        return isPalindrome(s, i, j - 1) || isPalindrome(s, i + 1, j);
            //    }
            //}
            //return true;



            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    int left2 = left + 1, right2 = right;
                    bool flag1 = true, flag2 = true;
                    while (left2 < right2)
                    {
                        if (s[left2] == s[right2])
                        {
                            left2++;
                            right2--;
                        }
                        else
                        {
                            flag1 = false;
                            break;
                        }
                        flag1 = true;
                    }

                    int left3 = left, right3 = right - 1;
                    while (left3 < right3)
                    {
                        if (s[left3] == s[right3])
                        {
                            left3++;
                            right3--;
                        }
                        else
                        {
                            flag2 = false;
                            break;
                        }
                        flag2 = true;
                    }

                    return flag1 || flag2;
                }
            }
            return true;
        }


        public static bool isPalindrome(String s, int i, int j)
        {
            while (i < j)
            {
                if (s[i++] != s[j--])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 将数组转换成链表
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static ListNode GenerateListNodeFromArray(int[] arr)
        {
            ListNode headNode = new ListNode(arr[0]);
            ListNode currNode = headNode;
            for (int i = 1; i < arr.Length; i++)
            {
                ListNode tempNode = new ListNode(arr[i]);
                currNode.next = tempNode;
                currNode = currNode.next;
            }
            return headNode;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/fan-zhuan-lian-biao-lcof/  剑指 Offer 24. 反转链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList2(ListNode head)
        {
            List<int> lis = new List<int>();
            while (head != null)
            {
                lis.Add(head.val);
                head = head.next;
            }
            ListNode newNode = new ListNode(lis[lis.Count - 1]);
            ListNode currNode = newNode;
            for (int i = lis.Count - 2; i > -1; i--)
            {
                ListNode tempNode = new ListNode(lis[i]);
                currNode.next = tempNode;
                currNode = currNode.next;
            }
            return newNode;

        }

        /// <summary>
        /// https://leetcode-cn.com/problems/partition-array-into-three-parts-with-equal-sum/  1013. 将数组分成和相等的三个部分
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = 0, tempSum = 0, index = 0, result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            while (index < arr.Length)
            {
                if (result < 2)
                {
                    tempSum += arr[index++];
                    if (tempSum == sum / 3)
                    {
                        result++;
                        tempSum = 0;
                    }
                }
                else
                {
                    tempSum += arr[index++];
                    if (index == arr.Length && tempSum == sum / 3)
                    {
                        result++;
                    }
                }
            }
            return result == 3;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/merge-sorted-array/   合并两个有序数组
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public static void MergeNum(int[] nums1, int m, int[] nums2, int n)
        {
            int len = nums1.Length - 1;
            while (m != 0 || n != 0)
            {
                while (m != 0 && n != 0)
                {
                    if (nums1[m - 1] > nums2[n - 1])
                    {
                        nums1[len--] = nums1[m - 1];
                        m--;
                    }
                    else
                    {
                        nums1[len--] = nums2[n - 1];
                        n--;
                    }
                }
                while (m != 0)
                {
                    nums1[len--] = nums1[m - 1];
                    m--;
                }
                while (n != 0)
                {
                    nums1[len--] = nums2[n - 1];
                    n--;
                }
            }
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/add-binary/ 67. 二进制求和
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary(string a, string b)
        {
            string strResult = "";
            int n = a.Length > b.Length ? a.Length : b.Length, carry = 0;
            for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                carry += i >= 0 ? a[i] - '0' : 0;
                carry += j >= 0 ? b[j] - '0' : 0;
                strResult += (carry % 2).ToString();
                carry /= 2;
            }
            if (carry > 0)
            {
                strResult += "1";
            }
            return string.Join("", strResult.ToArray().Reverse());
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/longest-common-prefix/   14. 最长公共前缀
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            int minIndex = int.MaxValue;
            foreach (var str in strs)
            {
                minIndex = minIndex > str.Length ? str.Length : minIndex;
            }
            string strResult = "";
            for (int i = 0; i < minIndex; i++)
            {
                bool isCommon = true;
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != strs[j - 1][i])
                    {
                        isCommon = false;
                    }
                }
                if (isCommon)
                {
                    strResult += strs[0][i];
                }
                else
                {
                    return strResult;
                }
            }
            return strResult;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/third-maximum-number/  414. 第三大的数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ThirdMax(int[] nums)
        {

            var numList = new List<int>(3);
            foreach (var numItem in nums)
            {
                if (numList.Contains(numItem)) continue;

                if (numList.Count < 3)
                {
                    numList.Add(numItem);
                    numList.Sort();
                }
                else if (numList.Count == 3 && numList.First() < numItem)
                {
                    numList[0] = numItem;
                    numList.Sort();
                }
            }

            return numList.Count < 3 ? numList.Last() : numList.First();

            //if (nums == null || nums.Length < 3) return -1;

            //Array.Sort(nums);
            //return nums[nums.Length - 3];
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/longest-harmonious-subsequence/ 594. 最长和谐子序列
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindLHS(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i] + 1))
                {
                    result = Math.Max(dic[nums[i]] + dic[nums[i] + 1], result);
                }
            }
            return result;
            //int result = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currLength = 0;
            //    bool flag = false;
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j]  )
            //        {
            //            currLength++;
            //        }
            //        else if(nums[j] == nums[i] + 1)
            //        {
            //            currLength++;
            //            flag = true;
            //        }
            //    }
            //    result = flag? Math.Max(currLength, result):result  ;
            //}
            //return result;
            //Dictionary<int, int> map = new Dictionary<int, int>();
            //int res = 0;
            //foreach (int num in nums)
            //{
            //    if (!map.ContainsKey(num))
            //    {
            //        map.Add(num,1);
            //    }
            //    else
            //    {
            //        map[num]++;
            //    }
            //    if (map.ContainsKey(num + 1))
            //        res = Math.Max(res, map[num] + map[num + 1]);
            //    if (map.ContainsKey(num - 1))
            //        res = Math.Max(res, map[num] + map[num - 1]);
            //}
            //return res;
        }

        public static int MinMoves(int[] nums)
        {
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                min = Math.Min(nums[i], min);
            }
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i] - min;
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/contains-duplicate-ii/ 219. 存在重复元素 II
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
                if (set.Count > k)
                {
                    set.Remove(nums[i - k]);
                }
            }

            return false;

        }
        /// <summary>
        /// 941. 有效的山脉数组 https://leetcode-cn.com/problems/valid-mountain-array/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;

            int left = 0, right = arr.Length - 1;

            while (left < arr.Length - 1 && arr[left] < arr[left + 1])
            {
                left++;
            }
            while (right > 1 && arr[right] < arr[right - 1])
            {
                right--;
            }
            if (left != 0 && right != arr.Length - 1 && left == right)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 387. 字符串中的第一个唯一字符 https://leetcode-cn.com/problems/first-unique-character-in-a-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FirstUniqChar2(string s)
        {
            int[] arrChar = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arrChar[s[i] - 'a']++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (arrChar[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/sort-array-by-increasing-frequency/  1636. 按照频率将数组升序排序
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] FrequencySort(int[] nums)
        {
            int[] fre = new int[200];
            for (int i = 0; i < nums.Length; i++)
            {
                fre[nums[i] + 100]++;
            }
            Array.Sort(nums, (x, y) =>
            {
                if (fre[x + 100] > fre[y + 100])
                {
                    return 1;
                }
                else if (fre[x + 100] < fre[y + 100])
                {
                    return -1;
                }
                else
                {
                    return x > y ? -1 : 1;
                }
            });
            return nums;
            //int[] resultArr = new int[nums.Length];
            ////for (int i = 99; i > 89; i--)
            ////{
            ////    resultArr[i]=
            ////}

            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!dic.ContainsKey(nums[i]))
            //    {
            //        dic.Add(nums[i],1);
            //    }
            //    else
            //    {
            //        dic[nums[i]]++;
            //    }
            //}
            //List<int[]> lis = new List<int[]>();
            //int[][] freArr = new int[nums.Length][];
            //int index=0;
            //foreach (var key in dic.Keys)
            //{
            //    for (int i = 0; i < dic[key]; i++)
            //    {
            //        int[] tempArr = new int[] {dic[key] ,key};
            //        lis.Add(tempArr);
            //    }
            //}
            //lis.Sort((  x,  y) =>
            // {
            //     if (x[0]==y[0])
            //     {
            //         if (x[1]>y[1])
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/remove-k-digits/ 402. 移掉K位数字
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string RemoveKdigits(string num, int k)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < num.Length; i++)
            {
                while (k > 0 && st.Count > 0 && st.Peek() > num[i])
                {
                    st.Pop();
                    k--;

                }
                if (num[i] != '0' || st.Count != 0)
                {
                    st.Push(num[i]);
                }
            }
            while (k != 0 && st.Count > 0)
            {
                st.Pop();
                k--;
            }
            if (st.Count == 0)
                return "0";
            string strResult = "";
            while (st.Count > 0)
            {
                strResult += st.Peek();
                st.Pop();
            }
            var result = strResult.Reverse().ToArray();
            return new String(result);
        }
        /// <summary>
        /// 1688. 比赛中的配对次数 https://leetcode-cn.com/problems/count-of-matches-in-tournament/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NumberOfMatches(int n)
        {
            int times = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    times += n / 2;
                    n /= 2;
                }
                else
                {
                    times += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }
            return times;
        }
        /// <summary>
        /// 599. 两个列表的最小索引总和 https://leetcode-cn.com/problems/minimum-index-sum-of-two-lists/
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            int minIndex = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                if (!dic.ContainsKey(list1[i]))
                {
                    dic.Add(list1[i], i);
                }
            }
            List<string> lisResult = new List<string>();
            for (int i = 0; i < list2.Length; i++)
            {

                if (dic.ContainsKey(list2[i]))
                {
                    int currIndex = i + dic[list2[i]];
                    if (lisResult.Count == 0)
                    {
                        minIndex = currIndex;
                        lisResult.Add(list2[i]);
                    }
                    else
                    {

                        if (currIndex < minIndex)
                        {
                            minIndex = currIndex;
                            lisResult.Clear();
                            lisResult.Add(list2[i]);
                        }
                        else if (currIndex == minIndex)
                        {
                            lisResult.Add(list2[i]);
                        }
                    }

                }
            }
            return lisResult.ToArray();
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/reformat-date/1507. 转变日期格式
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ReformatDate(string date)
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string[] inputArr = date.Split(' ');
            string strResult = "";
            int year = int.Parse(inputArr[2]), month = 0;
            strResult += inputArr[2];
            for (int i = 0; i < months.Length; i++)
            {
                if (inputArr[1] == months[i])
                {
                    month = (i + 1);
                }
            }
            int day = int.Parse(inputArr[0].Substring(0, inputArr[0].Length - 2));

            return strResult = year.ToString() + "-" + month.ToString().PadLeft(2, '0') + "-" + day.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/find-lucky-integer-in-an-array/ 1394. 找出数组中的幸运数
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindLucky(int[] arr)
        {
            Array.Sort(arr);
            int freq = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == arr[i - 1])
                {
                    freq++;
                }
                else
                {
                    if (freq + 1 == arr[i])
                    {
                        return arr[i];
                    }
                    freq = 0;
                }
            }
            if (arr[0] == freq + 1)
            {
                return arr[0];
            }
            return -1;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!dic.ContainsKey(arr[i]))
            //    {
            //        dic.Add(arr[i],1);
            //    }
            //    else
            //    {
            //        dic[arr[i]]++;
            //    }
            //}

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/sort-array-by-parity/ 905. 按奇偶排序数组
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortArrayByParity(int[] A)
        {
            int left = 0, right = A.Length - 1;
            while (left < right)
            {
                while (left < A.Length && A[left] % 2 == 0)
                {
                    left++;
                }
                while (right > -1 && A[right] % 2 != 0)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;
                }
            }
            return A;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/longest-uncommon-subsequence-i/ 521. 最长特殊序列 Ⅰ
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int FindLUSlength(string a, string b)
        {
            if (a == b) return -1;
            return Math.Max(a.Length, b.Length);

        }

        /// <summary>
        /// https://leetcode-cn.com/problems/goal-parser-interpretation/ 1678. 设计 Goal 解析器
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static string Interpret(string command)
        {
            string strResult = "";
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                {
                    strResult += "G";
                }
                else if (i + 1 < command.Length)
                {
                    if (command[i + 1] == ')')
                    {
                        strResult += "o";
                        i++;
                    }
                    else
                    {
                        strResult += "al";
                        i += 3;
                    }
                }
            }
            return strResult;
        }
        /// <summary>
        /// 5609. 统计一致字符串的数目 https://leetcode-cn.com/problems/count-the-number-of-consistent-strings/
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                bool isRight = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (allowed.IndexOf(words[i][j].ToString()) < 0)
                    {
                        isRight = false;
                    }
                }
                result += isRight ? 1 : 0;
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/find-common-characters/ 1002. 查找常用字符
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static IList<string> CommonChars(string[] A)
        {
            int[] minFreq = new int[26];
            for (int i = 0; i < 26; i++)
            {
                minFreq[i] = int.MaxValue;
            }
            foreach (var curr in A)
            {
                int[] freq = new int[26];
                for (int i = 0; i < curr.Length; i++)
                {
                    freq[curr[i] - 'a']++;
                }
                for (int i = 0; i < 26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], freq[i]);
                }
            }
            List<string> lisResult = new List<string>();
            for (int i = 0; i < minFreq.Length; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    lisResult.Add(((char)(i + 'a')).ToString());
                }
            }
            return lisResult;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/add-strings/   415. 字符串相加
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string AddStrings(string num1, string num2)
        {
            int sum = 0, index = 0;
            for (int i = num1[num1.Length - 1]; i >= 0; i--)
            {
                sum += (num1[i] - '0') * (int)Math.Pow(10, index++);
            }
            for (int i = num2[num2.Length - 1]; i >= 0; i--)
            {
                sum += (num2[i] - '0') * (int)Math.Pow(10, index++);
            }
            return sum.ToString();
        }

        /// <summary>
        /// 876. 链表的中间结点  https://leetcode-cn.com/problems/middle-of-the-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode MiddleNode(ListNode head)
        {

            //leetcode双指针题目大总结 https://leetcode-cn.com/circle/article/2b43gv/
            //快慢指针
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;


            //int count = 0;
            //ListNode temp = head;
            //while (temp!=null)
            //{
            //    count++;
            //    temp = temp.next;
            //}
            //for (int i = 0; i < count/2; i++)
            //{
            //    head = head.next;
            //}
            //return head;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/compress-string-lcci/ 面试题 01.06. 字符串压缩
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string CompressString(string S)
        {
            if (string.IsNullOrEmpty(S)) return "";
            if (S.Length < 2) return S;

            string strResult = "";
            int countNum = 1;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == S[i - 1])
                {
                    countNum++;
                    if (i == S.Length - 1)
                    {
                        strResult += S[i - 1] + countNum.ToString();
                    }

                }
                else
                {
                    strResult += S[i - 1] + countNum.ToString();
                    countNum = 1;
                    if (i == S.Length - 1)
                    {
                        strResult += S[i] + countNum.ToString();
                    }
                }
            }
            return strResult.Length >= S.Length ? S : strResult;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/relative-sort-array/  680. 验证回文字符串 Ⅱ
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static bool CanPermutePalindrome(string s)
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                {
                    set.Remove(s[i]);
                }
                else
                {
                    set.Add(s[i]);
                }
            }
            return set.Count <= 1;
        }


        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/length-of-last-word/ 58. 最后一个单词的长度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (s.Length < 1) return 0;

            string[] arr = s.Trim().Split(' ');
            return arr[arr.Length - 1].Length;

        }

        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                digits[i] = digits[i] % 10;
                if (digits[i] != 0) return digits;
            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;



            //int curr = 0;
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    curr = curr * 10 + digits[i];
            //}
            //var test = int.MaxValue;
            //curr++;
            //int result = curr;
            //int[] resultArr = new int[curr.ToString().Length];
            //for (int i = 0; i < resultArr.Length; i++)
            //{
            //    resultArr[i] = result / (int)Math.Pow(10, resultArr.Length- i-1);
            //    result = result - resultArr[i]* (int)Math.Pow(10, resultArr.Length - i - 1);
            //}
            //return resultArr;

        }
        /// <summary>
        /// 1. 两数之和 https://leetcode-cn.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
        public static int MaximumWealth(int[][] accounts)
        {
            int max = -1;
            for (int i = 0; i < accounts.Length; i++)
            {
                int currSum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currSum += accounts[i][j];
                }
                max = max > currSum ? max : currSum;
            }
            return max;
        }


        public static int CountSegments(string s)
        {
            return s.Trim().Split(' ').Length;
            //s = s.Trim();
            //if (s.Length == 0) return 0;

            //int result = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]==' ')
            //    {
            //        if (i-1>=0)
            //        {
            //            char lastChar2 = (char)(s[i - 1].ToString().ToLower()[0]);
            //            if (lastChar2 != ' ')
            //            {
            //                result++;
            //            }
            //        }

            //    }
            //}
            //return result+1;
        }



        /// <summary>
        /// 541. 反转字符串 II https://leetcode-cn.com/problems/reverse-string-ii/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string ReverseStr(string s, int k)
        {
            //char[] arr = s.ToArray();
            //for (int start = 0; start < arr.Length; start += 2 * k)
            //{
            //    int i = start, j = Math.Min(arr.Length - 1, start + k - 1);
            //    while (i < j)
            //    {
            //        char temp = arr[i];
            //        arr[i++] = arr[j];
            //        arr[j--] = temp;
            //    }
            //}
            char[] arr = s.ToArray();
            for (int i = 0; i < s.Length; i += 2 * k)
            {
                int left = i, right = Math.Min(s.Length - 1, i + k - 1);
                while (left < right)
                {

                    arr[left] = s[right];
                    arr[right] = s[left];
                    left++;
                    right--;
                }
            }
            return new String(arr);
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/reverse-integer/ 7. 整数反转
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            int newNum = 0;

            while (x != 0)
            {

                int curr = x % 10;

                if (newNum > int.MaxValue / 10 || (newNum == int.MaxValue && curr == 7)) return 0;
                if (newNum < int.MinValue / 10 || (newNum == int.MinValue && curr == -8)) return 0;

                newNum *= 10;
                newNum += curr;
                x /= 10;
            }
            return newNum;
        }



        /// <summary>
        /// https://leetcode-cn.com/problems/rotated-digits/ 788. 旋转数字
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int RotatedDigits(int N)
        {
            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                int curr = i;
                bool isGood = false; ;
                while (curr > 0)
                {
                    int temp = curr % 10;
                    if (!(temp == 2 || temp == 5 || temp == 6 || temp == 9))
                    {
                        if (temp == 3 || temp == 4 || temp == 7)
                        {
                            isGood = false;
                            break;
                        }
                    }
                    else
                    {
                        isGood = true;
                    }
                    curr /= 10;
                }
                result += isGood ? 1 : 0;
            }
            return result;
        }
        /// <summary>
        ///https://leetcode-cn.com/problems/remove-palindromic-subsequences/  1332. 删除回文子序列
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RemovePalindromeSub(string s)
        {
            if (s.Length == 0) return 0;

            int left = 0, right = s.Length - 1, result = 0;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return 2;
                }
                left++;
                right--;
            }
            return 1;
        }


        /// <summary>
        /// 1624. 两个相同字符之间的最长子字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxLengthBetweenEqualCharacters(string s)
        {
            int[] arr = new int[26];
            int max = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                int curr = s[i] - 'a';
                if (arr[curr] == -1)
                {
                    arr[curr] = i;
                }
                else
                {
                    max = Math.Max(i - arr[curr] - 1, max);
                }
            }
            return max;
            //int result=-1;
            //for (int i = 0; i < 26; i++)
            //{
            //    char currChar =(char) ('a' + i);
            //    if (s.IndexOf(currChar)!=s.LastIndexOf(currChar))
            //    {
            //        result = Math.Max(result, s.LastIndexOf(currChar)-s.IndexOf(currChar)-1 );
            //    }
            //}
            //return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/student-attendance-record-i/ 551. 学生出勤记录 I
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckRecord(string s)
        {
            int aCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    aCount++;
                }
                if (i < s.Length - 2 && s[i] == 'L' && s[i + 1] == 'L' && s[i + 2] == 'L')
                {
                    return false;
                }
            }
            return aCount <= 1;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/count-and-say/ 38. 外观数列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string CountAndSay(int n)
        {
            if (n == 1) return "1";
            if (n == 2) return "11";

            string lastString = "11";

            for (int i = 3; i <= n; i++)
            {
                int count = 1;
                string newString = "";
                for (int j = 0; j < lastString.Length - 1; j++)
                {
                    if (lastString[j] != lastString[j + 1])
                    {
                        newString += count.ToString() + lastString[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                newString += count.ToString() + lastString[lastString.Length - 1];
                lastString = newString;
            }
            return lastString;
        }
        /// <summary>
        /// 409. 最长回文串 https://leetcode-cn.com/problems/longest-palindrome/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int longestPalindrome(String s)
        {
            int[] cnt = new int[58];
            foreach (char c in s.ToArray())
            {
                cnt[c - 'A'] += 1;
            }

            int ans = 0;
            foreach (int x in cnt)
            {
                // 字符出现的次数最多用偶数次。
                ans += x - (x & 1);
            }
            // 如果最终的长度小于原字符串的长度，说明里面某个字符出现了奇数次，那么那个字符可以放在回文串的中间，所以额外再加一。
            return ans < s.Length ? ans + 1 : ans;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/complement-of-base-10-integer/  1009. 十进制整数的反码
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int BitwiseComplement(int N)
        {
            if (N == 0) return 1;

            int i = 0, result = 0;
            while (N != 0)
            {

                int curr = (N & 1) == 1 ? 0 : 1;
                result += curr << i;
                i++;
                N = N >> 1;
            }
            return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/max-consecutive-ones/ 485. 最大连续1的个数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0, curr = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = Math.Max(result, curr);
                if (nums[i] == 1)
                {
                    curr++;
                }
                else
                {
                    curr = 0;
                }

            }
            return Math.Max(result, curr);
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/thousand-separator/ 1556. 千位分隔数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static string ThousandSeparator(int n)
        {
            string strTemp = n.ToString(), strResult = "";
            int count = 0;
            for (int i = strTemp.Length - 1; i >= 0; i--)
            {

                if (count != 0 && (count + 1) % 3 == 0)
                {
                    strResult += strTemp[i] + ".";
                }
                else
                {
                    strResult += strTemp[i];
                }
                count++;
            }
            string strResult2 = "";
            for (int i = strResult.Length - 1; i >= 0; i--)
            {
                strResult2 += strResult[i];
            }
            return strResult2.TrimStart('.');
        }
        /// <summary>
        ///https://leetcode-cn.com/problems/goat-latin/824. 山羊拉丁文
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static string ToGoatLatin(string S)
        {
            string[] sArr = S.Split(' ');
            //HashSet<char> yuanSet = new HashSet<char>();
            //yuanSet.Add('a');
            //yuanSet.Add('o');
            //yuanSet.Add('i');
            //yuanSet.Add('e');
            //yuanSet.Add('u');


            string resultStr = "", endStrA = "", yuanStr = "aeiou";
            for (int i = 0; i < sArr.Length; i++)
            {
                endStrA += "a";
                //if (yuanSet.Contains(sArr[i].ToLower()[0]))
                if (yuanStr.IndexOf(sArr[i].ToLower()[0]) > -1)
                {
                    resultStr += sArr[i];
                }
                else
                {
                    resultStr += sArr[i].Substring(1, sArr[i].Length - 1) + sArr[i][0];
                }
                resultStr += "ma" + endStrA + " ";
            }
            return resultStr.TrimEnd();

        }

        /// <summary>
        /// 剑指 Offer 50. 第一个只出现一次的字符  https://leetcode-cn.com/problems/di-yi-ge-zhi-chu-xian-yi-ci-de-zi-fu-lcof/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char FirstUniqChar(string s)
        {
            int[] arr = new int[26];
            char[] arrS = s.ToArray();
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
            }

            for (int i = 0; i < arrS.Length; i++)
            {
                if (arr[arrS[i] - 'a'] == 1)
                {
                    return arrS[i];
                }
            }
            return ' ';
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!dic.Keys.Contains(s[i]))
            //    {
            //        dic.Add(s[i],1);
            //    }
            //    else
            //    {
            //        dic[s[i]]++;
            //    }
            //}
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key]==1)
            //    {
            //        return key;
            //    }
            //}
            //return ' ';
        }
        /// <summary>
        /// 748. 最短补全词 https://leetcode-cn.com/problems/shortest-completing-word/
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            licensePlate = licensePlate.ToLower();
            string newStr = "";
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if ((licensePlate[i] - 'a' >= 0 && licensePlate[i] - 'z' <= 0) || (licensePlate[i] - 'A' >= 0 && licensePlate[i] - 'Z' <= 0))
                {
                    newStr += licensePlate[i];
                }
            }
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            for (int i = 0; i < newStr.Length; i++)
            {
                if (!dic1.ContainsKey(newStr[i]))
                {
                    dic1.Add(newStr[i], 1);
                }
                else
                {
                    dic1[newStr[i]]++;
                }
            }

            string strResult = "";
            for (int i = 0; i < words.Length; i++)
            {
                Dictionary<char, int> dic2 = new Dictionary<char, int>();

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!dic2.ContainsKey(words[i][j]))
                    {
                        dic2.Add(words[i][j], 1);
                    }
                    else
                    {
                        dic2[words[i][j]]++;
                    }
                }

                bool isTrue = true;
                foreach (var key in dic1.Keys)
                {
                    if (!dic2.ContainsKey(key))
                    {
                        isTrue = false;
                        break;
                    }
                    if (dic2[key] < dic1[key])
                    {
                        isTrue = false;
                        break;
                    }

                }
                if (isTrue)
                {
                    if (strResult == "")
                    {
                        strResult = words[i];
                    }
                    else
                    {
                        strResult = strResult.Length > words[i].Length ? words[i] : strResult;
                    }
                }
            }
            return strResult;
        }
        /// <summary>
        /// 1446. 连续字符 https://leetcode-cn.com/problems/consecutive-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxPower(string s)
        {
            int result = 1, curr = 1;
            if (s.Length < 2)
            {
                return result;
            }
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    curr++;
                }
                else
                {
                    curr = 1;
                }
                result = Math.Max(result, curr);
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/reverse-only-letters/ 917. 仅仅反转字母
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string ReverseOnlyLetters(string S)
        {
            int left = 0, right = S.Length - 1;
            char[] newStringChar = new char[S.Length];
            while (left < right)
            {
                while (left < right && !((S[left] >= 'a' && S[left] <= 'z') || (S[left] >= 'A' && S[left] <= 'Z')))
                {
                    newStringChar[left] = S[left];
                    left++;
                }
                while (left < right && !((S[right] >= 'a' && S[right] <= 'z') || (S[right] >= 'A' && S[right] <= 'Z')))
                {
                    newStringChar[right] = S[right];
                    right--;
                }
                if (left < right)
                {
                    newStringChar[left] = S[right];
                    newStringChar[right] = S[left];
                    left++;
                    right--;
                }
            }
            if (left == right)
            {
                newStringChar[left] = S[left];
            }
            return new String(newStringChar);
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/detect-capital/ 520. 检测大写字母
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool DetectCapitalUse(string word)
        {
            List<int> lis = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] - 'A' >= 0 && word[i] <= 'Z')
                {
                    lis.Add(i);
                }
            }
            if ((lis.Count == 1 && lis[0] == 0) || lis.Count == 0 || lis.Count == word.Length)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 976. 三角形的最大周长 https://leetcode-cn.com/problems/largest-perimeter-triangle/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int LargestPerimeter(int[] A)
        {
            Array.Sort(A);
            for (int i = A.Length - 1; i >= 2; i--)
            {
                if (A[i - 1] + A[i - 2] > A[i])
                {
                    return A[i] + A[i - 1] + A[i - 2];
                }
            }
            return -1;
        }

        /// <summary>
        ///https://leetcode-cn.com/problems/count-largest-group/ 1399. 统计最大组的数目
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountLargestGroup(int n)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int currSum = 0, currNum = i;
                while (currNum > 0)
                {
                    currSum += currNum % 10;
                    currNum /= 10;
                }
                if (!dic.Keys.Contains(currSum))
                {
                    dic.Add(currSum, 1);
                }
                else
                {
                    dic[currSum]++;
                }
                max = Math.Max(dic[currSum], max);
            }
            int result = 0;
            foreach (var key in dic.Keys)
            {
                if (dic[key] == max)
                    result++;
            }
            return result;

        }

        /// <summary>
        /// https://leetcode-cn.com/problems/find-the-duplicate-number/  287. 寻找重复数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindDuplicate(int[] nums)
        {
            int left = 1, right = nums.Length - 1, result = -1;
            while (left <= right)
            {
                int middle = (left + right) / 2, count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= middle)
                        count++;
                }
                if (count > middle)
                {
                    right = middle;
                    result = right;

                }
                else
                {
                    left = middle + 1;
                }
            }
            return right;


            //HashSet<int> set = new HashSet<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!set.Contains(nums[i]))
            //    {
            //        set.Add(nums[i]);
            //    }
            //    else
            //    {
            //        return nums[i];
            //    }
            //}
            //return -1;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/he-wei-sde-liang-ge-shu-zi-lcof/  剑指 Offer 57. 和为s的两个数字
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] twoSum(int[] nums, int target)
        {
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int left = i + 1, right = nums.Length - 1;
            //    while (left <= right)
            //    {
            //        int middle = (left + right) / 2;
            //        if (nums[middle] == target - nums[i])
            //        {
            //            return new int[] { nums[i], nums[middle] };
            //        }
            //        else if (nums[middle] > target - nums[i])
            //        {
            //            right = middle - 1;
            //        }
            //        else
            //        {
            //            left = middle + 1;
            //        }
            //    }
            //}
            //return new int[] { };
            //int left = 0, right = nums.Length - 1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    left = i + 1;
            //    right = nums.Length - 1;
            //    while (left <=right)
            //    {
            //        int middle = (left + right) / 2;
            //        if (nums[middle] == target - nums[i])
            //        {
            //            return new int[] { nums[i], nums[middle] };
            //        }
            //        else if (nums[middle] > target - nums[i])
            //        {
            //            right = middle - 1;
            //        }
            //        else
            //        {
            //            left = middle + 1;
            //        }
            //    }
            //}
            //return new int[] { };

            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] == target)
                {
                    return new int[] { nums[left], nums[right] };
                }
                else if (nums[left] + nums[right] > target)
                {
                    --right;
                }
                else
                {
                    ++left;
                }
            }
            return new int[] { };
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/string-matching-in-an-array/ 1408. 数组中的字符串匹配
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IList<string> StringMatching(string[] words)
        {
            IList<string> resultLis = new List<string>();
            if (words == null || words.Length < 2) return resultLis;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] != words[j] && words[j].Length < words[i].Length)
                    {
                        if (words[i].IndexOf(words[j]) >= 0)
                        {
                            if (!resultLis.Contains(words[j]))
                            {
                                resultLis.Add(words[j]);
                            }
                        }
                    }
                }
            }
            return resultLis;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/find-all-numbers-disappeared-in-an-array/  448. 找到所有数组中消失的数字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = Math.Abs(nums[i]) - 1;
                if (nums[newIndex] > 0)
                {
                    nums[newIndex] *= -1;
                }
            }
            List<int> result = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {

                if (nums[i - 1] > 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        /// <summary>
        /// 999. 可以被一步捕获的棋子数 https://leetcode-cn.com/problems/available-captures-for-rook/
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public static int NumRookCaptures(char[][] board)
        {
            int rookRowIndex = 0, rookColIndex = 0, result = 0;
            bool findRook = false;
            int[] dx = new int[] { 0, 1, 0, -1 };
            int[] dy = new int[] { 1, 0, -1, 0 };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        rookRowIndex = i;
                        rookColIndex = j;
                        findRook = true;
                        break;
                    }
                }
                if (findRook)
                {
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int step = 0; ; step++)
                {
                    int currX = rookRowIndex + step * dx[i];
                    int currY = rookColIndex + step * dy[i];
                    if (currX < 0 || currX >= 8 || currY < 0 || currY >= 8 || board[currX][currY] == 'B')
                    {
                        break;
                    }
                    if (board[currX][currY] == 'B')
                    {
                        result++;
                        break;
                    }
                }
            }
            return result;


        }
        /// <summary>
        /// 1491. 去掉最低工资和最高工资后的工资平均值 https://leetcode-cn.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public static double Average(int[] salary)
        {
            int minVal = int.MaxValue, maxVal = int.MinValue;
            double totalNum = 0;
            for (int i = 0; i < salary.Length; i++)
            {
                minVal = Math.Min(salary[i], minVal);
                maxVal = Math.Max(salary[i], maxVal);
                totalNum += salary[i];
            }
            return (double)(totalNum - minVal - maxVal) / (salary.Length - 2);
        }

        /// <summary>
        /// 908. 最小差值 I https://leetcode-cn.com/problems/smallest-range-i/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int SmallestRangeI(int[] A, int K)
        {
            int minVal = int.MaxValue, maxVal = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                minVal = Math.Min(A[i], minVal);
                maxVal = Math.Max(A[i], maxVal);
            }
            return (maxVal - minVal) > 2 * K ? maxVal - minVal - 2 * K : 0;
        }



        /// <summary>
        /// 面试题 10.05. 稀疏数组搜索  https://leetcode-cn.com/problems/sparse-array-search-lcci/
        /// </summary>
        /// <param name="words"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FindString(string[] words, string s)
        {

            //二分
            int left = 0, right = words.Length - 1;
            while (left <= right)
            {
                if (words[left].Length == 0)
                {
                    left++;
                    continue;
                }
                if (words[right].Length == 0)
                {
                    right--;
                    continue;
                }
                int mid = (right + left) / 2;
                while (words[mid].Length == 0)
                {
                    mid++;
                    if (mid == right)
                    {
                        right = (right + left) / 2;
                        continue;
                    }
                }

                if (words[mid] == s)
                    return mid;
                else if (string.Compare(words[mid], s) > 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i]==s)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }
        /// <summary>
        /// 1413. 逐步求和得到正数的最小值 https://leetcode-cn.com/problems/minimum-value-to-get-positive-step-by-step-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinStartValue(int[] nums)
        {
            int minVal = int.MaxValue, currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currSum = currSum + nums[i];
                if (minVal > currSum)
                {
                    minVal = currSum;
                }
            }
            return 1 - minVal;
            //int minVal = 0;
            //bool notFinish = true;
            //while (notFinish)
            //{
            //    int currSum = minVal;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        currSum = nums[i] + currSum;
            //        if (currSum < 1)
            //        {
            //            minVal++;
            //            notFinish = true;
            //            break;
            //        }
            //        notFinish = false;
            //    }

            //}

            //return minVal<1?1:minVal;
        }

        /// <summary>
        /// 1200. 最小绝对差  https://leetcode-cn.com/problems/minimum-absolute-difference/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> resultLis = new List<IList<int>>();
            if (arr == null || arr.Length <= 1) return resultLis;

            Array.Sort(arr);
            int minVal = int.MaxValue;
            //HashSet<int> set = new HashSet<int>();
            //set.Add(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                //set.Add(arr[i]);
                minVal = minVal > arr[i] - arr[i - 1] ? arr[i] - arr[i - 1] : minVal;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                //if (set.Contains(arr[i]+minVal))
                //{
                //    resultLis.Add(new List<int> { arr[i],arr[i]+minVal});
                //}
                if (arr[i] - arr[i - 1] == minVal)
                {
                    resultLis.Add(new List<int> { arr[i], arr[i - 1] });
                }
            }
            return resultLis;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/sort-array-by-parity-ii/  922. 按奇偶排序数组 II
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortArrayByParityII(int[] A)
        {
            int ou = 0, qi = 1;
            while (ou < A.Length)
            {
                while (qi < A.Length && A[qi] % 2 != 0)
                {
                    qi += 2;
                }
                while (ou < A.Length && A[ou] % 2 == 0)
                {
                    ou += 2;
                }
                if (qi < A.Length && ou < A.Length && A[qi] % 2 == 0 && A[ou] % 2 != 0)
                {
                    int temp = A[qi];
                    A[qi] = A[ou];
                    A[ou] = temp;
                }
            }
            return A;
        }
        //面试题 01.02. 判定是否互为字符重排 https://leetcode-cn.com/problems/check-permutation-lcci/
        public static bool CheckPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!dic.Keys.Contains(s1[i]))
                {
                    dic.Add(s1[i], 1);
                }
                else
                {
                    dic[s1[i]]++;
                }
            }
            Dictionary<int, int> dic2 = new Dictionary<int, int>();
            for (int i = 0; i < s2.Length; i++)
            {
                if (!dic2.Keys.Contains(s2[i]))
                {
                    dic2.Add(s2[i], 1);
                }
                else
                {
                    dic2[s1[i]]++;
                }
            }
            foreach (var key in dic.Keys)
            {
                if (!dic2.Keys.Contains(key))
                {
                    return false;
                }
                if (dic2[key] != dic[key])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/shortest-distance-to-a-character/ 821. 字符的最短距离
        /// </summary>
        /// <param name="S"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static int[] ShortestToChar(string S, char C)
        {
            int[] result = new int[S.Length];
            int pre = int.MinValue / 2;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                    pre = i;
                result[i] = i - pre;
            }
            pre = int.MaxValue / 2;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == C)
                    pre = i;
                result[i] = Math.Min(pre - i, result[i]);
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/add-digits/ 258. 各位相加
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int AddDigits(int num)
        {
            while (num >= 10)
            {
                int newNum = 0;
                while (num > 0)
                {
                    newNum += num % 10;
                    num /= 10;
                }
                num = newNum;
            }

            return num;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/distribute-candies/  575. 分糖果
        /// </summary>
        /// <param name="candies"></param>
        /// <returns></returns>
        public static int DistributeCandies(int[] candies)
        {
            if (candies == null || candies.Length == 0) return -1;

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (!set.Contains(candies[i]))
                    set.Add(candies[i]);
            }
            if (set.Count < candies.Length / 2)
            {
                return set.Count;
            }
            else
            {
                return candies.Length / 2;
            }
        }
        /// <summary>
        /// 剑指 Offer 63. 股票的最大利润  https://leetcode-cn.com/problems/gu-piao-de-zui-da-li-run-lcof/
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit20201026(int[] prices)
        {
            //动态规划
            if (prices.Length == 0)
            {
                return 0;
            }
            int[][] dp = new int[2002][];
            dp[0] = new int[2];
            dp[0][0] = 0;
            dp[0][1] = -prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                dp[i] = new int[2];
                dp[i][0] = Math.Max(dp[i - 1][0], dp[i - 1][1] + prices[i]);
                dp[i][1] = Math.Max(dp[i - 1][1], 0 - prices[i]);
            }
            return dp[prices.Length - 1][0];

            //暴力
            //if (prices == null || prices.Length == 1) return 0;

            //int min = int.MaxValue, max = int.MinValue,result=0;
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    if (min>prices[i])
            //    {
            //        min = prices[i];
            //        max = int.MinValue;
            //    }
            //    else if (prices[i]>max)
            //    {
            //        max = prices[i];
            //    }
            //    result = (max > 0 && max - min > result) ? max - min : result;
            //}
            //return result;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/  714. 买卖股票的最佳时机含手续费
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="fee"></param>
        /// <returns></returns>
        public static int MaxProfit20201023(int[] prices, int fee)
        {
            if (prices == null || prices.Length == 0) return 0;

            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] - fee > 0)
                    {
                        max += prices[j] - prices[i] - fee;
                        i = j;
                        break;
                    }
                }

            }
            return max;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/score-after-flipping-matrix/  861. 翻转矩阵后的得分
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MatrixScore(int[][] A)
        {
            int R = A.Length, C = A[0].Length;
            int ans = 0;
            for (int c = 0; c < C; ++c)
            {
                int col = 0;
                for (int r = 0; r < R; ++r)
                    col += A[r][c] ^ A[r][0];
                ans += Math.Max(col, R - col) * (1 << (C - 1 - c));
            }
            return ans;

            //if (A == null || A.Length == 0) return 0;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i][0]==0)
            //    {
            //        for (int j = 0; j < A[i].Length; j++)
            //        {
            //            A[i][j] = A[i][j] == 1 ? 0 : 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < A[0].Length; i++)
            //{
            //    if (A[0][i]==0)
            //    {
            //        for (int j   = 0; j < A.Length; j++)
            //        {
            //            A[j][i] = A[j][i] == 1 ? 0 : 1;
            //        }
            //    }
            //}
            //int result = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int currNum = 0;
            //    for (int j = 0; j < A[i].Length; j++)
            //    {
            //        currNum =((currNum<<1)+ A[i][j]);
            //    }
            //    result += currNum;
            //}
            //return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/partition-labels/  763. 划分字母区间
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static IList<int> PartitionLabels(string S)
        {
            IList<int> resultLis = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                int currLeft = S.IndexOf(S[i]), currRight = S.LastIndexOf(S[i]);
                for (int j = currLeft; j < currRight; j++)
                {
                    if (S.LastIndexOf(S[j]) > currRight)
                    {
                        currRight = S.LastIndexOf(S[j]);
                    }
                }
                resultLis.Add(currRight - i + 1);
                i = currRight;
            }
            return resultLis;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/group-the-people-given-the-group-size-they-belong-to/ 1282. 用户分组
        /// </summary>
        /// <param name="groupSizes"></param> 
        /// <returns></returns>
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (!dic.Keys.Contains(groupSizes[i]))
                {
                    dic.Add(groupSizes[i], new List<int>() { i });
                }
                else
                {
                    dic[groupSizes[i]].Add(i);
                }
            }
            IList<IList<int>> resultLis = new List<IList<int>>();
            foreach (var key in dic.Keys)
            {
                //List<int> currLis = new List<int>();
                //for (int j = 0; j < dic[key].Count; j++)
                //{
                //    currLis.Add(dic[key][j]);
                //}
                //resultLis.Add(currLis);
                int i = 0;
                while (i < dic[key].Count)
                {
                    List<int> currLis = new List<int>();
                    for (int j = 0; j < key; j++)
                    {
                        currLis.Add(dic[key][i + j]);

                    }
                    i += key;
                    resultLis.Add(currLis);
                }
            }
            return resultLis;
        }
        /// <summary>
        ///https://leetcode-cn.com/problems/delete-columns-to-make-sorted/ 944. 删列造序
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinDeletionSize(string[] A)
        {
            if (A[0].Length == 1) return 0;

            int result = 0;
            for (int i = 0; i < A[0].Length; i++)
            {
                char preChar = 'a';
                bool isDecleaseCol = true;
                //for (int j = 0; j < A.Length; j++)
                //{
                //    if (preChar> A[j][i])
                //    {
                //        result++;
                //        break;
                //    }
                //    //preChar = A[j][i];
                //}
                for (int j = 0; j < A.Length; j++)
                {
                    //if (A[j][i]>A[j+1][i])
                    if (preChar > A[j][i])
                    {
                        result++;
                        break;
                    }
                    preChar = A[j][i];
                }
                //result = isDecleaseCol ? result + 1 : result;
            }
            //return result==A[0].Length?1: A[0].Length- result;
            return result;
        }
        public static int FindSpecialInteger(int[] arr)
        {
            if (arr == null || arr.Length == 0) return -1;
            if (arr.Length == 1) return arr[0];

            Array.Sort(arr);
            double times = 0;
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (temp != arr[i])
                {
                    times = 0;
                    temp = arr[i];
                }
                times++;

                if (0.25 < times / (double)arr.Length)
                {
                    return arr[i];
                }
            }
            return 0;
        }
        public static bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();
            while (n != 1 && !set.Contains(n))
            {

                set.Add(n);
                int sum = 0;
                if (n >= 10)
                {
                    while (n > 0)
                    {
                        int curr = n % 10;
                        sum += curr * curr;
                        n = n / 10;
                    }
                }
                else
                {
                    sum = n * n;
                }
                n = sum;

            }
            return set.Contains(n) ? false : true;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/all-paths-from-source-to-target/ 797. 所有可能的路径
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> resultLis = new List<IList<int>>();
            if (graph == null || graph.Length == 0) return resultLis;

            LinkedList<int> queue = new LinkedList<int>();
            for (int i = 0; i < graph[0].Length; i++)
            {
                List<int> pathList = new List<int>();
                pathList.Add(0);
                queue.AddLast(graph[0][i]);
                while (queue.Count > 0)
                {
                    int curr = queue.First();
                    queue.RemoveFirst();
                    pathList.Add(curr);

                    if (graph[curr] != null && graph[curr].Length != 0)
                    {
                        for (int j = 0; j < graph[curr].Length; j++)
                        {
                            queue.AddLast(graph[curr][j]);
                        }
                    }

                }
                resultLis.Add(pathList);
            }
            return resultLis;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/island-perimeter/  463. 岛屿的周长
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int IslandPerimeter(int[][] grid)
        {
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        result += 4;
                        if ((i - 1) > -1 && grid[i - 1][j] == 1)
                            result -= 1;
                        if ((i + 1) < grid.Length && grid[i + 1][j] == 1)
                            result -= 1;
                        if ((j - 1) > -1 && grid[i][j - 1] == 1)
                            result -= 1;
                        if ((j + 1) < grid[i].Length && grid[i][j + 1] == 1)
                            result -= 1;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/compare-strings-by-frequency-of-the-smallest-character/  1170. 比较字符串最小字母出现频次
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] wordSmallerIndex = new int[11];
            for (int i = 0; i < words.Length; i++)
            {
                int curr = GetNumSmallerByFrequency(words[i]);
                wordSmallerIndex[curr]++;
            }
            for (int i = 9; i > -1; i--)
            {
                wordSmallerIndex[i] += wordSmallerIndex[i + 1];
            }
            int[] resultArr = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int curr = GetNumSmallerByFrequency(queries[i]);


                resultArr[i] = (curr + 1) < 10 ? wordSmallerIndex[curr + 1] : 0;
            }
            return resultArr;

            //int[] wordSmallerIndex = new int[words.Length]; ;
            //for (int i = 0; i < words.Length; i++)
            //{
            //    int curr=GetNumSmallerByFrequency(words[i]);
            //    //wordSmallerIndex[curr]++;
            //    wordSmallerIndex[i] = curr;
            //}
            //int[] resultArr = new int[queries.Length];
            //for (int i = 0; i < queries.Length; i++)
            //{
            //    int curr=GetNumSmallerByFrequency(queries[i]);
            //    //resultArr[i] = wordSmallerIndex[curr];
            //    int currResult = 0;
            //    for (int j = 0; j < wordSmallerIndex.Length; j++)
            //    {
            //        if (wordSmallerIndex[j]> curr)
            //        {
            //            currResult++;
            //        }
            //    }
            //    resultArr[i] = currResult;
            //}
            //return resultArr;
        }

        public static int GetNumSmallerByFrequency(string queries)
        {
            if (string.IsNullOrEmpty(queries)) return 0;

            int result = 1;
            char[] arr = queries.ToCharArray();
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[0])
                    result++;
                else
                    break;

            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/roman-to-integer/ 13. 罗马数字转整数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i + 1 < s.Length && (s[i + 1] == 'V' || (s[i + 1] == 'X')))
                            result += -1;
                        else
                            result += 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (i + 1 < s.Length && (s[i + 1] == 'L' || (s[i + 1] == 'C')))
                            result += -10;
                        else
                            result += 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (i + 1 < s.Length && (s[i + 1] == 'D' || (s[i + 1] == 'M')))
                            result += -100;
                        else
                            result += 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/valid-anagram/    242. 有效的字母异位词
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> set = new Dictionary<char, int>(), set2 = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Keys.Contains(s[i]))
                {
                    set.Add(s[i], 1);
                }
                else
                {
                    set[s[i]]++;
                }
                if (!set2.Keys.Contains(t[i]))
                {
                    set2.Add(t[i], 1);
                }
                else
                {
                    set2[t[i]]++;
                }
            }
            foreach (var key in set.Keys)
            {
                if (!set2.Keys.Contains(key)) return false;

                if (set2[key] != set[key]) return false;
            }
            return true;


        }

        /// <summary>
        /// https://leetcode-cn.com/problems/pascals-triangle-ii/  119. 杨辉三角 II
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static IList<int> GetRow(int rowIndex)
        {
            IList<int> preLis = new List<int>(), resultLis = new List<int>();
            if (rowIndex < 0) return resultLis;
            if (rowIndex == 0) return new List<int>() { 1 };

            preLis = new List<int> { 1 };
            for (int i = 1; i <= rowIndex; i++)
            {
                int[] currArr = new int[preLis.Count + 1];
                for (int j = 0; j <= (preLis.Count + 1) / 2; j++)
                {
                    //int left = j - 1 >= 0 ? lastLis[j - 1] : 0;
                    //int right = j < lastLis.Count ? lastLis[j] : 0;
                    currArr[j] = (j - 1 >= 0 ? preLis[j - 1] : 0) + (j < preLis.Count ? preLis[j] : 0);
                    currArr[preLis.Count - j] = currArr[j];
                }
                resultLis = currArr.ToList();
                if (i - 1 == rowIndex)
                {
                    return resultLis;
                }
                preLis = resultLis;
            }

            return resultLis;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/crawler-log-folder/  1598. 文件夹操作日志搜集器
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public static int MinOperations(string[] logs)
        {
            int result = 0;
            for (int i = 0; i < logs.Length; i++)
            {
                switch (logs[i])
                {
                    case "../":
                        result = result > 0 ? --result : 0;
                        break;
                    case "./":
                        break;
                    default:
                        result++;
                        break;
                }
                //if (logs[i]=="../")
                //{
                //    result = result > 0 ? --result : 0;
                //}
                //else if (logs[i]!="./")
                //{
                //    result++;
                //}
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/occurrences-after-bigram/ 1078. Bigram 分词
        /// </summary>
        /// <param name="text"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static string[] FindOcurrences(string text, string first, string second)
        {
            string[] temp = text.Split(' ');
            List<string> lis = new List<string>();
            for (int i = 0; i < temp.Length - 2; i++)
            {
                if (temp[i] == first && temp[i + 1] == second)
                {
                    lis.Add(temp[i + 2]);
                }
            }
            return lis.ToArray();

            //string str12 = first + " " + second+" ";
            //List<string> lis = new List<string>();
            //while (text.IndexOf(str12)>-1)
            //{
            //    if (text.IndexOf(str12) > 0)
            //    {
            //        str12= " "+first + " " + second + " ";
            //    }
            //    else
            //    {
            //        str12 = first + " " + second + " ";
            //    }
            //    text = text.Substring(str12.Length+ text.IndexOf(str12), text.Length - text.IndexOf(str12)-str12.Length);
            //    string thirdStr = "";
            //    int i = 0;
            //    while (i<text.Length&&text[i]!=' ')
            //    {
            //        thirdStr += text[i];
            //        i++;
            //    }
            //    lis.Add(thirdStr);
            //    str12 = first + " " + second + " ";
            //}
            //return lis.ToArray();

        }
        /// <summary>
        ///https://leetcode-cn.com/problems/pascals-triangle/ 118. 杨辉三角
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> finalResult = new List<IList<int>>();
            if (numRows <= 0) return finalResult;

            finalResult.Add(new List<int> { 1 });
            for (int i = 1; i < numRows; i++)
            {
                int[] currArr = new int[finalResult[i - 1].Count + 1];
                for (int j = 0; j <= (finalResult[i - 1].Count + 1) / 2; j++)
                {
                    int left = j - 1 >= 0 ? finalResult[i - 1][j - 1] : 0;
                    int right = j < finalResult[i - 1].Count ? finalResult[i - 1][j] : 0;
                    currArr[j] = left + right;
                    currArr[finalResult[i - 1].Count - j] = currArr[j];
                }
                finalResult.Add(currArr.ToList());
                //List<int> currList = new List<int>();
                //for (int j = 0; j <=finalResult[i-1].Count; j++)
                //{
                //    int left = j - 1 >= 0 ? finalResult[i - 1][j-1] : 0;
                //    int right = j < finalResult[i - 1].Count ? finalResult[i - 1][j] : 0;
                //    currList.Add(left+right);
                //}
                //finalResult.Add(currList);
            }

            return finalResult;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/qi-wang-ge-shu-tong-ji/ LCP 11. 期望个数统计
        /// </summary>
        /// <param name="scores"></param>
        /// <returns></returns>
        public static int ExpectNumber(int[] scores)
        {
            Array.Sort(scores);
            int val = -1, result = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] != val)
                {
                    result++;
                    val = scores[i];
                }
            }
            return result;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (!dic.ContainsKey(scores[i]))
            //    {
            //        dic.Add(scores[i],1);
            //    }
            //    else
            //    {
            //        dic[scores[i]]++;
            //    }
            //}
            //int result = 0;
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key]>1)
            //    {
            //        result += dic[key] / 2;
            //    }
            //    else
            //    {
            //        result ++;
            //    }
            //}
            //return dic.Count;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/he-wei-sde-lian-xu-zheng-shu-xu-lie-lcof/ 剑指 Offer 57 - II. 和为s的连续正数序列
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[][] FindContinuousSequence(int target)
        {
            List<List<int>> lisResult = new List<List<int>>();
            for (int i = 1; i < target; i++)
            {
                List<int> tempLis = new List<int>();

                int currSum = i, currStart = i;
                while (currSum < target)
                {
                    tempLis.Add(currStart);
                    currSum += currStart + 1;
                    currStart++;
                }
                if (currSum == target)
                {
                    tempLis.Add(currStart);
                    lisResult.Add(tempLis);
                }
            }
            int[][] resultArr = new int[lisResult.Count][];
            for (int i = 0; i < lisResult.Count; i++)
            {
                resultArr[i] = new int[lisResult[i].Count];
                for (int j = 0; j < lisResult[i].Count; j++)
                {
                    resultArr[i][j] = lisResult[i][j];
                }
            }
            return resultArr;
        }
        /// <summary>
        ///https://leetcode-cn.com/problems/distribute-candies-to-people/ 1103. 分糖果 II  
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="num_people"></param>
        /// <returns></returns>
        public static int[] DistributeCandies(int candies, int num_people)
        {
            int[] peopleCandies = new int[num_people];
            int i = 0;
            while (candies != 0)
            {
                peopleCandies[i % num_people] += Math.Min(candies, i + 1);
                candies -= Math.Min(candies, i + 1);
                i++;
            }
            return peopleCandies;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/uncommon-words-from-two-sentences/    884. 两句话中的不常见单词
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static string[] UncommonFromSentences(string A, string B)
        {
            List<string> lisResult = new List<string>();
            Dictionary<string, int> dicA = new Dictionary<string, int>();
            string[] arrA = A.Split(' '), arrB = B.Split(' ');
            for (int i = 0; i < arrA.Length; i++)
            {
                if (!dicA.ContainsKey(arrA[i]))
                {
                    dicA.Add(arrA[i], 1);
                }
                else
                {
                    dicA[arrA[i]]++;
                }
            }
            for (int i = 0; i < arrB.Length; i++)
            {
                if (!dicA.ContainsKey(arrB[i]))
                {
                    dicA.Add(arrB[i], 1);
                }
                else
                {
                    dicA[arrB[i]]++;
                }
            }
            foreach (var key in dicA.Keys)
            {
                if (dicA[key] == 1)
                {
                    lisResult.Add(key);
                }
            }

            return lisResult.ToArray();
        }
        /// <summary>
        ///https://leetcode-cn.com/problems/maximum-number-of-balloons/ 1189. “气球” 的最大数量
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int MaxNumberOfBalloons(string text)
        {
            int[] word = new int[26];
            for (int i = 0; i < text.Length; i++)
            {
                word[text[i] - 'a']++;
            }
            word['l' - 'a'] /= 2;
            word['o' - 'a'] /= 2;
            string strTemp = "balon";
            int result = int.MaxValue;
            for (int i = 0; i < strTemp.Length; i++)
            {
                result = Math.Min(word[strTemp[i] - 'a'], result);
            }
            return result;
            //string strBallon = "ballon";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < strBallon.Length; i++)
            //{
            //    if (!dic.Keys.Contains(strBallon[i]))
            //    {
            //        dic.Add(strBallon[i],0);
            //    }
            //}
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (dic.Keys.Contains(text[i]))
            //    {
            //        dic[text[i]]++;
            //    }
            //}
            //dic['l'] /=2;
            //dic['o'] /= 2;
            //int result = int.MaxValue;
            //foreach (var key in dic.Keys)
            //{
            //        result = Math.Min(result, dic[key]);
            //}
            //return result;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/surface-area-of-3d-shapes/  892. 三维形体的表面积
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int SurfaceArea(int[][] grid)
        {
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    int boxNum = grid[i][j];
                    if (boxNum > 0)
                    {
                        result += boxNum * 4 + 2;
                        result -= i > 0 ? Math.Min(grid[i - 1][j], boxNum) * 2 : 0;
                        result -= j > 0 ? Math.Min(grid[i][j - 1], boxNum) * 2 : 0;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/ 1455. 检查单词是否为句中其他单词的前缀
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="searchWord"></param>
        /// <returns></returns>
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] arrStr = sentence.Split(' ');
            for (int i = 0; i < arrStr.Length; i++)
            {
                if (arrStr[i].IndexOf(searchWord) == 0)
                {
                    return i + 1;
                }
            }
            return -1;
        }
        /// <summary>
        ///https://leetcode-cn.com/problems/diao-zheng-shu-zu-shun-xu-shi-qi-shu-wei-yu-ou-shu-qian-mian-lcof/  剑指 Offer 21. 调整数组顺序使奇数位于偶数前面
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] Exchange(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new int[] { };

            int i = 0, j = nums.Length - 1;
            while (i < j)
            {
                while (i < j && nums[i] % 2 != 0)
                {
                    i++;
                }
                while (i < j && nums[j] % 2 == 0)
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j--;
                }

            }
            return nums;

            //List<int> lisOdd = new List<int>(),lisEven=new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //        lisEven.Add(nums[i]);
            //    else
            //        lisOdd.Add(nums[i]);
            //}
            //lisOdd.AddRange(lisEven);
            //return lisOdd.ToArray();

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/unique-email-addresses/ 929. 独特的电子邮件地址
        /// </summary>
        /// <param name="emails"></param>
        /// <returns></returns>
        public static int NumUniqueEmails(string[] emails)
        {
            //状态机
            HashSet<string> ans = new HashSet<string>();
            for (int i = 0; i < emails.Length; i++)
            {
                string temp = ""; int flag = 1;      //把每个字符串分成3种状态，初始为1，即遇到+号之前的状态
                for (int j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '+')       //遇到+号之后，temp不加任何元素
                        flag = 0;
                    if (emails[i][j] == '@')       //遇到@之后，temp加任何元素
                        flag = 2;
                    switch (flag)
                    {
                        case 1: if (emails[i][j] != '.') temp += emails[i][j]; break;
                        case 2: temp += emails[i][j]; break;
                        case 0: break;
                    }
                }
                ans.Add(temp);
            }
            return ans.Count;
            //HashSet<string> set = new HashSet<string>();
            //for (int i = 0; i < emails.Length; i++)
            //{
            //    int firstDot = emails[i].LastIndexOf('.'),preDot= emails[i].Substring(0, firstDot).IndexOf('.') , indexAt = emails[i].IndexOf('@'), indexPlus = emails[i].IndexOf('+');
            //    while (preDot > 0 && preDot < indexAt)
            //    {
            //        emails[i] = emails[i].Substring(0, preDot)+emails[i].Substring(preDot+1,emails[i].Length-preDot-1);
            //        if (firstDot<emails[i].Length)
            //        {
            //            preDot = emails[i].Substring(0, firstDot).IndexOf('.');
            //        }
            //        else
            //        {
            //            preDot = -1;
            //        }
            //        indexAt = emails[i].IndexOf('@');


            //    }

            //     if (indexPlus > 0)
            //    {
            //         indexPlus = emails[i].IndexOf('+');
            //        indexAt = emails[i].IndexOf('@');
            //        emails[i] = emails[i].Replace( emails[i].Substring(indexPlus,indexAt-indexPlus),"");
            //    }
            //    if (!set.Contains(emails[i]))
            //    {
            //        set.Add(emails[i]);
            //    }
            //}
            //return set.Count;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/merge-two-sorted-lists/  21. 合并两个有序链表
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            ListNode newHead = new ListNode(-1), curr = newHead;
            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    curr.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                curr = curr.next;
            }
            curr.next = l1 == null ? l2 : l1;
            return newHead.next;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/fizz-buzz/  412. Fizz Buzz
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<string> FizzBuzz(int n)
        {
            List<string> lisResult = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    lisResult.Add("FizzBuzz");
                else if (i % 3 == 0)
                    lisResult.Add("Fizz");
                else if (i % 5 == 0)
                    lisResult.Add("Buzz");
                else
                    lisResult.Add(i.ToString());
            }
            return lisResult;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/unique-number-of-occurrences/  1207. 独一无二的出现次数
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic.Keys.Contains(arr[i]))
                {
                    dic.Add(arr[i], 1);
                }
                else
                {
                    dic[arr[i]]++;

                }
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var key in dic.Keys)
            {
                if (set.Contains(dic[key]))
                {
                    return false;
                }
                else
                {
                    set.Add(dic[key]);
                }
            }
            return true;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/t9-lcci/  面试题 16.20. T9键盘
        /// </summary>
        /// <param name="num"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IList<string> GetValidT9Words(string num, string[] words)
        {
            List<string> lisResult = new List<string>();
            Dictionary<char, HashSet<char>> dic = new Dictionary<char, HashSet<char>>();
            //for (int i = 1; i < 10; i++)
            //{
            //    dic.Add(((char)i), new HashSet<char>());
            //}
            dic.Add('1', new HashSet<char>());
            dic.Add('2', new HashSet<char>());
            dic.Add('3', new HashSet<char>());
            dic.Add('4', new HashSet<char>());
            dic.Add('5', new HashSet<char>());
            dic.Add('6', new HashSet<char>());
            dic.Add('7', new HashSet<char>());
            dic.Add('8', new HashSet<char>());
            dic.Add('9', new HashSet<char>());

            dic['1'].Add('!');
            dic['1'].Add('@');
            dic['1'].Add('#');
            dic['2'].Add('a');
            dic['2'].Add('b');
            dic['2'].Add('c');
            dic['3'].Add('d');
            dic['3'].Add('e');
            dic['3'].Add('f');
            dic['4'].Add('g');
            dic['4'].Add('h');
            dic['4'].Add('i');
            dic['5'].Add('j');
            dic['5'].Add('k');
            dic['5'].Add('l');
            dic['6'].Add('m');
            dic['6'].Add('n');
            dic['6'].Add('o');
            dic['7'].Add('p');
            dic['7'].Add('q');
            dic['7'].Add('r');
            dic['7'].Add('s');
            dic['8'].Add('t');
            dic['8'].Add('u');
            dic['8'].Add('v');
            dic['9'].Add('w');
            dic['9'].Add('x');
            dic['9'].Add('y');
            dic['9'].Add('z');

            for (int i = 0; i < words.Length; i++)
            {
                bool isRight = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!dic[num[j]].Contains(words[i][j]))
                    {
                        isRight = false;
                        break;
                    }
                }
                if (isRight)
                {
                    lisResult.Add(words[i]);
                }

            }
            return lisResult;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/keyboard-row/ 500. 键盘行
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string[] FindWords(string[] words)
        {

            List<string> lisResult = new List<string>();
            if (words == null || words.Length == 0) return lisResult.ToArray();

            string[] keyboard = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            for (int i = 0; i < words.Length; i++)
            {
                int belongLine = 0;
                bool isSame = true;
                for (int k = 0; k < keyboard.Length; k++)
                {
                    if (keyboard[k].IndexOf(words[i][0].ToString().ToLower()) >= 0)
                    {
                        belongLine = k;
                        break;
                    }
                }
                for (int j = 1; j < words[i].Length; j++)
                {
                    if (keyboard[belongLine].IndexOf(words[i][j].ToString().ToLower()) < 0)
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    lisResult.Add(words[i]);
                }
            }
            return lisResult.ToArray();
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/matrix-diagonal-sum/  1572. 矩阵对角线元素的和
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int DiagonalSum(int[][] mat)
        {
            if (mat == null || mat.Length == 0) return -1;

            int n = mat.Length, m = mat[0].Length;
            int x = 0, y = m - 1, result = 0;
            for (int i = 0; i < n; i++)
            {
                result += mat[i][x++] + mat[i][y--];
            }
            return m % 2 == 1 ? result - mat[m / 2][n / 2] : result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/as-far-from-land-as-possible/  1162. 地图分析
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MaxDistance(int[][] grid)
        {
            int[] dx = new int[] { 0, 0, 1, -1 }, dy = new int[] { 1, -1, 0, 0 };

            LinkedList<int[]> queue = new LinkedList<int[]>();
            int m = grid.Length, n = grid[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        queue.AddLast(new int[] { i, j });
                    }
                }
            }
            int[] currPoint = null;
            bool hasOcean = false;
            while (queue.Count > 0)
            {
                currPoint = queue.First();
                queue.RemoveFirst();

                int currX = currPoint[0], currY = currPoint[1];

                for (int i = 0; i < 4; i++)
                {
                    int newX = currX + dx[i], newY = currY + dy[i];
                    if (newX < 0 || newY < 0 || newX >= m || newY >= n || grid[newX][newY] != 0)
                    {
                        continue;
                    }
                    grid[newX][newY] = grid[currX][currY] + 1;
                    hasOcean = true;
                    queue.AddLast(new int[] { newX, newY });
                }
            }
            if (!hasOcean || currPoint == null)
            {
                return -1;
            }
            return grid[currPoint[0]][currPoint[1]] - 1;
        }
        /// <summary>
        /// 根据二维矩阵字符串生成二维矩阵
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[][] GetMatrixString(string str)
        {
            str = str.Substring(1, str.Length - 1);
            str = str.Substring(0, str.Length - 1);
            str = str.Replace("],", "]").Replace("]", "").TrimStart('[');
            string[] arr = str.Split('[');
            int n = arr.Length;
            string[][] matrix = new string[n][];
            for (int i = 0; i < n; i++)
            {
                string strCurr = arr[i];
                string[] currArr = strCurr.Split(',');
                string[] subArr = new string[currArr.Length];
                if (currArr == null || currArr.Length == 0 || (currArr.Length == 1 && currArr[0] == ""))
                {
                    matrix[i] = new string[0] { };
                    continue;
                }

                for (int j = 0; j < currArr.Length; j++)
                {
                    subArr[j] = currArr[j];
                }
                matrix[i] = subArr;
            }
            return matrix;
        }
        /// <summary>
        /// 根据二维矩阵字符串生成二维矩阵
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char[][] GetMatrixChar(string str)
        {
            str = str.Substring(1, str.Length - 1);
            str = str.Substring(0, str.Length - 1);
            str = str.Replace("],", "]").Replace("]", "").TrimStart('[');
            string[] arr = str.Split('[');
            int n = arr.Length;
            char[][] matrix = new char[n][];
            for (int i = 0; i < n; i++)
            {
                string strCurr = arr[i].Replace("'", "");
                string[] currArr = strCurr.Split(',');
                char[] subArr = new char[currArr.Length];
                if (currArr == null || currArr.Length == 0 || (currArr.Length == 1 && currArr[0] == ""))
                {
                    matrix[i] = new char[0] { };
                    continue;
                }

                for (int j = 0; j < currArr.Length; j++)
                {
                    subArr[j] = currArr[j][0];
                }
                matrix[i] = subArr;
            }
            return matrix;
        }
        /// <summary>
        /// 根据二维矩阵字符串生成二维矩阵
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int[][] GetMatrix(string str)
        {
            str = str.Substring(1, str.Length - 1);
            str = str.Substring(0, str.Length - 1);
            str = str.Replace("],", "]").Replace("]", "").TrimStart('[');
            string[] arr = str.Split('[');
            int n = arr.Length;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string strCurr = arr[i];
                string[] currArr = strCurr.Split(',');
                int[] subArr = new int[currArr.Length];
                if (currArr == null || currArr.Length == 0 || (currArr.Length == 1 && currArr[0] == ""))
                {
                    matrix[i] = new int[0] { };
                    continue;
                }

                for (int j = 0; j < currArr.Length; j++)
                {
                    subArr[j] = int.Parse(currArr[j]);
                }
                matrix[i] = subArr;
            }
            return matrix;
        }
        /// <summary>
        /// 根据二维矩阵字符串生成二维矩阵
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int[][] GetMatrix2(string str)
        {
            str = str.Substring(1, str.Length - 1);
            str = str.Substring(0, str.Length - 1);
            str = str.Replace("],", "]").Replace("[", "").TrimEnd(']');
            string[] arr = str.Split(']');
            int n = arr.Length;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string strCurr = arr[i];
                string[] currArr = strCurr.Split(',');
                int[] subArr = new int[currArr.Length];
                for (int j = 0; j < currArr.Length; j++)
                {
                    subArr[j] = int.Parse(currArr[j]);
                }
                matrix[i] = subArr;
            }
            return matrix;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/route-between-nodes-lcci/   面试题 04.01. 节点间通路
        /// </summary>
        /// <param name="n"></param>
        /// <param name="graph"></param>
        /// <param name="start"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool FindWhetherExistsPath(int n, int[][] graph, int start, int target)
        {
            //创建邻接表
            //List<List<int>> adj = new List<List<int>>();
            List<int>[] adj = new List<int>[n];
            for (int i = 0; i < graph.Length; i++)
            {
                int from = graph[i][0], to = graph[i][1];
                if (adj[from] == null)
                    adj[from] = new List<int>();
                adj[from].Add(to);
            }
            LinkedList<int> queue = new LinkedList<int>();
            bool[] visited = new bool[n];
            queue.AddLast(start);
            visited[start] = true;
            while (queue.Count > 0)
            {
                int curr = queue.First();
                queue.RemoveFirst();

                List<int> currList = adj[curr];
                if (currList == null) continue;

                foreach (var num in currList)
                {
                    if (num == target)
                    {
                        return true;
                    }
                    if (visited[num])
                    {
                        continue;
                    }
                    queue.AddLast(num);
                    visited[num] = true;
                }
            }
            return false;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/groups-of-special-equivalent-strings/  893. 特殊等价字符串组
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int NumSpecialEquivGroups(string[] A)
        {
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < A.Length; i++)
            {
                int[] count = new int[52];
                for (int j = 0; j < A[i].Length; j++)
                {
                    count[(A[i][j] - 'a') + 26 * (j % 2)]++;
                }
                string key = "";
                for (int j = 0; j < 26; j++)
                {
                    if (count[j] > 0)
                        key += (((char)('a' + j)) * count[j]).ToString();
                }
                for (int j = 26; j < 52; j++)
                {
                    if (count[j] > 0)
                        key += (((char)('a' + (j - 26))) * count[j]).ToString();
                }
                if (!set.Contains(key))
                    set.Add(key);
            }
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int[] arr1 = new int[26], arr2 = new int[26];
            //    for (int j = 0; j < A[i].Length; j++)
            //    {
            //        if (j % 2 == 0)
            //            arr1[A[i][j] - 'a'] ++;
            //        else
            //            arr2[A[i][j] - 'a'] ++;
            //    }
            //    string odd = "", eve = "";
            //    for (int j = 0; j < 26; j++)
            //    {
            //        if (arr1[j]>0)
            //        {
            //            odd += (('a' + j) * arr1[j]).ToString();
            //            //odd += arr1[j].ToString() + ((char)('a' + j)).ToString();
            //        }
            //        if (arr2[j] > 0)
            //        {
            //            eve += (('a' + j) * arr2[j]).ToString();
            //            //eve += arr2[j].ToString() + ((char)('a' + j)).ToString();
            //        }
            //    }
            //    if (!set.Contains((odd + eve)))
            //        set.Add((odd+eve));

            //}
            return set.Count;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/palindrome-number/  9. 回文数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int behindHalf = 0;
            while (x > behindHalf)
            {
                behindHalf = behindHalf * 10 + x % 10;
                x /= 10;
            }
            return x == behindHalf || x == behindHalf / 10;


            //string str = x.ToString();
            //int i = 0, j = str.Length -1;
            //while (j>i)
            //{
            //    if (str[i] == str[j])
            //    {
            //        i++;
            //        j--;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
        /// <summary>
        /// 802. 找到最终的安全状态   https://leetcode-cn.com/problems/find-eventual-safe-states/
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static IList<int> EventualSafeNodes(int[][] graph)
        {

            return null;
        }
        public static bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                }
            }
            return x == 0 && y == 0;
        }


        /// <summary>
        /// 1588. 所有奇数长度子数组的和  https://leetcode-cn.com/problems/sum-of-all-odd-length-subarrays/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int SumOddLengthSubarrays(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int sz = 1; sz + i - 1 < arr.Length; sz += 2)
                {
                    for (int j = i; j < i + sz; j++)
                    {
                        result += arr[j];
                    }
                }
            }
            return result;
        }
        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                result++;
                            }
                        }
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 785. 判断二分图   https://leetcode-cn.com/problems/is-graph-bipartite/
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static bool IsBipartite(int[][] graph)
        {
            #region 并查集

            int n = graph.Length;
            parentIsBipartite = new int[n];
            for (int i = 0; i < n; i++)
            {
                parentIsBipartite[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                int currP = FindIsBipartite(i);
                foreach (var neigb in graph[i])
                {
                    int neignP = FindIsBipartite(neigb);
                    if (neignP != currP)
                    {
                        //union
                        parentIsBipartite[neignP] = FindIsBipartite(graph[i][0]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;

            #endregion

            #region BFS
            //注意到，我们从一个点开始BFS能否遍历完所有的点？如果所有点是连通的，那就能，但题目没有说一定是连通的
            //所以，要遍历每个顶点，再遍历当前顶点的所有相邻顶点，才能保证不漏点
            //int n = graph.Length;
            //int[] result = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    if (result[i] == 0)
            //    {
            //        LinkedList<int> queue = new LinkedList<int>();
            //        queue.AddLast(i);
            //        result[i] = 1;
            //        while (queue.Count > 0)
            //        {
            //            int curr = queue.First();
            //            queue.RemoveFirst();

            //            int nextColor = result[curr] == 1 ? 2 : 1;
            //            foreach (var item in graph[curr])
            //            {
            //                if (result[item] == 0)
            //                {
            //                    result[item] = nextColor;
            //                    queue.AddLast(item);
            //                }
            //                else if (result[item] != nextColor)
            //                {
            //                    return false;
            //                }
            //            }

            //        }
            //    }
            //}
            //return true;

            #endregion
        }
        public static int[] parentIsBipartite;
        public static int FindIsBipartite(int num)
        {
            while (parentIsBipartite[num] != num)
            {
                num = parentIsBipartite[num];
            }
            return num;
        }
        /// <summary>
        /// 210. 课程表 II  https://leetcode-cn.com/problems/course-schedule-ii/
        /// </summary>
        /// <param name="numCourses"></param>
        /// <param name="prerequisites"></param>
        /// <returns></returns>
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            LinkedList<int> queue = new LinkedList<int>();
            List<List<int>> lis = new List<List<int>>();
            List<int> lisResult = new List<int>();
            int[] inDegree = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                lis.Add(new List<int>());
            }
            for (int i = 0; i < prerequisites.Length; i++)
            {
                inDegree[prerequisites[i][0]]++;
                lis[prerequisites[i][1]].Add(prerequisites[i][0]);
            }
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegree[i] == 0)
                {
                    queue.AddLast(i);
                }
            }
            while (queue.Count > 0)
            {
                int curr = queue.First();
                queue.RemoveFirst();

                lisResult.Add(curr);
                for (int i = 0; i < lis[curr].Count; i++)
                {
                    inDegree[lis[curr][i]]--;
                    if (inDegree[lis[curr][i]] == 0)
                    {
                        queue.AddLast(lis[curr][i]);
                    }
                }
            }
            if (numCourses != lisResult.Count)
            {
                return new int[] { };
            }
            return lisResult.ToArray();

        }

        /// <summary>
        /// https://leetcode-cn.com/problems/course-schedule/  207. 课程表
        /// </summary>
        /// <param name="numCourses"></param>
        /// <param name="prerequisites"></param>
        /// <returns></returns>
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            LinkedList<int> queue = new LinkedList<int>();
            IList<List<int>> lis = new List<List<int>>();
            int[] inDegree = new int[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                lis.Add(new List<int>());
            }
            foreach (int[] preRe in prerequisites)
            {
                inDegree[preRe[1]]++;
                lis[preRe[0]].Add(preRe[1]);
            }
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegree[i] == 0)
                {
                    queue.AddLast(i);
                }
            }

            while (queue.Count > 0)
            {
                int curr = queue.First();
                queue.RemoveFirst();
                numCourses--;

                for (int i = 0; i < lis[curr].Count; i++)
                {
                    if (--inDegree[lis[curr][i]] == 0)
                        queue.AddLast(lis[curr][i]);
                }
            }
            return numCourses == 0;
        }



        /// <summary>
        /// 1306. 跳跃游戏 III  https://leetcode-cn.com/problems/jump-game-iii/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static bool CanReach(int[] arr, int start)
        {
            if (arr[start] == 0)
            {
                return true;
            }


            LinkedList<int> queue = new LinkedList<int>();
            queue.AddLast(start);
            bool[] used = new bool[arr.Length];
            used[start] = true;
            while (queue.Count > 0)
            {
                int curr = queue.First();

                used[curr] = true;
                queue.RemoveFirst();

                int next1 = curr + arr[curr], next2 = curr - arr[curr];
                if (next1 >= 0 && next1 < arr.Length && !used[next1])
                {
                    if (arr[next1] == 0)
                    {
                        return true;
                    }
                    queue.AddLast(next1);
                    used[next1] = true;
                }
                if (next2 >= 0 && next2 < arr.Length && !used[next2])
                {
                    if (arr[next2] == 0)
                    {
                        return true;
                    }
                    queue.AddLast(next2);
                    used[next2] = true;
                }


                //int curr = queue.First();

                //used[curr] = true;
                //queue.RemoveFirst();

                //int next1 = curr + arr[curr], next2 = curr - arr[curr];
                //if (next1>=0&&next1<arr.Length&& !used[next1])
                //{
                //    queue.AddLast(next1);
                //}
                //if (next2 >= 0 && next2 < arr.Length && !used[next2])
                //{
                //    queue.AddLast(next2);
                //}

            }
            return false;
        }
        /// <summary>
        /// 1267. 统计参与通信的服务器  https://leetcode-cn.com/problems/count-servers-that-communicate/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int CountServers(int[][] grid)
        {
            int[] count_r = new int[grid.Length], count_c = new int[grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        count_r[i]++;
                        count_c[j]++;
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {

                    if (grid[i][j] == 1 && (count_r[i] > 1 || count_c[j] > 1))
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// https://leetcode-cn.com/problems/redundant-connection/  684. 冗余连接
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        public static int[] FindRedundantConnection(int[][] edges)
        {
            //并查集
            for (int i = 0; i < parentFindRedundantConnection.Length; i++)
            {
                parentFindRedundantConnection[i] = i;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                int leftP = FindParentFindRedundantConnection(edges[i][0]);
                int rightP = FindParentFindRedundantConnection(edges[i][1]);
                if (leftP != rightP)
                {

                    parentFindRedundantConnection[leftP] = rightP;
                }
                else
                {
                    return edges[i];
                }
            }

            return null;
        }
        public static int[] parentFindRedundantConnection = new int[1001];
        public static int FindParentFindRedundantConnection(int num)
        {
            while (parentFindRedundantConnection[num] != num)
            {
                num = parentFindRedundantConnection[num];
            }
            return num;
        }
        /// <summary>
        /// 841. 钥匙和房间  https://leetcode-cn.com/problems/keys-and-rooms/
        /// </summary>
        /// <param name="rooms"></param>
        /// <returns></returns>
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            #region 广度优先遍历
            LinkedList<int> queue = new LinkedList<int>();
            queue.AddLast(0);
            int roomCount = 0;
            bool[] visited = new bool[rooms.Count];
            visited[0] = true;
            while (queue.Count > 0)
            {
                int currKey = queue.First();
                queue.RemoveFirst();

                roomCount++;

                for (int i = 0; i < rooms[currKey].Count; i++)
                {
                    if (!visited[rooms[currKey][i]])
                    {
                        queue.AddLast(rooms[currKey][i]);
                        visited[rooms[currKey][i]] = true;
                    }
                }

            }
            return roomCount == rooms.Count;


            #endregion

            #region 深度优先遍历
            //bool[] visited=new bool[rooms.Count];
            //int roomCount =  DFSCanVisitAllRooms(rooms, 0, 0, visited);
            //if (roomCount==rooms.Count)
            //    return true;
            //return false;
            #endregion
        }

        public static int DFSCanVisitAllRooms(IList<IList<int>> rooms, int curr, int roomCount, bool[] visited)
        {
            visited[curr] = true;
            roomCount++;
            for (int i = 0; i < rooms[curr].Count; i++)
            {
                if (!visited[rooms[curr][i]])
                {
                    roomCount = DFSCanVisitAllRooms(rooms, rooms[curr][i], roomCount, visited);
                }
            }
            return roomCount;
        }
        /// <summary>
        ///1387. 将整数按权重排序  https://leetcode-cn.com/problems/sort-integers-by-the-power-value/
        /// </summary>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int GetKth(int lo, int hi, int k)
        {
            List<KeyValuePair<int, int>> lis = new List<KeyValuePair<int, int>>();
            for (int i = lo; i <= hi; i++)
            {
                lis.Add(new KeyValuePair<int, int>(i, GetKthEachNum(i)));
            }
            lis.Sort((a, b) => a.Value != b.Value ? a.Value.CompareTo(b.Value) : a.Key.CompareTo(b.Key));
            return lis[k - 1].Key;
        }
        public static int GetKthEachNum(int num)
        {
            int count = 0;
            while (num != 1)
            {
                count++;
                if (num % 2 == 0)
                    num /= 2;
                else
                    num = 3 * num + 1;
            }
            return count;
        }
        /// <summary>
        /// 1557. 可以到达所有点的最少点数目  https://leetcode-cn.com/problems/minimum-number-of-vertices-to-reach-all-nodes/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <returns></returns>
        public static IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            IList<int> result = new List<int>();
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < edges.Count; i++)
            {
                if (!hs.Contains(edges[i][1]))
                    hs.Add(edges[i][1]);
            }
            for (int i = 0; i < n; i++)
            {
                if (!hs.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;

            //Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
            //for (int i = 0; i <n; i++)
            //{
            //    graph.Add(i,new HashSet<int>());
            //}
            //for (int i = 0; i < edges.Count; i++)
            //{
            //    int a = edges[i][0];
            //    int b = edges[i][1];
            //    //graph[a].Add(b);
            //    graph[b].Add(a);
            //}
            //IList<int> result = new List<int>();
            //foreach (var item in graph)
            //{
            //    if (item.Value.Count==0)
            //    {
            //        result.Add(item.Key);
            //    }
            //}
            //return result;
        }
        /// <summary>
        /// 面试题 08.07. 无重复字符串的排列组合  https://leetcode-cn.com/problems/permutation-i-lcci/
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string[] Permutation(string S)
        {
            List<string> resultLis = new List<string>();
            resultLis.Add(S);
            for (int i = 0; i < S.Length; i++)
            {
                int index = resultLis.Count;
                for (int j = i + 1; j < S.Length; j++)
                {
                    for (int k = 0; k < index; k++)
                    {
                        resultLis.Add(SwapPermutation(resultLis[k], i, j));
                    }
                }
            }
            return resultLis.ToArray();
        }
        private static String SwapPermutation(String s, int pos1, int pos2)
        {
            char[] arr = s.ToCharArray();
            char temp = ' ';
            temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
            return new String(arr);
        }
        public static int LastStoneWeight(int[] stones)
        {

            if (stones == null || stones.Length < 1) return 0;

            List<int> lis = new List<int>();
            for (int i = 0; i < stones.Length; i++)
            {
                lis.Add(stones[i]);
            }

            while (lis.Count > 1)
            {
                lis.Sort();
                if (lis[lis.Count - 1] == lis[lis.Count - 2])
                {
                    lis.RemoveAt(lis.Count - 1);
                    lis.RemoveAt(lis.Count - 1);
                }
                else
                {
                    lis[lis.Count - 2] = lis[lis.Count - 1] - lis[lis.Count - 2];
                    lis.RemoveAt(lis.Count - 1);
                }
            }
            return lis.Count == 1 ? lis[0] : 0;
        }



        public static int InsertBits(int N, int M, int i, int j)
        {


            if (j >= 31)
            {
                N = 0;
            }
            else
            {
                for (int k = i; k <= j; k++)
                {
                    if ((N & (1 << k)) == 1)
                    {
                        N -= (1 << k);
                    }
                }
            }

            N |= (M << i);
            return N;

        }
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;

            while (n % 2 == 0)
            {
                n = n / 2;
            }
            return n == 1;
        }
        public static bool IsPowerOfFour(int num)
        {
            if (num == 0) return false;
            while (num % 4 == 0) num /= 4;
            return num == 1;
        }

        /// <summary>
        ///按位取反： 规律：~x=-（x+1）； 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToHex(int num)
        {
            if (num == 0)
                return "0";
            string res = "";
            string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            uint num2 = (uint)(num < 0 ? ~-num + 1 : num);
            uint test = (uint)(-num + 1);
            while (num2 != 0)
            {
                res = hex[num2 % 16] + res;
                num2 /= 16;
            }

            return res;
        }
        public static int ReverseBits2(int num)
        {
            int result = 0, preOne = 0, curr = 0;
            for (int i = 0; i < 32; i++)
            {
                int temp = (num >> i) & 1;
                if (temp == 1)
                {
                    curr++;
                    result = Math.Max(curr + preOne, result);
                }
                else
                {

                    result = Math.Max(curr + preOne + 1, result);
                    preOne = curr;
                    curr = 0;
                }
            }
            return result;
        }
        public static int ConvertInteger(int A, int B)
        {
            int diff = A ^ B, result = 0;

            while (diff != 0)
            {
                diff = diff & (diff - 1);
                result++;
            }
            return result;
        }



        public static IList<string> ReadBinaryWatch(int num)
        {
            IList<string> lis = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (CountOneInBinary(i) + CountOneInBinary(j) == num)
                    {
                        lis.Add(i.ToString() + ":" + (j < 10 ? "0" + j.ToString() : j.ToString()));
                    }
                }
            }
            return lis;
        }
        public static int CountOneInBinary(int num)
        {
            int result = 0;
            while (num != 0)
            {
                num = num & (num - 1);
                result++;
            }
            return result;
        }




        /// <summary>
        /// /面试题 17.01. 不用加号的加法  https://leetcode-cn.com/problems/add-without-plus-lcci/
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            while (b != 0)
            {
                int sum = (a ^ b);
                int carry = (a & b) << 1;
                a = sum;
                b = carry;
            }

            return a;

        }
        public static int MissingNumber3(int[] nums)
        {
            int total = 0, totalN = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
                totalN += i;
            }
            totalN += nums.Length;
            return totalN - total;
        }
        public static bool HasAlternatingBits(int n)
        {

            n = n ^ (n >> 1);
            return (n & (n + 1)) == 0;

            //int pre = n&1;
            //while (n!=0)
            //{
            //    n = n >> 1;
            //    if (pre==(n&1))
            //    {
            //        return false;
            //    }
            //    pre = n & 1;
            //}
            //return true;



        }

        /// <summary>
        /// 190. 颠倒二进制位
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static uint reverseBits(uint n)
        {
            int move = 31;
            uint result = 0;
            while (n != 0)
            {
                result += (n & 1) << move;
                n = n >> 1;
                move--;
            }
            return result;


            //long result = 0;
            //for (int i = 0; i < 16; i++)
            //{
            //    var temp= (((1<<i)&n)<<((16-(i+1))*2)+1);
            //    result += temp;
            //}
            //for (int i = 16; i <32; i++)
            //{
            //    var temp = (((1 << i) & n) >> ((i - 16) * 2) + 1);
            //    result += temp;
            //}
            //return (uint)result;
        }
        public static char FindTheDifference(string s, string t)
        {

            int res = (char)0;
            int lens = s.Length;
            for (int i = 0; i < lens; i++)
            {
                //res ^= (int)s[i] ^ (int)t[i];
                res ^= s[i] ^ t[i];
            }
            res ^= t[lens];
            return (char)res;



            //int totalCount = 0;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    totalCount += t[i];
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    totalCount -= s[i];
            //}
            //return (char)totalCount;



            //Dictionary<char, int> hs = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!hs.Keys.Contains(s[i]))
            //    {
            //        hs.Add(s[i], 1);
            //    }
            //    else
            //    {
            //        hs[s[i]] += 1;
            //    }
            //}
            //char result = ',';
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (!hs.Keys.Contains(t[i]))
            //    {
            //        result = t[i];
            //    }
            //    else
            //    {
            //        if (hs[t[i]]==0)
            //        {
            //             result = t[i];
            //             break;
            //        }
            //        else
            //        {
            //            hs[t[i]] -= 1;
            //        }

            //    }
            //}
            //return result;

        }
        /// <summary>
        /// https://leetcode-cn.com/problems/find-majority-element-lcci/
        /// 面试题 17.10. 主要元素
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement2(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;

            int major = nums[0], count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == major)
                    count++;
                else
                    count--;
                if (count == 0)
                {
                    major = nums[i];
                    count = 1;
                }
            }
            int half = nums.Length / 2;
            count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == major) count++;
                if (count > half) return major;
            }
            return -1;



            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //    {
            //        dic[nums[i]] += 1;
            //    }
            //    else
            //    {
            //        dic.Add(nums[i], 1);
            //    }
            //}
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key]>nums.Length/2)
            //    {
            //        return key;
            //    }
            //}
            //return -1;
        }

        public static int MissingNumber2(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= i;
                result ^= nums[i];
            }
            result ^= nums.Length;
            return result;

            //int[] arr = new int[nums.Length+1];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    arr[nums[i]] = 1;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 0) return i;
            //}
            //return -1;
        }
        public static int[] SortByBits(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = HammingWeight((uint)arr[i]) * 100000 + arr[i];
            }
            Array.Sort(newArr);
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = newArr[i] % 100000;
            }
            return newArr;
        }

        public static int CountPrimeSetBits(int L, int R)
        {
            int result = 0;
            int[] primes = { 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1 };
            for (int i = L; i <= R; i++)
            {
                int currZ = HammingWeight((uint)i);
                //if (currZ != 1&&isZhiShu(currZ))
                if (primes[currZ] == 1)
                    result++;
            }
            return result;
        }
        public static bool isZhiShu(int num)
        {
            int k = (int)Math.Sqrt(num);
            int i = 2;
            for (i = 2; i <= k; i++)
            {
                if (num % i == 0)
                    break;
            }
            if (i > k)
                return true;
            else
                return false;
        }
        public static int FindComplement(int num)
        {
            int temp = num >> 1, mark = 1;

            while (temp != 0)
            {
                mark = mark << 1 | 1;
                temp = temp >> 1;
            }
            return mark ^ num;
        }

        public static int ExchangeBits(int num)
        {
            //int ji = num & 0x55555555;
            //long ou = num & 0xaaaaaaaa;

            return (num & 0x55555555) << 1 | (int)(num & 0xaaaaaaaa) >> 1;

            ///  0110  3
            ///  0100    ji
            ///  0010
            ///  1001  7


        }

        public static int SingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;



            //if (nums == null || nums.Length ==0) return -1;

            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if ((i + 1) < nums.Length)
            //    {     
            //        if ((nums[i] ^ nums[i + 1]) != 0)
            //        {
            //            return nums[i];
            //        }
            //        else
            //        {
            //            i++;
            //        }
            //    }
            //    else
            //    {
            //        return nums[i];
            //    }
            //}
            //return -1;

            #region 旧

            //Dictionary<int,int>  dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!dic.ContainsKey(nums[i]))
            //    {
            //        dic.Add(nums[i],1);
            //    }
            //    else
            //    {
            //        dic[nums[i]] += 1;
            //    }
            //}
            //foreach (var key in dic.Keys)
            //{
            //    if (dic[key]==1)
            //    {
            //        return key;
            //    }
            //}
            //return -1;

            #endregion
        }
        public static int ArrayPairSum(int[] nums)
        {
            int result = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                result += nums[i];
            }
            return result;

        }

        public static int[] DiStringMatch(string S)
        {
            int[] resultArr = new int[S.Length + 1];
            if (string.IsNullOrEmpty(S)) return resultArr;

            int left = 0, right = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                resultArr[i] = S[i] == 'D' ? right-- : left++;
            }
            resultArr[S.Length] = left++;
            return resultArr;
        }
        public static bool IsUnique(string astr)
        {
            int mark = 0;
            foreach (char x in astr)
            {
                int move_bit = (char)x - 'a';
                if ((mark & (1 << move_bit)) != 0)
                    return false;
                else
                    mark |= (1 << move_bit);
            }
            return true;

            //List<char> lis = new List<char>();
            //for (int i = 0; i < astr.Length; i++)
            //{
            //    if (!lis.Contains(astr[i]))
            //    {
            //        lis.Add(astr[i]);
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }

        public static string GenerateTheString(int n)
        {



            string str = "";

            for (int i = 0; i < n - 1; i++)
            {
                str += "a";
            }
            if (n % 2 == 0)
            {
                str += "b";
            }
            else
            {
                str += "a";
            }
            return str;

        }
        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] >= prices[j])
                    {
                        prices[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }
            return prices;
        }

        public static int HammingWeight(uint n)
        {
            int result = 0;
            while (n > 0.1)
            {
                //if (n % 2 == 1) result++;

                //n = n >> 1;
                n = n & (n - 1);
                result++;
            }
            return result;
        }

        public static ListNode RemoveDuplicateNodes(ListNode head)
        {
            HashSet<int> set = new HashSet<int>();
            ListNode cur = head;
            while (cur != null && cur.next != null)
            {
                set.Add(cur.val);
                if (set.Contains(cur.next.val))
                    cur.next = cur.next.next;
                else
                    cur = cur.next;
            }
            return head;
            //if (head == null) return null;

            //ListNode curr = head.next, pre = head, newHead = pre;
            //List<int> lis = new List<int>();
            //lis.Add(head.val);
            //while (curr != null)
            //{
            //    if (!lis.Contains(curr.val))
            //    {
            //        lis.Add(curr.val);
            //        pre.next = curr;
            //        pre = pre.next;
            //    }
            //    else
            //    {
            //        pre.next = null;
            //    }
            //    curr = curr.next;
            //}

            //return newHead;


            //ListNode curr = null;
            //List<int> lis = new List<int>();
            //curr  = head;
            //while (curr != null)
            //{
            //    if (!lis.Contains(curr.val))
            //    {
            //        lis.Add(curr.val);
            //    }
            //    curr = curr.next;
            //}
            //ListNode newHead=new ListNode(lis[0]);
            //curr = newHead;
            //for (int i = 1; i < lis.Count; i++)
            //{
            //    curr.next = new ListNode(lis[i]);
            //    curr = curr.next;
            //}
            //return newHead;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode newHead = null, currLN = null;
            if (l1.val > l2.val)
            {
                newHead = new ListNode(l2.val);
                l2 = l2.next;

            }
            else
            {
                newHead = new ListNode(l1.val);
                l1 = l1.next;
            }
            currLN = newHead;
            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val > l2.val)
                    {
                        currLN = new ListNode(l2.val);
                        l2 = l2.next;

                    }
                    else
                    {
                        currLN = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                }
                else
                {
                    if (l1 != null)
                    {
                        currLN = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        currLN = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                }
                currLN.next = currLN;
            }
            return newHead;




            //if (l1 == null && l2 == null) return null;
            //if (l1 == null) return l2;
            //if (l2 == null) return l1;
            //ListNode newHead=null,preLN = null,currLN=null, tempLN1= l1, tempLN2 = l2;
            //if (tempLN1.val > tempLN2.val)
            //{
            //    newHead = new ListNode(tempLN2.val);
            //    tempLN2 = tempLN2.next;

            //}
            //else
            //{
            //    newHead = new ListNode(tempLN1.val);
            //    tempLN1 = tempLN1.next;
            //}

            //preLN = currLN = newHead;
            //while (tempLN1!=null||tempLN2!=null)
            //{
            //    preLN = currLN;
            //    if (tempLN1 != null && tempLN2 != null)
            //    {
            //        if (tempLN1.val > tempLN2.val)
            //        {
            //            currLN = new ListNode(tempLN2.val);
            //            tempLN2 = tempLN2.next;

            //        }
            //        else
            //        {
            //            currLN = new ListNode(tempLN1.val);
            //            tempLN1 = tempLN1.next;
            //        }
            //    }
            //    else
            //    {
            //        if (tempLN1!=null)
            //        {
            //            currLN = new ListNode(tempLN1.val);
            //            tempLN1 = tempLN1.next;
            //        }
            //        else 
            //        {
            //            currLN = new ListNode(tempLN2.val);
            //            tempLN2 = tempLN2.next;
            //        }
            //    }
            //    preLN.next = currLN;
            //}
            //return newHead;
        }

        public static bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);

            if (target.Length.Equals(arr.Length))
            {
                for (int i = 0; i < target.Length; i++)
                {
                    if (target[i] != arr[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            //return false;

        }
        public static string SortString(string s)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a'] += 1;
            }

            string resultStr = "";
            while (resultStr.Length != s.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        resultStr += (char)('a' + i);
                        arr[i]--;
                    }
                }
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] > 0)
                    {
                        resultStr += (char)('a' + i);
                        arr[i]--;
                    }
                }
            }
            return resultStr;
        }

        public static string FreqAlphabets(string s)
        {

            string resultStr = "";

            for (int i = 0; i <= s.Length - 2; i++)
            {
                if ((i + 2) < s.Length && s[i + 2] == '#')
                {
                    resultStr += (char)('a' + ((s[i] - '0') * 10) + (s[i + 1] - '1'));

                    i += 2;

                }
                else
                {
                    resultStr += (char)('a' + (s[i] - '1'));
                }
            }

            return resultStr;

            //Stack<string> st = new Stack<string>();

            //for (int i=s.Length-1; i>= 0;i--)
            //{
            //    if (s[i]!='#')
            //    {
            //        st.Push(((char)('a' + (s[i] - '1'))).ToString());
            //    }
            //    else
            //    {

            //        st.Push(getReflection(s.Substring(i - 2, 3)));
            //        i -= 2;
            //    }
            //}
            //string resultStr = "";
            //while (st.Count>0)
            //{
            //    resultStr += st.Pop().ToString();
            //}
            //return resultStr;

        }
        public static string getReflection(string input)
        {
            string strTemp2 = "";
            switch (input)
            {
                case "1":
                    strTemp2 = "a";
                    break;
                case "2":
                    strTemp2 = "b";
                    break;
                case "3":
                    strTemp2 = "c";
                    break;
                case "4":
                    strTemp2 = "d";
                    break;
                case "5":
                    strTemp2 = "e";
                    break;
                case "6":
                    strTemp2 = "f";
                    break;
                case "7":
                    strTemp2 = "g";
                    break;
                case "8":
                    strTemp2 = "h";
                    break;
            }
            return strTemp2;
        }
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            if (arr == null || arr.Length <= 2) return true;

            Array.Sort(arr);
            int diff = Math.Abs(arr[1] - arr[0]);
            for (int i = 2; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - arr[i - 1]) != diff)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Maximum69Number(int num)
        {
            int temp = num, index = 0, times = 1;// result = 0;
            while (temp > 1)
            {
                int currNum = temp % 10;

                if (currNum == 6)
                {
                    index = times;
                }
                temp = temp / 10;
                times++;
            }
            return num + 3 * (int)Math.Pow(10, index - 1);
        }
        public static string ReplaceSpace2(string s)
        {
            char[] arr = new char[s.Length * 3];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    arr[index++] = '%';
                    arr[index++] = '2';
                    arr[index++] = '0';
                }
                else
                {
                    arr[index++] = s[i];
                }
            }
            return new String(arr, 0, index);

            //return s.Replace(" ", "%20");

            //string resultStr = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]==' ')
            //    {
            //        resultStr += "%20";
            //    }
            //    else
            //    {
            //        resultStr += s[i].ToString();
            //    }
            //}
            //return resultStr;
        }

        public static int[] ReplaceElements(int[] arr)
        {
            int[] res = new int[arr.Length];
            res[res.Length - 1] = -1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                res[i] = Math.Max(arr[i + 1], res[i + 1]);
            }

            return res;

            //int maxIndex = 0;
            //for (int j =  1; j < arr.Length; j++)
            //{
            //    if (arr[j] > arr[maxIndex])
            //    {
            //        maxIndex = j;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i >= maxIndex)
            //    {
            //        int currMax = -1;
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[j] > currMax)
            //            {
            //                currMax = arr[j];
            //                maxIndex = j;
            //            }
            //        }
            //        arr[i] = currMax;
            //    }
            //    else
            //    {
            //        arr[i] = arr[maxIndex];
            //    }

            //}
            //return arr;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //     int currMax = -1;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[j]>currMax)
            //            currMax = arr[j];
            //    }
            //    arr[i] = currMax;

            //}
            //return arr;
        }
        public string ToLowerCase(string str)
        {
            string resultStr = "";
            int diff = 'A' - 'a';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    resultStr += ((char)(str[i] - diff)).ToString();
                }
                else
                {
                    resultStr += str[i].ToString();
                }

            }
            return resultStr;
            //    return str.ToLower();
        }
        public static int CountNegatives(int[][] grid)
        {
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                int start = 0, end = grid[i].Length - 1, position = grid.Length - 1;
                while (start <= end)
                {
                    int middle = (start + end) / 2;
                    if (grid[i][middle] < 0)
                    {
                        end = middle - 1;
                        position = middle;
                    }
                    else
                    {
                        start = middle + 1;
                    }
                }
                result += grid[i].Length - position;
                //for (int j = 0; j < grid[i].Length; j++)
                //{
                //    if (grid[i][j] < 0) result++;
                //}
            }
            return result;
        }

        public static int HammingDistance(int x, int y)
        {
            int newNum = x ^ y;
            int result = 0;
            while (newNum != 0)
            {
                if (newNum % 2 == 1)
                {
                    result++;
                }
                newNum = newNum >> 1;
            }
            return result;
        }
        public static int[] ReversePrint(ListNode head)
        {
            Stack<int> st = new Stack<int>();
            ListNode currNode = head;
            while (currNode != null)
            {
                st.Push(currNode.val);
                currNode = currNode.next;
            }
            int[] arr = new int[st.Count];
            int time = 0;
            while (st.Count > 0)
            {
                arr[time++] = st.Pop();
            }
            return arr;

            //List<int> lis = new List<int>();
            //ReversePrintRecur(head,lis);
            //return lis.ToArray();
        }
        //public static void ReversePrintRecur(ListNode head,List<int> lis)
        //{
        //    if (head == null) return;
        //    ReversePrintRecur(head.next,lis);
        //    lis.Add(head.val);
        //}

        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {

            int result = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (Math.Abs(arr2[j] - arr1[i]) <= d)
                    {
                        result++;
                        break;
                    }
                }
            }
            return arr1.Length - result;
        }
        public static int NumWaterBottles(int numBottles, int numExchange)
        {
            int result = numBottles, currNum = numBottles, left = currNum % numExchange, canChange = (currNum - left) / numExchange;

            while (currNum >= numExchange)
            {
                if (currNum % numExchange == 0)
                {
                    currNum = currNum / numExchange;
                    result += currNum;
                }
                else
                {
                    left = currNum % numExchange;
                    canChange = (currNum - left) / numExchange;
                    currNum = canChange + left;
                    result += canChange;
                }


            }
            return result;
        }
        public static int[] gardenNoAdj(int N, int[][] paths)
        {
            /* 这是一道简单题，限制每个节点的度为3，同时提供四种颜色，因此不需要回溯 */
            /* 初始化节点，使用map保存节点与其临界点的关系 */
            /* 第一版本采用了内部类构建，参考评论区的HashMap更简洁 */
            Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(i, new HashSet<int>());
            }
            /* 初始化路径信息 */

            foreach (var path in paths)

            {
                int a = path[0] - 1;
                int b = path[1] - 1;
                graph[a].Add(b);
                graph[b].Add(a);
            }
            int[] res = new int[N];
            for (int i = 0; i < N; i++)
            {
                bool[] used = new bool[5];
                /* 查看当前节点的所有邻接点的色彩 */
                //for (int adj: graph.get(i))
                foreach (var adj in graph[i])
                {
                    used[res[adj]] = true;
                }
                /* 为当前节点染色 */
                for (int j = 1; j <= 4; j++)
                {
                    if (!used[j])
                    {
                        res[i] = j;
                    }
                }
            }
            return res;
        }
        public static int FindJudge(int N, int[][] trust)
        {
            if (N == 1) return 1;
            if (trust == null || trust.Length == 0) return -1;

            Dictionary<int, int> dic1 = new Dictionary<int, int>();
            Dictionary<int, int> dic2 = new Dictionary<int, int>();
            for (int i = 0; i < trust.Length; i++)
            {
                if (!dic1.ContainsKey(trust[i][0]))
                {
                    dic1.Add(trust[i][0], 1);
                }
                else
                {
                    dic1[trust[i][0]] += 1;
                }
                if (!dic2.ContainsKey(trust[i][1]))
                {
                    dic2.Add(trust[i][1], 1);
                }
                else
                {
                    dic2[trust[i][1]] += 1;
                }
            }

            int judge = 0;
            foreach (var item in dic2.Keys)
            {
                judge = item;
                if (!dic1.ContainsKey(judge) && dic2[judge] == N - 1)
                {
                    return judge;
                }
            }



            return -1;
        }
        public static ListNode ReverseList(ListNode head)
        {
            ListNode preNode = null;
            ListNode currNode = head;
            while (currNode != null)
            {
                ListNode tempNext = currNode.next;

                currNode.next = preNode;
                preNode = currNode;
                currNode = tempNext;
            }
            return preNode;

            //List<int> lis = new List<int>();
            //ListNode currNode = head;

            //while (currNode!=null)
            //{
            //    lis.Add(currNode.val);
            //    currNode = currNode.next;
            //}
            //ListNode newHead = null;
            //if (lis.Count>1)
            //{
            //    newHead = new ListNode(lis[lis.Count - 1]);
            //    ListNode tempNode = newHead;
            //    for (int i = lis.Count - 2; i >= 0; i--)
            //    {
            //        currNode = new ListNode(lis[i]);
            //        tempNode.next = currNode;
            //        tempNode = currNode;
            //    }
            //}

            //return newHead;
        }

        public static string RestoreString(string s, int[] indices)
        {
            char[] arrResult = new char[s.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                arrResult[indices[i]] = s[i];
            }

            return new String(arrResult);
        }
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int result = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if ((startTime[i] <= queryTime && endTime[i] >= queryTime))
                {
                    result++;
                }
            }
            return result;
        }
        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> lis = new List<int>();
            for (int i = 1; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i - 1]; j++)
                {
                    lis.Add(nums[i]);
                }
            }
            return lis.ToArray();

        }
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            int result = 0;
            for (int i = 1; i < points.Length; i++)
            {
                result += Math.Max(Math.Abs(points[i][1] - points[i - 1][1]), Math.Abs(points[i][0] - points[i - 1][0]));
            }
            return result;

        }
        public static int MaxProduct2(int[] nums)
        {
            int max1 = int.MinValue, max2 = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max1)
                {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max2 = nums[i];
                }
            }
            return (max1 - 1) * (max2 - 1);
            //Array.Sort(nums);
            //int max1 = nums[nums.Length-1], max2 = nums[nums.Length-2];
            //return (max1-1)*(max2-1);

        }
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> lis = new List<int>();
            int[] arrRMin = new int[matrix.Length], arrCMax = new int[matrix[0].Length];
            for (int i = 0; i < arrRMin.Length; i++)
            {
                arrRMin[i] = int.MaxValue;
            }
            for (int i = 0; i < arrCMax.Length; i++)
            {
                arrCMax[i] = 0;
            }

            for (int i = 0; i < matrix.Length; i++)
            {

                for (int j = 0; j < matrix[0].Length; j++)
                {

                    arrRMin[i] = Math.Min(matrix[i][j], arrRMin[i]);
                    arrCMax[j] = Math.Max(matrix[i][j], arrCMax[j]);
                }
            }


            for (int i = 0; i < matrix.Length; i++)
            {

                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (arrRMin[i] == arrCMax[j])
                    {
                        lis.Add(arrRMin[i]);
                    }
                }

            }

            return lis;

        }

        public static string ReverseWords(string s)
        {
            string[] arr = s.Split(' ');
            string newStr = "";
            for (int i = 0; i < arr.Length; i++)
            {
                //newStr += ReverseWord(arr[i])+" ";
                var res = arr[i].ToString().Reverse();
                newStr += arr[i].ToString().Reverse().ToString();
            }
            return newStr.Trim();
        }
        public static string ReverseWord(string s)
        {
            string strResult = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                strResult += s[i].ToString();
            }
            return strResult;
        }
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] newArr = new int[2 * n];
            int time = 0;
            for (int i = 0; i < n; i++)
            {
                newArr[time] = nums[i];
                newArr[time + 1] = nums[i + n];
                time += 2;
            }
            return newArr;
        }
        public static int MaxLevelSum(TreeNode root)
        {
            if (root == null) return -1;

            LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            TreeNode currNode = root;
            int result = 0, currLevel = 1, currLevelCount = 0, maxSum = int.MinValue;

            queue.AddLast(root);
            while (queue.Count > 0)
            {
                currLevel++;
                currLevelCount = queue.Count;
                int currLevelSum = 0;

                while (currLevelCount > 0)
                {
                    currNode = queue.First();
                    queue.RemoveFirst();

                    currLevelSum += currNode.val;

                    if (currNode.left != null) queue.AddLast(currNode.left);
                    if (currNode.right != null) queue.AddLast(currNode.right);

                    currLevelCount--;
                }
                if (maxSum < currLevelSum)
                {
                    maxSum = currLevelSum;
                    result = currLevel;
                }
            }
            return result;

        }
        public static bool DivisorGame(int N)
        {
            return N % 2 == 0;
        }
        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }

            }
            return count;
        }

        public static bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (t == null) return true;
            if (s == null) return false;
            if (s.val != t.val) return false;

            return IsSubtree(s.right, t) || IsSubtree(s.left, t) || IsSametree(s, t);
        }
        public static bool IsSametree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;
            if (s.val != t.val) return false;

            return IsSametree(s.left, t.left) && IsSametree(s.right, t.right);
        }




        public static TreeNode preNodeMinDiffInBST = null;
        public static int minValMinDiffInBST = int.MaxValue;
        public static int MinDiffInBST(TreeNode root)
        {
            MinDiffInBSTInOrder(root);
            return minValMinDiffInBST;

        }
        public static void MinDiffInBSTInOrder(TreeNode root)
        {
            if (root == null) return;
            MinDiffInBSTInOrder(root.left);

            if (preNodeMinDiffInBST != null)
            {
                minValMinDiffInBST = Math.Min(root.val - preNodeMinDiffInBST.val, minValMinDiffInBST);
            }
            preNodeMinDiffInBST = root;
            MinDiffInBSTInOrder(root.right);
        }


        //static int resultlongestUnivaluePath = 0;
        //public static int LongestUnivaluePath(TreeNode root)
        //{
        //    arrowLength(root);
        //    return resultlongestUnivaluePath;
        //}
        //public static int arrowLength(TreeNode node)
        //{
        //    if (node == null) return 0;

        //    int left = arrowLength(node.left);
        //    int right = arrowLength(node.right);
        //    int leftArrow = 0, rightArrow = 0;
        //    if (node.left != null && node.left.val == node.val)
        //    {
        //        leftArrow = left + 1;
        //    }
        //    if (node.right != null && node.right.val == node.val)
        //    {
        //        rightArrow = right + 1;
        //    }
        //    resultlongestUnivaluePath = Math.Max(resultlongestUnivaluePath, leftArrow + rightArrow);
        //    return Math.Max(leftArrow, rightArrow);
        //}


        public static string Tree2str(TreeNode t)
        {
            if (t == null) return "";
            if (t.left == null && t.right == null)
            {
                return t.val + "";
            }
            if (t.right == null)
            {
                return t.val + "(" + Tree2str(t.left) + ")";
            }
            return t.val + "(" + Tree2str(t.left) + ")(" + Tree2str(t.right) + ")";
        }




        public static int[] FindMode(TreeNode root)
        {
            FindModeDFS(root);
            return testLisFindMode.ToArray();
        }
        public static int depthDiameterBT = 0;
        public static int currNodeDepthDiameterBT = 0;

        public static List<int> lisDiamter = new List<int>();
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            DiameterOfBinaryTreeDFS(root);
            if (lisDiamter.Count > 0)
            {
                int max = -1;
                for (int i = 0; i < lisDiamter.Count; i++)
                {
                    if (lisDiamter[i] > max)
                    {
                        max = lisDiamter[i];
                    }
                }
                return max;
            }
            return 0;
        }
        public static void DiameterOfBinaryTreeDFS(TreeNode root)
        {
            if (root == null) return;

            int leftDept = GetDepthBinaryTree(root.left);
            int rightDept = GetDepthBinaryTree(root.right);
            lisDiamter.Add(leftDept + rightDept);

            DiameterOfBinaryTreeDFS(root.left);
            DiameterOfBinaryTreeDFS(root.right);
        }
        public static int GetDepthBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            int leftDepth = GetDepthBinaryTree(root.left);
            int rightDepth = GetDepthBinaryTree(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }


        public static List<int> testLisFindMode = new List<int>();
        public static int maxTimesFindMode = 0;
        public static int currTimesFindMode = 0;
        public static TreeNode preNodeFindMode = null;
        public static void FindModeDFS(TreeNode root)
        {
            if (root == null) return;

            FindModeDFS(root.left);
            if (preNodeFindMode == null)
            {
                currTimesFindMode = 1;
            }
            else
            {
                if (preNodeFindMode.val == root.val)
                {
                    currTimesFindMode++;
                }
                else
                {
                    currTimesFindMode = 1;
                }
            }
            if (currTimesFindMode > maxTimesFindMode)
            {
                maxTimesFindMode = currTimesFindMode;
                testLisFindMode.Clear();
                testLisFindMode.Add(root.val);
            }
            else if (currTimesFindMode == maxTimesFindMode && !testLisFindMode.Contains(root.val))
            {
                testLisFindMode.Add(root.val);
            }
            preNodeFindMode = root;


            FindModeDFS(root.right);
        }
        public static int FindSecondMinimumValue(TreeNode root)
        {
            HashSet<int> hs = new HashSet<int>();
            FindSecondMinimumValueDFS(root, hs);
            int[] arr = hs.ToArray();
            Array.Sort(arr);
            return arr.Length > 1 ? arr[1] : -1;
        }
        public static void FindSecondMinimumValueDFS(TreeNode root, HashSet<int> hs)
        {
            if (root == null) return;

            if (!hs.Contains(root.val))
            {
                hs.Add(root.val);
            }
            FindSecondMinimumValueDFS(root.left, hs);
            FindSecondMinimumValueDFS(root.right, hs);
        }

        public static bool IsCousins(TreeNode root, int x, int y)
        {
            Dictionary<int[], TreeNode> dic = new Dictionary<int[], TreeNode>();

            IsCousinsGetDepth(root, x, y, dic, 0, null);
            if (dic.Count == 2)
            {
                int times = 0;
                TreeNode node1 = null;
                TreeNode node2 = null;
                foreach (var item in dic.Values)
                {
                    times++;
                    if (times == 1)
                    {
                        node1 = item;
                    }
                    else
                    {
                        node2 = item;
                    }
                }
                if (node1 == node2)
                {
                    return false;
                }

                int[] arr1 = new int[2];
                int[] arr2 = new int[2];
                times = 0;
                foreach (var item in dic.Keys)
                {
                    times++;
                    if (times == 1)
                    {
                        arr1 = item;
                    }
                    else
                    {
                        arr2 = item;
                    }
                }
                if (arr1[0] == arr2[0])
                {
                    return true;
                }

            }
            return false;
        }

        public static void IsCousinsGetDepth(TreeNode root, int x, int y, Dictionary<int[], TreeNode> dic, int parentDept, TreeNode parentNode)
        {
            if (root == null) return;

            int currDept = parentDept++;
            IsCousinsGetDepth(root.left, x, y, dic, parentDept, root);
            IsCousinsGetDepth(root.right, x, y, dic, parentDept, root);

            if (root.val == x || root.val == y)
            {
                int[] arr = new int[2];
                arr[0] = currDept;
                arr[1] = root.val;

            }
        }


        public static bool IsSymmetricTest(TreeNode root)
        {
            if (root == null) return true;


            return RecurIsSymmetric(root.left, root.right);

        }

        public static bool RecurIsSymmetricTest(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null) return true;

            if ((leftNode == null || rightNode == null) || leftNode.val != rightNode.val) return false;


            return RecurIsSymmetricTest(leftNode.left, rightNode.right) && RecurIsSymmetricTest(leftNode.right, rightNode.left);

        }

        public static int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;

            List<int> lis = new List<int>();
            lis.Add(0);

            SumOfLeftLeavesDFS(root, lis);
            return lis[0];
        }

        public static void SumOfLeftLeavesDFS(TreeNode root, List<int> lis)
        {
            if (root == null) return;

            SumOfLeftLeavesDFS(root.left, lis);
            SumOfLeftLeavesDFS(root.right, lis);
            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                lis[0] += root.left.val;
            }
        }

        public static int FindTilt(TreeNode root)
        {
            if (root == null) return 0;

            List<int> lis = new List<int>();
            lis.Add(0);

            FindTiltSumDFS(root, lis);
            return lis[0];

            int leftSum = FindTilt(root.left);
            int rightSum = FindTilt(root.right);

            return Math.Abs(leftSum - rightSum);
        }

        public static int FindTiltSumDFS(TreeNode root, List<int> lis)
        {
            if (root == null) return 0;

            //int currSum = root.val;

            int leftSum = FindTiltSumDFS(root.left, lis);
            int rightSum = FindTiltSumDFS(root.right, lis);
            lis[0] += Math.Abs(leftSum - rightSum);

            return leftSum + rightSum + root.val;
        }

        public static bool FindTargetIteration(TreeNode root, int k)
        {
            if (root == null) return false;

            LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            LinkedList<int> queueNum = new LinkedList<int>();
            HashSet<int> hs = new HashSet<int>();

            queue.AddLast(root);
            while (queue.Count > 0)
            {
                TreeNode currNode = queue.First();
                queue.RemoveFirst();

                if (hs.Contains(k - currNode.val))
                {
                    return true;
                }
                hs.Add(currNode.val);
                if (currNode.left != null) queue.AddLast(currNode.left);
                if (currNode.right != null) queue.AddLast(currNode.right);

            }
            return false;

        }

        public static bool FindTarget(TreeNode root, int k)
        {
            if (root == null) return false;
            HashSet<int> hs = new HashSet<int>();


            return FindTargetDFS(root, hs, k); ;

        }
        public static bool FindTargetDFS(TreeNode root, HashSet<int> hs, int k)
        {
            if (root == null) return false;

            if (hs.Contains(k - root.val))
            {
                return true;
            }
            hs.Add(root.val);
            return FindTargetDFS(root.left, hs, k) || FindTargetDFS(root.right, hs, k);

        }
        public static TreeNode preNodeGetMinimumDifference = null;
        public static int GetMinimumDifference(TreeNode root)
        {
            if (root == null) return -1;
            List<int> lisMinVal = new List<int>();
            lisMinVal.Add(999);
            GetMinimumDifferenceInOrder(root, lisMinVal);
            return lisMinVal[0];
        }

        public static void GetMinimumDifferenceInOrder(TreeNode root, List<int> lisMinVal)
        {
            if (root == null) return;

            GetMinimumDifferenceInOrder(root.left, lisMinVal);
            if (preNodeGetMinimumDifference != null)
            {
                lisMinVal[0] = System.Math.Min(System.Math.Abs(preNodeGetMinimumDifference.val - root.val), lisMinVal[0]);
            }
            preNodeGetMinimumDifference = root;
            GetMinimumDifferenceInOrder(root.right, lisMinVal);

        }


        public static bool RecurIsSymmetric(TreeNode L, TreeNode R)
        {
            if (L == null && R == null) return true;
            if (L == null || R == null || L.val != R.val) return false;
            return RecurIsSymmetric(L.left, R.right) && RecurIsSymmetric(L.right, R.left);
        }
        public static bool IsSymmetric(TreeNode root)
        {
            ///递归
            return root == null ? true : RecurIsSymmetric(root.left, root.right);

            //BFS
            //if (root == null) return true;

            //LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            //queue.AddLast(root);
            //List<int?> lisNNN = new List<int?>();
            //while (queue.Count>0)
            //{
            //    int currFloorNodeCount =queue.Count;


            //    lisNNN = new List<int?>();

            //    while (queue.Count>0&&currFloorNodeCount>0)
            //    {
            //        TreeNode currNode = queue.First();
            //        queue.RemoveFirst();
            //        currFloorNodeCount--;


            //        if (currNode.left != null)
            //        {
            //            queue.AddLast(currNode.left);
            //            lisNNN.Add(currNode.left.val);
            //        }
            //        else
            //        {
            //            lisNNN.Add(-1);
            //        }
            //        if (currNode.right != null)
            //        {
            //            queue.AddLast(currNode.right);
            //            lisNNN.Add(currNode.right.val);
            //        }
            //        else
            //        {
            //            lisNNN.Add(-1);
            //        }
            //    }

            //    for (int i = 0; i < lisNNN.Count / 2; i++)
            //    {

            //        if (lisNNN[i] != lisNNN[lisNNN.Count - 1 - i])
            //        {
            //            return false;
            //        }
        }

        public static bool IsBalancedNew(TreeNode root)
        {
            if (root == null) return true;

            int left = IsBalancedNewGetHeight(root.left);
            int right = IsBalancedNewGetHeight(root.right);
            if (System.Math.Abs(left - right) > 1)
            {
                return false;
            }

            return IsBalancedNew(root.left) && IsBalancedNew(root.right);


        }
        public static int IsBalancedNewGetHeight(TreeNode root)
        {
            if (root == null) return 0;

            int left = IsBalancedNewGetHeight(root.left) + 1;
            int right = IsBalancedNewGetHeight(root.right) + 1;

            return System.Math.Max(left, right);

        }
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;

            if (p == null || q == null) return false;

            if (p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        public static TreeNode ConvertBiNode(TreeNode root)
        {
            if (root == null) return null;

            TreeNode head = new TreeNode(0);
            ConvertBiNodeInOrder(root, head);

            return head.right;

        }
        public static TreeNode ConvertBiNodeInOrder(TreeNode root, TreeNode pNode)
        {
            if (root != null)
            {
                pNode = ConvertBiNodeInOrder(root.left, pNode);

                root.left = null;
                pNode.right = root;
                pNode = root;

                pNode = ConvertBiNodeInOrder(root.right, pNode);
            }
            return pNode;
        }
        public static TreeNode ConvertBST(TreeNode root)
        {
            if (root == null) return null;

            List<int> lisSum = new List<int>();
            lisSum.Add(0);
            ConvertBST_DFS(root, lisSum);
            return root;


        }

        public static void ConvertBST_DFS(TreeNode root, List<int> lisSum)
        {

            if (root == null) return;
            ConvertBST_DFS(root.right, lisSum);
            lisSum[0] += root.val;
            root.val = lisSum[0];
            ConvertBST_DFS(root.left, lisSum);
            //if (root == null) return null;

            //if (root.left==null&&root.right==null)
            //{
            //    //root.val += parentVal;
            //}
            //if (root.right != null)
            //{
            //    root.val += ConvertBST_DFS(root.right,parentVal).val;
            //    parentVal = root.val;
            //}
            //else
            //{

            //}
            //if (root.left != null)
            //{
            //    //root.left.val += root.val;
            //  TreeNode left = ConvertBST_DFS(root.left,parentVal);
            //}
            //return root;
        }

        public static int[] smallerNumbersThanCurrent(int[] nums)
        {

            int len = nums.Length;
            Dictionary<int, HashSet<int>> valueIndex = new Dictionary<int, HashSet<int>>(); // 预存每个值与索引对应
            for (int i = 0; i < len; i++)
            {
                if (!valueIndex.ContainsKey(nums[i])) valueIndex.Add(nums[i], new HashSet<int>());
                valueIndex[nums[i]].Add(i);
            }
            int[] sortedArr = new int[len], res = new int[len];
            Array.Copy(nums, sortedArr, len);
            Array.Sort(sortedArr); // 1, 2, 2, 3, 8
            for (int si = len - 1; si >= 0; si--)
            { // 倒序，方便处理同值的情况
              // 此行为补充优化：前面还有同值的，那就跳过这次，等下次再一并赋值
                if (si - 1 >= 0 && sortedArr[si] == sortedArr[si - 1]) continue;
                foreach (var item in valueIndex[sortedArr[si]])
                {
                    res[item] = si;
                }
                //for (int i : valueIndex.get(sortedArr[si])) res[i] = si; // 同值的所有索引都更新
            }
            return res;

            //Dictionary<int, int> indexDic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!indexDic.ContainsKey(nums[i]))
            //    { 
            //        indexDic.Add(nums[i],i);
            //    }
            //}

            //Array.Sort(nums);
            //int[] res = new int[nums.Length];
            //for (int i = 0; i < res.Length; i++)
            //{
            //    res[indexDic[nums[i]]] = i ;
            //}
            //return res;

        }

        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> lis1 = new List<int>();
            GetLeafList(root1, lis1);
            List<int> lis2 = new List<int>();
            GetLeafList(root2, lis2);
            if (lis1.Equals(lis2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void GetLeafList(TreeNode root, List<int> lis)
        {
            ////递归
            //if (root == null) return;

            //if (root.left == null && root.right == null)
            //{
            //    lis.Add(root.val);
            //}
            //GetLeafList(root.left, lis);
            //GetLeafList(root.right, lis);

            //迭代 //迭代取叶子结点时，用queue的顺序是按层排序的，用stack取出来的叶子是左右排序的
            Stack<TreeNode> st = new Stack<TreeNode>();

            st.Push(root);
            while (st.Count > 0)
            {
                TreeNode currNode = st.Pop();

                if (currNode.left == null && currNode.right == null)
                {
                    lis.Add(currNode.val);
                }
                else
                {
                    if (currNode.left != null) st.Push(currNode.left);
                    if (currNode.right != null) st.Push(currNode.right);
                }

            }
        }

        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> lis = new List<string>();
            if (root == null) return lis;

            Stack<TreeNode> stNode = new Stack<TreeNode>();
            Stack<string> stStr = new Stack<string>();

            TreeNode currNode = root;

            stNode.Push(root);
            stStr.Push(root.val.ToString());
            while (stNode.Count > 0)
            {
                TreeNode node1 = stNode.Pop();
                string str1 = stStr.Pop();
                if (node1.left == null && node1.right == null)
                {
                    lis.Add(str1);
                }
                else
                {
                    if (node1.left != null)
                    {
                        stNode.Push(node1.left);
                        stStr.Push(str1 + "->" + node1.left.val);
                    }
                    if (node1.right != null)
                    {
                        stNode.Push(node1.right);
                        stStr.Push(str1 + "->" + node1.right.val);
                    }
                }

            }
            return lis;

        }
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        //public  static IList<string> BinaryTreePaths(TreeNode root)
        //{
        //    IList<string> lis = new List<string>();
        //    BinaryTreePathsDFS(root,"",lis);
        //    return lis;
        //}
        //public static void BinaryTreePathsDFS(TreeNode root,string str,IList<string> lis)
        //{
        //    if (root == null) return ;

        //    str += root.val+"->";

        //    if (root.left == null && root.right == null)
        //    {
        //        lis.Add(str.TrimEnd('>').TrimEnd('-'));
        //        str = "";
        //    }
        //    BinaryTreePathsDFS(root.left,str,lis);
        //    BinaryTreePathsDFS(root.right, str, lis);
        //}
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            //迭代比递归的空间复杂度小
            if (root == null)
            {
                return null;
            }
            TreeNode newNode = root;
            while (newNode != null)
            {
                if (newNode.val < p.val && newNode.val < q.val)
                {
                    newNode = newNode.right;
                }
                else if (newNode.val > q.val && newNode.val > p.val)
                {
                    newNode = newNode.left;
                }
                else
                {
                    return newNode;
                }
            }
            return null;
        }
        public static int SumRootToLeaf(TreeNode root)
        {
            return SumRootToLeafDFS(root, 0);
        }
        public static int SumRootToLeafDFS(TreeNode root, int val)
        {
            if (root == null) return 0;
            val = val * 2 + root.val;
            if (root.left == null && root.right == null)
                return val;
            int left = SumRootToLeafDFS(root.left, val);
            int right = SumRootToLeafDFS(root.right, val);
            return left + right;

        }
        //public static int SumRootToLeaf(TreeNode root)
        //{
        //    List<string> lis = new List<string>();
        //     SumRootToLeafDFS(root,"",lis);

        //    int currSum = 0;
        //    for (int i = 0; i < lis.Count; i++)
        //    {

        //        for (int j = lis[i].Length-1; j >= 0; j--)
        //        {
        //            int cur = int.Parse(lis[i][j].ToString());
        //            currSum +=   (int)cur<< (lis[i].Length - 1 - j);
        //        }
        //    }
        //    return  currSum;
        //}
        //public static void SumRootToLeafDFS(TreeNode root,string str,List<string> lis)
        //{
        //    if (root == null) return;
        //    if (root.left == null&&root.right==null)
        //    {
        //        lis.Add(str+root.val.ToString());
        //        return; 
        //    }

        //        SumRootToLeafDFS(root.left, str + root.val.ToString(), lis);
        //        SumRootToLeafDFS(root.right, str + root.val.ToString(), lis);
        //}

        public static IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> lis = new List<double>();
            LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            if (root == null) return lis;

            int currFloorCount = 0;
            double floor = 0;
            queue.AddLast(root);
            while (queue.Count > 0)
            {
                floor = queue.Count;
                double currFloorSum = 0;
                currFloorCount = queue.Count;

                while (currFloorCount > 0 && queue.Count > 0)
                {
                    TreeNode currNode = queue.First();
                    queue.RemoveFirst();

                    currFloorSum += currNode.val;
                    currFloorCount--;

                    if (currNode.left != null) queue.AddLast(currNode.left);
                    if (currNode.right != null) queue.AddLast(currNode.right);
                }
                lis.Add(currFloorSum / floor);
            }
            return lis;
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            IList<int> lis = new List<int>();
            IList<IList<int>> totalLis = new List<IList<int>>();
            if (root == null) return new List<IList<int>>();
            //第一层
            lis.Add(root.val);
            totalLis.Add(lis);

            int currFloorCount = 0;

            queue.AddFirst(root);
            while (queue.Count > 0)
            {
                currFloorCount = queue.Count * 2;
                lis = new List<int>();

                while (currFloorCount > 0 && queue.Count != 0)
                {
                    TreeNode pNode = queue.First();
                    queue.RemoveFirst();

                    if (pNode.left != null)
                    {
                        queue.AddLast(pNode.left);
                        lis.Add(pNode.left.val);

                    }
                    currFloorCount--;
                    if (pNode.right != null)
                    {
                        queue.AddLast(pNode.right);
                        lis.Add(pNode.right.val);
                    }
                    currFloorCount--;
                }
                if (lis.Count > 0)
                {
                    totalLis.Add(lis);

                }

            }
            return totalLis.Reverse().ToList();
        }
        public static IList<IList<int>> LevelOrderNew(TreeNode root)
        {
            LinkedList<TreeNode> queue = new LinkedList<TreeNode>();
            IList<int> lis = new List<int>();
            List<IList<int>> totalLis = new List<IList<int>>();

            //第一层
            lis.Add(root.val);
            totalLis.Add(lis);

            int currFloorCount = 0;

            queue.AddFirst(root);
            while (queue.Count > 0)
            {
                currFloorCount = queue.Count * 2;
                lis = new List<int>();

                while (currFloorCount > 0 && queue.Count != 0)
                {
                    TreeNode pNode = queue.First();
                    queue.RemoveFirst();

                    if (pNode.left != null)
                    {
                        queue.AddLast(pNode.left);
                        lis.Add(pNode.left.val);

                    }
                    currFloorCount--;
                    if (pNode.right != null)
                    {
                        queue.AddLast(pNode.right);
                        lis.Add(pNode.right.val);
                    }
                    currFloorCount--;
                }
                if (lis.Count > 0)
                {
                    totalLis.Add(lis);

                }

            }
            return totalLis;
        }

        public static bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return true;
            return IsUnivalTreeWithRootValue(root, root.val);
        }

        public int[] LevelOrder(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<int> lis = new List<int>();
            if (root == null) return lis.ToArray();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode currNode = queue.Dequeue();
                lis.Add(currNode.val);

                if (currNode.left != null) queue.Enqueue(currNode.left);
                if (currNode.right != null) queue.Enqueue(currNode.right);
            }
            return lis.ToArray();
        }

        public static bool IsUnivalTreeWithRootValue(TreeNode root, int val)
        {
            if (root == null) return true;

            if (root.val != val) return false;
            if (!IsUnivalTreeWithRootValue(root.left, val)) return false;
            if (!IsUnivalTreeWithRootValue(root.right, val)) return false;
            return true;

        }

        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return root;
            if (root.val > R) return TrimBST(root.left, L, R);
            if (root.val < L) return TrimBST(root.right, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);
            return root;
        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            Stack<TreeNode[]> stack = new Stack<TreeNode[]>();
            stack.Push(new TreeNode[] { t1, t2 });
            while (stack.Count > 0)
            {
                TreeNode[] t = stack.Pop();
                if (t[0] == null || t[1] == null)
                {
                    continue;
                }
                t[0].val += t[1].val;
                if (t[0].left == null)
                {
                    t[0].left = t[1].left;
                }
                else
                {
                    //TreeNode[] test = new TreeNode[] { t[0].left, t[1].left };
                    stack.Push(new TreeNode[] { t[0].left, t[1].left });
                }
                if (t[0].right == null)
                {
                    t[0].right = t[1].right;
                }
                else
                {
                    stack.Push(new TreeNode[] { t[0].right, t[1].right });
                }
            }
            return t1;

            //   TreeNode root = null;
            //   if (t1!=null||t2!=null)
            //   {
            //       root = new TreeNode((t1 != null ? t1.val : 0) + (t2 != null ? t2.val : 0));
            //   }
            //   else
            //   {
            //       return null;
            //   }
            //TreeNode left=   MergeTrees(t1!=null? t1.left:null,t2!=null? t2.left:null);
            //TreeNode right = MergeTrees(t1 != null ? t1.right : null, t2 != null ? t2.right : null);

            //root.left = left;
            //root.right = right;

            //   return root;
        }
        public static int KthLargest(TreeNode root, int k)
        {
            //还可以倒序后序遍历提前返回第k个
            List<int> numLis = new List<int>();
            InOrderTree(root, numLis);
            return numLis[numLis.Count - k];
        }
        public static void InOrderTree(TreeNode root, List<int> lis)
        {
            if (root == null) return;

            InOrderTree(root.left, lis);
            lis.Add(root.val);
            InOrderTree(root.right, lis);
        }
        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            List<int> lis = new List<int>();
            lis.Add(0);
            DFSForCount(root, L, R, lis);
            //int result=0;
            //for (int i = 0; i < lis.Count; i++)
            //{
            // result+=lis[i];
            //}
            return lis[0];
        }

        public static void DFSForCount(TreeNode root, int L, int R, List<int> lis)
        {
            if (root == null)
            {
                return;
            }

            if (root.val <= R && root.val >= L)
            {
                lis[0] += root.val;
            }
            if (root.val > L)
            {
                DFSForCount(root.left, L, R, lis);
            }
            if (root.val < R)
            {
                DFSForCount(root.right, L, R, lis);
            }

        }
        public static TreeNode MirrorTree(TreeNode root)
        {
            if (root == null) return null;

            if (root.left != null)
            {
                MirrorTree(root.left);
            }
            if (root.right != null)
            {
                MirrorTree(root.right);
            }

            TreeNode temp = new TreeNode(0);
            temp = root.left;
            root.left = root.right;
            root.right = temp;
            return root;
        }
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return System.Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
        public static IList<int> PostOrderTraversal(TreeNode root)
        {

            Stack<TreeNode> stack = new Stack<TreeNode>();
            LinkedList<int> list = new LinkedList<int>();
            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    list.AddFirst(root.val);
                    stack.Push(root);
                    root = root.right;
                }
                //if (stack.Count>0)
                //{
                root = stack.Pop();
                root = root.left;
                //}
            }
            List<int> testlis = new List<int>();

            return list.ToList();
        }
        public static IList<int> PreorderTraversal(TreeNode root)
        {

            Stack<TreeNode> st = new Stack<TreeNode>();
            IList<int> resultLis = new List<int>();
            TreeNode curr = root;
            while (curr != null || st.Count > 0)
            {

                while (curr != null)
                {
                    resultLis.Add(curr.val);
                    st.Push(curr);
                    curr = curr.left;
                }
                curr = st.Pop();

                curr = curr.right;
            }
            return resultLis;
        }
        public static IList<int> PreorderTraversalRecursion(TreeNode root)
        {

            IList<int> lisTree = new List<int>();
            RecursionForPreOrder(root, lisTree);
            return lisTree;

        }

        public static void RecursionForPreOrder(TreeNode root, IList<int> lisTree)
        {
            if (root == null) return;

            lisTree.Add(root.val);

            RecursionForPreOrder(root.left, lisTree);
            RecursionForPreOrder(root.right, lisTree);

        }
        public static IList<int> InorderTraversal(TreeNode root)
        {
            #region Recursion
            //if (root == null) return null;

            //InorderTraversal(root.left);
            //lisTree.Add(root.val);
            //InorderTraversal(root.right);
            //return lisTree;
            #endregion

            #region iteration
            //IList<int> lisInOrderTree = new List<int>();
            //while (root)
            //{

            //}
            #endregion
            #region Stack
            Stack<TreeNode> st = new Stack<TreeNode>();
            IList<int> resultLis = new List<int>();
            TreeNode curr = root;
            while (curr != null || st.Count > 0)
            {
                while (curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }
                curr = st.Pop();
                resultLis.Add(curr.val);
                curr = curr.right;
            }
            return resultLis;
            #endregion
        }

        public static string RemoveOuterParentheses(string S)
        {
            int index = 0;
            string strReverse = "";
            for (int i = 0; i < S.Length; i++)
            {

                if (S[i] == ')')
                {
                    index--;
                }
                if (index >= 1)
                {
                    strReverse += S[i];
                }
                if (S[i] == '(')
                {
                    index++;
                }
            }

            return strReverse;
            //Stack<char> st = new Stack<char>();
            //string strReverse = "";
            //for (int i = 0; i < S.Length; i++)
            //{

            //     if (S[i]==')')
            //    {
            //        st.Pop();
            //    }
            //     if (st.Count>=1)
            //     {
            //         strReverse += S[i];
            //     }
            //     if (S[i] == '(')
            //     {
            //         st.Push(S[i]);
            //     }
            //}

            //return strReverse;
        }
        public static int MinAddToMakeValid(string S)
        {
            Stack<char> st = new Stack<char>();
            //int index = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (st.Count > 0)
                {
                    if (st.Peek() == '(' && S[i] == ')')
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(S[i]);
                    }
                }
                else
                {
                    st.Push(S[i]);
                }
            }

            return st.Count;
        }
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0) return new int[0];

            Dictionary<int, int> dic = new Dictionary<int, int>();
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (st.Count > 0)
                {
                    while (st.Count > 0 && st.Peek() < nums2[i])
                    {
                        dic.Add(st.Pop(), nums2[i]);
                    }
                    st.Push(nums2[i]);

                }
                else
                {
                    st.Push(nums2[i]);
                }
            }

            int[] resultArr = new int[nums1.Length];
            for (int i = 0; i < resultArr.Length; i++)
            {
                if (dic.ContainsKey(nums1[i]))
                {
                    resultArr[i] = dic[nums1[i]];
                }
                else
                {
                    resultArr[i] = -1;
                }
            }

            return resultArr;
        }

        public class MyQueue
        {
            private Stack<int> s1 = new Stack<int>();
            private Stack<int> s2 = new Stack<int>();
            /** Initialize your data structure here. */
            public MyQueue()
            {
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                s1.Push(x);
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                int popNum = s2.Pop();
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
                return popNum;
            }

            /** Get the front element. */
            public int Peek()
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                int popNum = s2.Peek();
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
                return popNum;
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return s1.Count <= 0;
            }
        }

        public static int CalPoints(string[] ops)
        {
            if (ops == null || ops.Length == 0) return -1;
            Stack<int> st = new Stack<int>();
            int result = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "+":
                        //int temp = 0;
                        //int times = 0;
                        //foreach (var item in st)
                        //{
                        //    times++;
                        //    temp += item;
                        //    if (times==2)
                        //    {
                        //        break;
                        //    }
                        //}
                        int top = st.Pop();
                        int newtop = st.Peek() + top;
                        st.Push(top);
                        st.Push(newtop);
                        result += st.Peek();
                        break;
                    case "D":
                        st.Push(st.Peek() * 2);
                        result += st.Peek();
                        break;
                    case "C":

                        result -= st.Pop();
                        break;

                    default:
                        st.Push(int.Parse(ops[i]));
                        result += st.Peek();

                        break;
                }
            }
            //int result = 0;
            //foreach (var item in st)
            //{
            //    result += item;
            //}
            return result;

        }

        public static string RemoveDuplicates(string S)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < S.Length; i++)
            {
                if (st.Count > 0)
                {
                    if (st.Peek().ToString() == S[i].ToString())
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(S[i]);
                    }
                }
                else
                {
                    st.Push(S[i]);
                }
            }

            return string.Join("", st.Reverse());
        }
        public static bool IsValid(string s)
        {

            #region Force
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        sum++;
                        break;
                    case ')':
                    case '}':
                    case ']':
                        sum--;
                        break;

                }
                if (sum < 0)
                {
                    return false;
                }
            }
            return sum == 0 ? true : false;
            #endregion
            #region Stack
            //Stack st = new Stack();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]=='['|| s[i] == '(' || s[i] == '{' )
            //    {
            //        st.Push(s[i]);
            //    }
            //    else
            //    {
            //        if (st.Count==0)
            //        {
            //            return false;
            //        }
            //        switch (s[i])
            //        {
            //            case ']':
            //                if (st.Peek().ToString()=="[")
            //                {
            //                    st.Pop();
            //                }
            //                else
            //                {
            //                    return false;
            //                }
            //                break;
            //            case '}':
            //                if (st.Peek().ToString() == "{")
            //                {
            //                    st.Pop();
            //                }
            //                else
            //                {
            //                    return false;
            //                }
            //                break;
            //            case ')':
            //                if (st.Peek().ToString() == "(")
            //                {
            //                    st.Pop();
            //                }
            //                else
            //                {
            //                    return false;
            //                }
            //                break;
            //        }
            //    }
            //}
            //return st.Count>0?false: true;
            #endregion

        }
        public static int[] maxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || k <= 0 || nums.Length < k) return new int[0];

            LinkedList<int> queue = new LinkedList<int>();
            int[] res = new int[nums.Length - k + 1];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                while (queue.Count > 0 && nums[i] >= nums[queue.Last.Value])
                {
                    queue.RemoveLast();
                }
                queue.AddLast(i);

                if (queue.First.Value == (i - k))
                {
                    queue.RemoveFirst();
                }

                if (i >= (k - 1))
                {
                    res[index++] = nums[queue.First.Value];
                }
            }

            return res;

        }
        public static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            int minDept = int.MaxValue;
            if (root.left != null)
            {
                minDept = System.Math.Min(MinDepth(root.left), minDept);
            }
            if (root.right != null)
            {
                minDept = System.Math.Min(MinDepth(root.right), minDept);
            }
            return minDept + 1;

        }
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return sum == root.val;
            }
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
        public static bool TreePathSum(TreeNode root)
        {
            return false;
        }

        public static void PreOrder(TreeNode root)
        {

            //lisTreePre.Add(root.val);

            //if (root.left != null)
            //{
            //    PreOrder(root.left);
            //}
            //if (root.right != null)
            //{
            //    PreOrder(root.right);
            //}

        }
        public static void InOrder(TreeNode root)
        {
            //if (root.left != null)
            //{
            //    InOrder(root.left);
            //}
            //lisTreePre.Add(root.val);
            //if (root.right != null)
            //{
            //    InOrder(root.right);
            //}

        }
        public static void PostOrder(TreeNode root)
        {
            //if (root.left != null)
            //{
            //    PostOrder(root.left);
            //}
            //if (root.right != null)
            //{
            //    PostOrder(root.right);
            //}
            //lisTreePre.Add(root.val);

        }

        public static TreeNode ConvertTreeFromArray(int?[] array)
        {
            int floor = 0, count = 0;
            TreeNode[] treeNodes = new TreeNode[array.Length];
            while (array != null && count < array.Length)
            {
                int start = (int)Math.Pow(2, floor) - 1;
                int end = (int)Math.Pow(2, floor + 1) - 1;
                if (end > array.Length)
                {
                    end = array.Length;
                }
                for (int i = start; i < end; i++)
                {
                    if (array[i] != null)
                    {
                        treeNodes[i] = new TreeNode((int)array[i]);
                    }
                    else
                    {
                        treeNodes[i] = null;
                    }
                    if (i > 0)
                    {
                        int parent = (i - 1) / 2;
                        if (parent >= 0)
                        {
                            TreeNode pNode = treeNodes[parent];
                            if (pNode == null)
                            {
                                pNode = treeNodes[parent + 1];
                            }
                            if (pNode != null)
                            {
                                if (i % 2 == 1)
                                {
                                    pNode.left = treeNodes[i];
                                }
                                else
                                {
                                    pNode.right = treeNodes[i];
                                }
                            }
                        }
                    }
                    count++;
                }
                floor++;
            }
            return treeNodes[0];
        }
        public static int PathSum(TreeNode root, int sum)
        {
            return 0;
        }
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;
            if (System.Math.Abs(GetHeight(root.left) - GetHeight(root.right)) > 1) return false;

            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        public static int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int leftheight = GetHeight(node.left);
            int rightheight = GetHeight(node.right);
            return Math.Max(leftheight, rightheight) + 1;
        }

        public static int[] DivingBoard(int shorter, int longer, int k)
        {
            if (k == 0) return new int[0];
            int[] resultArr = null;
            if (shorter == longer)
            {
                return new int[] { shorter * k };
            }

            resultArr = new int[k + 1];
            for (int i = 0; i < k + 1; i++)
            {
                resultArr[i] = shorter * (k - i) + longer * i;
            }
            return resultArr;
        }
        public static int MinArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return -1;
            int left = 0, right = numbers.Length - 1, middle = left + (right - left) / 2;
            while (left <= right)
            {
                middle = left + (right - left) / 2;
                if (numbers[middle] == numbers[right])
                {
                    right--;
                }
                else if (numbers[middle] > numbers[right])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }
            return numbers[left];
        }

        public static bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;

            int left = 2, right = num / 2, middle = left + (right - left) / 2;
            while (left <= right)
            {
                middle = left + (right - left) / 2;
                if (middle == num / middle && num % middle == 0)
                {
                    return true;
                }
                else if (middle > num / middle)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return false;

        }
        public static int PeakIndexInMountainArray(int[] A)
        {
            #region BinarySearch
            if (A == null || A.Length == 0) return -1;

            int left = 0, right = A.Length - 1, midde = left + (right - left) / 2;
            while (left < right)
            {
                midde = left + (right - left) / 2;
                if (A[midde] < A[midde + 1])
                {
                    left = midde;
                }
                else
                {
                    right = midde - 1;
                }

            }
            return left;
            #endregion

            #region Force  124 ms 26.5 MB
            //int max = -1, index = 0; ;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (max<A[i])
            //    {
            //        max = A[i];
            //    }
            //    else if(max>A[i])
            //    {
            //        index= i-1;
            //        break;
            //    }
            //}
            //return index;
            #endregion
        }

        public static int[] GetLeastNumbers(int[] arr, int k)
        {
            Array.Sort(arr);
            int[] resultArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                resultArr[i] = arr[i];
            }
            return resultArr;
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            if (nums.Length == 1) return nums[0];

            int[] sumArr = new int[nums.Length];
            sumArr[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sumArr[i] = sumArr[i - 1] + nums[i] > nums[i] ? sumArr[i - 1] + nums[i] : nums[i];
            }
            Array.Sort(sumArr);
            return sumArr[sumArr.Length - 1];

        }
        public static int MajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] += 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }
            int max = 0, maxNum = 0;
            for (int i = 0; i < dic.Count; i++)
            {
                if (dic.Values.ToArray()[i] >= max)
                {
                    max = dic.Values.ToArray()[i];
                    maxNum = dic.Keys.ToArray()[i];
                }
            }
            return maxNum;

        }
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;

            int left = 0, right = nums.Length - 1, middle = left + (right - left) / 2;
            while (left <= right)
            {
                middle = left + (right - left) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] > target)
                {
                    right = middle - 1;

                }
                else
                {
                    left = middle + 1;
                }
            }
            return left;
        }
        public static int GuessNumber(int n)
        {
            int left = 0, right = n - 1, middle = left + (right - left) / 2;
            while (left <= right)
            {
                middle = left + (right - left) / 2;
                switch (guess(middle))
                {
                    case 0:
                        return middle;
                    case -1:
                        right = middle - 1;
                        break;
                    case 1:
                        left = middle + 1;
                        break;
                }
            }
            return left;
        }
        public static int guess(int num)
        {
            int compareNUm = 6;
            if (num > compareNUm)
            {
                return -1;
            }
            else if (num < compareNUm)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            return -2;
        }

        public static int findIndex(int[] nums, int target)
        {
            //该方法只能在数组一定包含target的时候用
            int index = -1;
            int left = 0, right = nums.Length, mid = (left + right) / 2;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (target == nums[mid])
                {
                    index = mid;
                    break;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                    //mid = (left + right) / 2;
                }
                else
                {
                    right = mid - 1;
                    //mid = (left + right) / 2;
                }
            }

            return index;
        }

        public static int SearchTimes(int[] nums, int target)
        {
            // 搜索右边界 right
            int i = 0, j = nums.Length - 1;
            while (i <= j)
            {
                int m = (i + j) / 2;
                if (nums[m] <= target) i = m + 1;
                else j = m - 1;
            }

            if (nums == null || nums.Length == 0) return 0;

            #region DoublePoint
            int left = 0, right = nums.Length - 1, middle = left + (right - left) / 2, times = 0;
            while (left <= right)
            {
                middle = left + (right - left) / 2;
                if (nums[middle] == target)
                {
                    times++;

                    left = middle - 1;
                    right = middle + 1;
                    //往左找
                    while (left >= 0 && nums[left] == target)
                    {
                        left--;
                        times++;
                    }
                    //往右找
                    while (right < nums.Length && nums[right] == target)
                    {
                        right++;
                        times++;
                    }
                    break;
                }
                else if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return times;
            #endregion
            #region Force
            //int times = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]==target)
            //    {
            //        times++;
            //    }
            //    else if(times>0)
            //    {
            //        break;
            //    }
            //}
            //return times;
            #endregion

        }

        public static int FindMagicIndex(int[] nums)
        {
            if (nums == null | nums.Length == 0) return -1;

            #region Force
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]==i)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
            #endregion

            #region DoublePoint

            int left = 0, right = nums.Length - 1, middle = left + (right - left) / 2, target = -1;
            while (left < right)
            {
                middle = left + (right - left) / 2;
                if (nums[middle] == middle)
                {
                    //target = target == -1  ?middle:(  middle<target? middle : target);
                    right = middle;
                }
                else if (nums[middle] > middle)
                {
                    right = middle;
                }
                else
                {
                    //值小的时候可能两边都有  应该用分治加二分法
                    left = middle + 1;
                }
            }
            #endregion

            return nums[left] == left ? left : -1;
        }

        public static int MagicIndexBinarySearch(int[] arr, int left, int right)
        {
            return 0;
        }

        public static int MySqrt(int x)
        {
            int left = 0, right = x, ans = -1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if ((long)middle * middle > x)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                    ans = middle;
                }
            }
            return ans;
        }
        public static char NextGreatestLetter(char[] letters, char target)
        {
            #region foreach
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    if (letters[i]>target)
            //    {
            //        return letters[i];
            //    }
            //}
            //return letters[0];
            #endregion
            if (letters == null || letters.Length == 0) return ' ';

            int left = 0, right = letters.Length, middle = left + (right - left) / 2;
            while (left < right)
            {
                middle = left + (right - left) / 2;
                if (letters[middle] - target > 0)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return letters[left % letters.Length];
        }
        public static int FirstBadVersion(int n)
        {
            int left = 1, right = n, middle = (left + right) / 2;
            while (left < right)
            {
                middle = (left + right) / 2;
                if (IsBadVersion(middle))
                {
                    right = middle; //当前符合且右边都不是第一个错的版本，即不需要右边时， right = middle ;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return right;
        }

        public static bool IsBadVersion(int n)
        {
            int[] arr = { 1, 0, 0 };
            return arr[n - 1] == 0;
        }

        public static int FindRadius(int[] houses, int[] heaters)
        {
            return 0;

        }
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            if (mat == null || mat.Length == 0) return null;
            int[][] soilderArr = new int[mat.Length][];
            for (int i = 0; i < mat.Length; i++)
            {
                int currSoilder = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        currSoilder++;
                    }
                    else
                    {
                        break;
                    }
                }
                soilderArr[i] = new int[2];
                soilderArr[i][1] = currSoilder;
                soilderArr[i][0] = i;
            }
            Array.Sort(soilderArr, (e1, e2) => e1[1] - e2[1]);
            //soilderArr = soilderArr.Reverse().ToArray();
            int[] resultArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                resultArr[i] = soilderArr[i][0];
            }

            return resultArr;
        }
        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;

            int left = 0, right = nums.Length - 1, middle = (left + right) / 2;
            while (left < right)
            {
                middle = (left + right) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return nums[right];
        }
        public static int ArrangeCoins(int n)
        {
            #region ForceMethod
            //if (n == 0 ||n==null) return 0;
            //int resultLine = 0;
            //int countInCurrLine = 1;
            //while (n>0)
            //{
            //    n = n - countInCurrLine;
            //    countInCurrLine++;
            //    if (n>=0)
            //    {
            //        resultLine++;
            //    }
            //}

            //return resultLine;
            #endregion
            #region Method-BinarySearch
            int left = 0, right = n, middle = (left + right) / 2;
            int result = 0;
            int total = 0;
            while (left < right)
            {
                middle = (left + right) / 2;
                total = (middle * 2 + middle) / 2;
                if (total == n)
                {
                    break;
                }
                else if (total > n)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return right;

            #endregion

        }
        /// <summary>
        /// 剑指 Offer 53 - II. 0～n-1中缺失的数字 https://leetcode-cn.com/problems/que-shi-de-shu-zi-lcof/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int left = 0, right = nums.Length - 1, middle = 0;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (nums[middle] == middle)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

            }
            return left;

            #region ForceMethod
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i != nums[i])
            //        return i;
            //}
            //return nums.Length;
            #endregion

        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> totalResult = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return totalResult;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if ((i != 0 && nums[i] == nums[i - 1]))
                {
                    continue;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] || (nums[j] == nums[j - 1]))
                    {
                        continue;
                    }
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[j] > nums[k] || (nums[k] == nums[k - 1]))
                        {
                            continue;
                        }
                        List<int> oneResultt = new List<int>();

                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            oneResultt.Add(nums[i]);
                            oneResultt.Add(nums[j]);
                            oneResultt.Add(nums[k]);
                            totalResult.Add(oneResultt);
                        }
                    }
                }
            }
            return totalResult;
        }
        public static bool BackspaceCompare(string S, string T)
        {

            //StringBuilder s = new StringBuilder(S);
            //s.Remove(0,1);//可以考虑用stringbuilder
            return true;
            #region Method1
            //if (BackspaceString(S)== BackspaceString(T))
            //{
            //    return true;
            //}
            //return false;
            #endregion

        }
        public static string BackspaceString(string str)
        {
            char[] arr = new char[str.Length];
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '#')
                {
                    k = k == 0 ? 0 : k - 1;
                    arr[k] = '\0';
                }
                else
                {
                    arr[k] = str[i];
                    k++;
                }
            }
            string strResult = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '\0')
                {
                    strResult += arr[i].ToString();
                }
            }
            return strResult;
        }
        public static void Merge(int[] A, int m, int[] B, int n)
        {
            int i = m - 1, j = n - 1;
            int k = m + n - 1;
            for (k = m + n - 1; i >= 0 && j >= 0; k--)
            {
                if (A[i] > B[j])
                {
                    A[k] = A[i];
                    i--;
                }
                else
                {
                    A[k] = B[j];
                    j--;
                }
            }
            while (i >= 0)
            {
                A[k] = A[i];
                k--;
                i--;
            }
            while (j >= 0)
            {
                A[k] = B[j];
                k--;
                j--;
            }
        }

        public static int[] MergeSort(int[] nums, int start, int end)
        {
            if (nums == null || end < start) return null;
            if (end == start)
            {
                int temp = nums[start];
                int[] tempArr = { temp };
                return tempArr;
            }

            int middle = (end + start) / 2;
            int[] left = MergeSort(nums, start, middle);
            int[] right = MergeSort(nums, middle + 1, end);

            int[] newArr = new int[end - start + 1];
            int i = 0, j = 0;
            int k = 0;
            for (k = 0; i < left.Length && j < right.Length; k++)
            {
                if (left[i] < right[j])
                {
                    newArr[k] = left[i];
                    i++;
                }
                else
                {
                    newArr[k] = right[j];
                    j++;
                }
            }
            while (i < left.Length)
            {
                newArr[k] = left[i];
                k++;
                i++;
            }
            while (j < right.Length)
            {
                newArr[k] = right[j];
                k++;
                j++;
            }
            return newArr;

        }

        /// <summary>
        /// 925. 长按键入 https://leetcode-cn.com/problems/long-pressed-name/
        /// </summary>
        /// <param name="name"></param>
        /// <param name="typed"></param>
        /// <returns></returns>
        public static bool IsLongPressedName(string name, string typed)
        {
            if (name == typed) return true;
            if (name.Length > typed.Length) return false;
            int nIndex = 0, tIndex = 0;
            while (tIndex < typed.Length)
            {
                if (nIndex < name.Length && name[nIndex] == typed[tIndex])
                {
                    nIndex++;
                    tIndex++;
                }
                else if (tIndex > 0 && typed[tIndex] == name[nIndex - 1])
                {
                    tIndex++;
                }
                else
                {
                    return false;
                }
            }

            return nIndex == name.Length;
        }

        public static int StrStr(string haystack, string needle)
        {
            #region Method1

            //return haystack.IndexOf(needle); ;
            #endregion

            if (needle == null || needle == "") return 0;

            int i = 0;
            string strTemp = "";
            if (haystack.Length == needle.Length)
            {
                if (haystack == needle)
                    return 0;
                else
                    return -1;
            }
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[0])
                {
                    if (i + needle.Length - 1 < haystack.Length && haystack.Substring(i, needle.Length) == needle)
                    {
                        return i;
                    }
                    else
                    {
                        strTemp = "";
                        i++;
                    }
                }
                else
                {
                    i++;
                }

            }
            return -1;
        }
        /// <summary>
        /// 重复元素也输出
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null) return null;

            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0, j = 0;
            List<int> lisResult = new List<int>();

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    lisResult.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] > nums2[j])
                    j++;
                else
                    i++;
            }
            return lisResult.ToArray();
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] resultArr = new int[2];
            if (numbers.Length < 2 || numbers == null) return resultArr;
            int tempSum = 0;
            int i = 0, j = numbers.Length - 1;
            while (i < j)
            {
                tempSum = numbers[i] + numbers[j];
                if (tempSum == target)
                {
                    resultArr[0] = i + 1;
                    resultArr[1] = j + 1;
                    break;

                }
                else if (tempSum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return resultArr;

            #region wrong             ////双循环，超出时间限制，没考虑有序数组的递增属性
            //int[] resultArr = new int[2];
            //if (numbers.Length < 2 || numbers == null) return resultArr;
            //int i = 0, j = 1;

            //for ( i = 0; i < numbers.Length-1; i++)
            //{
            //    j = i + 1;
            //    while (j<numbers.Length)
            //    {
            //        if (numbers[i] + numbers[j] == target)
            //        {
            //            resultArr[0] = i + 1;
            //            resultArr[1] = j + 1;
            //            break;
            //        }
            //        j++;
            //    }

            //}
            #endregion
        }

        public static bool HasCycle(ListNode head)
        {
            #region HashSet
            //if (head == null) return false;

            //HashSet<ListNode> hsExistNode = new HashSet<ListNode>();
            //while (head != null)
            //{
            //    if (hsExistNode.Contains(head))
            //        return true;
            //    else
            //        hsExistNode.Add(head);

            //    head = head.next;
            //}
            //return false;
            #endregion

            #region DoublePoint

            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
            #endregion
        }
        public static int[] SortedSquares(int[] A)
        {
            #region SortMethod
            //Array.Sort(A);
            //int[] resultArr = new int[A.Length];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    resultArr[i] = A[i] * A[i];
            //}
            //return resultArr;
            #endregion
            int N = A.Length;
            int j = 0;
            while (j < N && A[j] < 0)
                j++;
            int i = j - 1;

            int[] ans = new int[N];
            int t = 0;

            while (i >= 0 && j < N)
            {
                if (A[i] * A[i] < A[j] * A[j])
                {
                    ans[t++] = A[i] * A[i];
                    i--;
                }
                else
                {
                    ans[t++] = A[j] * A[j];
                    j++;
                }
            }

            while (i >= 0)
            {
                ans[t++] = A[i] * A[i];
                i--;
            }
            while (j < N)
            {
                ans[t++] = A[j] * A[j];
                j++;
            }

            return ans;

        }

        public static int FindPairs(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return 0;
            Array.Sort(nums);
            int left = 0, right = 1;
            int pairResult = 0;
            while (right < nums.Length)
            {
                if (System.Math.Abs(nums[left] - nums[right]) == k)
                {
                    pairResult++;
                    if (left + 1 < nums.Length && nums[left] == nums[left + 1])
                    {
                        left++;
                    }
                    if (right + 1 < nums.Length && nums[right] == nums[right + 1])
                    {
                        right++;
                    }
                    left++;
                    right = left + 1;

                }
                else if (System.Math.Abs(nums[left] - nums[right]) > k)
                {
                    left++;
                    if (left == right)
                    {

                        right = left + 1;
                    }
                }
                else
                {
                    right++;
                }
            }
            return pairResult;
        }

        public static bool BinarySearch(int[] nums, int startIndex, int endIndex, int val)
        {
            if (startIndex > endIndex) return false;
            int[] numsSorted = nums.OrderBy(x => x).ToArray();
            int middleIndex = 0;
            bool result = false;
            while (startIndex <= endIndex)
            {
                middleIndex = startIndex + (endIndex - startIndex) / 2;
                if (val == numsSorted[middleIndex])
                {
                    return true;
                }
                else if (val < numsSorted[middleIndex])
                {

                    endIndex = middleIndex - 1;
                    //result= BinarySearch(nums, startIndex, middleIndex - 1, val);
                }
                else if (val > numsSorted[middleIndex])
                {
                    startIndex = middleIndex + 1;
                    //result= BinarySearch(nums, middleIndex + 1, endIndex, val);
                }
            }

            return result;
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            #region DoublePoint
            // nums1= nums1.OrderBy(x=>x).ToArray();
            //nums2 = nums2.OrderBy(x => x).ToArray();
            //List<int> lisInt = new List<int>();
            //int i = 0, j = 0;
            //while (i<nums1.Length&&j<nums2.Length)
            //{
            //    if (nums2[j]==nums1[i])
            //    {
            //        if (!lisInt.Contains(nums1[i]))
            //            lisInt.Add(nums1[i]);
            //        i++;
            //        j++;
            //    }
            //    else if (nums1[i]<nums2[j])
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        j++;
            //    }
            //}
            //return lisInt.ToArray();
            #endregion
            #region MethodByList
            //List<int> lisInt = new List<int>();
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    if (!lisInt.Contains(nums1[i]))
            //    {
            //        lisInt.Add(nums1[i]);
            //    }
            //}
            //List<int> bothLis = new List<int>();
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    if (lisInt.Contains(nums2[i])&&!bothLis.Contains(nums2[i]))
            //    {
            //        bothLis.Add(nums2[i]);
            //    }
            //}
            //return bothLis.ToArray();
            #endregion

            #region BinarySearc
            List<int> lisInt = new List<int>();
            int[] numSorted = nums1.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (BinarySearch(numSorted, 0, numSorted.Length - 1, nums2[i]) && !lisInt.Contains(nums2[i]))
                {
                    lisInt.Add(nums2[i]);
                }
            }
            return lisInt.ToArray();
            #endregion
        }
        /// <summary>
        /// ItSeemsToBeWrong 20210325 
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static int TotalFruit2(int[] tree)
        {
            if (tree == null) return 0;
            if (tree.Length < 2) return tree.Length;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(tree[0], 1);
            dic.Add(tree[1], 1);
            for (int i = 2; i < tree.Length; i++)
            {
                if (dic.ContainsKey(tree[i]))
                {
                    dic[tree[i]] += 1;
                }
            }
            return dic[tree[0]] + dic[tree[1]];
        }
        public static int KthToLast(ListNode head, int k)
        {
            if (head == null) return 1;
            #region DoublePoint
            ListNode fast = head;
            for (int i = 0; i < k - 1; i++)
            {
                fast = fast.next;
            }
            ListNode slow = head;
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow.val;
            #endregion
            #region Method1
            //ListNode tempNode = head;
            //List<int> lisInt = new List<int>();
            //while (tempNode != null)
            //{
            //    lisNodeCount++;
            //    lisInt.Add(tempNode.val);
            //    tempNode = tempNode.next;
            //}
            //int result = lisInt[lisNodeCount - k];
            //return result;
            #endregion

        }
        public static string ReverseVowels(string s)
        {
            if (s == null || s.Length == 1) return s;
            List<char> lisYuan = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int head = 0, end = s.Length - 1;
            char[] arrS = s.ToArray();
            char cTemp = ' ';
            while (head < end)
            {
                while (!lisYuan.Contains(arrS[head]) && head < arrS.Length)
                {
                    head++;
                }
                while (!lisYuan.Contains(arrS[end]) && end > 0)
                {
                    end--;
                }
                if (head > end)
                {
                    break;
                }
                cTemp = arrS[head];
                arrS[head] = arrS[end];
                arrS[end] = cTemp;
                head++;
                end--;

            }

            string result = String.Join("", arrS);
            return result;
            #region wrong -spend too much time
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (lisYuan.Contains(s[i]))
            //    {
            //        strVowels += s[i];
            //    }
            //}
            //int head = 0, end = strVowels.Length - 1;
            //char temp = ' ';
            //char[] arrCharstrVowels = strVowels.ToArray();
            //while (head<end)
            //{
            //    temp = arrCharstrVowels[head];
            //    arrCharstrVowels[head] = arrCharstrVowels[end];
            //    arrCharstrVowels[end] = temp;
            //    head++;
            //    end--;
            //}
            //char[] arrCharS = s.ToArray();
            //int vowelsIndex=0;
            //for (int i = 0; i < arrCharS.Length; i++)
            //{
            //    if (lisYuan.Contains(arrCharS[i]))
            //    {
            //        arrCharS[i] = arrCharstrVowels[vowelsIndex++];
            //    }
            //}
            //string strResult = "";
            //for (int i = 0; i < arrCharS.Length; i++)
            //{
            //    strResult += arrCharS[i];
            //}
            //return strResult;
            #endregion
            #region SwitchVowels
            //List<char> lisYuan = new List<char>{ 'a','e','i','o','u','A','E','I','O','U'};
            //char temp=' ';
            //int fast=0, slow=0;
            //char[] arrS = s.ToArray();
            //for (slow = 0; slow < arrS.Length; slow++)
            //{
            //    if (lisYuan.Contains(arrS[slow]))
            //    {
            //         break;
            //    }

            //}
            //fast = slow + 1;
            //for (fast = fast; fast < arrS.Length; fast++)
            //{
            //    if (lisYuan.Contains(arrS[fast]) && lisYuan.Contains(arrS[slow]))
            //    {
            //        temp = arrS[slow];
            //        arrS[slow] = arrS[fast];
            //        arrS[fast] = temp;
            //        slow=fast;
            //    }
            //}
            //string strNew = "";
            //for (int  i = 0; i < arrS.Length; i++)
            //{
            //    strNew += arrS[i];
            //}
            //return strNew;
            #endregion
        }

        /// <summary>
        /// 27. 移除元素 https://leetcode-cn.com/problems/remove-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int slow = 0, fast = 0;
            for (; fast < nums.Length; fast++)
            {
                if (nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }
            return slow;
            //if (nums == null) return 0;
            //int resultCount = 0;
            //int i = 0, j = 0;
            //while (j < nums.Length)
            //{
            //    if (nums[j] != val)
            //    {
            //        nums[i++] = nums[j];
            //    }
            //    j++;
            //}
            //for (int k = i; k < nums.Length; k++)
            //{
            //    nums[k] = val;
            //}
            //return i;
        }
        public static void MoveZeroesByNewList(int[] nums)
        {
            #region Method1 UseNewListArray
            List<int> lisInt = nums.ToList();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    lisInt.Add(0);
                }

            }
            int zeroNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {

                    lisInt.RemoveAt(i - zeroNum);
                    zeroNum++;
                }
            }
            nums = lisInt.ToArray();
            #endregion
        }
        public static void MoveZeroes(int[] nums)
        {
            #region Method2 DoublePoint1

            //int indexAfterNonZero = 0;
            //int i ;
            //for ( i=0 ; i < nums.Length; i++)
            //{
            //    if (nums[i] != 0)
            //    {
            //        nums[indexAfterNonZero++] = nums[i];
            //    }
            //}
            //for ( i = indexAfterNonZero; i < nums.Length; i++)
            //{
            //    nums[i] = 0;
            //}

            #endregion

            #region Method3 DoublePoint2
            int temp = 0;
            if (nums.Length > 1)
            {
                int i = 0, j = 0;
                while (j < nums.Length)
                {
                    if (nums[j] != 0)
                    {
                        SwapArray(nums, i++, j);
                    }
                    j++;
                }
            }
            #endregion
        }

        public static void SwapArray(int[] nums, int i, int j)
        {
            int temp = 0;
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        public static void GenerateMatrixByLine(int[][] arr2d, int[] arr, int lineIndex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr2d[lineIndex][i] = arr[i];
            }
        }
        public static bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            #region 算法一 不考虑排好序 时间复杂度O(nm)
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        if (matrix[i][j]==target)
            //        {
            //            return true;
            //        }
            //    }
            //}
            #endregion

            #region 算法二 考虑二维数组已经拍好序
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            int row = matrix.Length - 1, column = 0;
            int rows = matrix.Length;
            while (row >= 0 && column < matrix[0].Length)
            {
                int num = matrix[row][column];
                if (num == target)
                {
                    return true;
                }
                else if (num > target)
                {
                    row--;
                }
                else
                {
                    column++;
                }
            }
            #endregion
            return false;
        }
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            ListNode temp = head;
            int listCount = 0;
            List<string> lis = new List<string>();
            string strListNode = head.val.ToString();
            lis.Add(head.val.ToString());
            while (temp.next != null)
            {
                listCount++;

                temp = temp.next;
                lis.Add(temp.val.ToString());
                strListNode += temp.val;
            }
            return IsPalindrome2(lis);
        }
        public static bool IsPalindrome2(List<string> lis)
        {
            if (lis == null)
            {
                return true;
            }
            int head = 0, end = lis.Count - 1;

            while (head < end)
            {
                //if (!IsNumOrChar(lis[head]))
                //{
                //    head++;
                //}
                //if (!IsNumOrChar(lis[end]))
                //{
                //    end--;
                //}
                //if (IsNumOrChar(s[head]) && IsNumOrChar(lis[end]))
                //{
                if (lis[end].ToString().ToUpper() == lis[head].ToString().ToUpper())
                {
                    head++;
                    end--;
                }
                else
                {
                    return false;
                }
                //}
            }

            return true;
        }
        public static bool IsPalindrome3(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()))
            {
                return true;
            }
            int head = 0, end = s.Length - 1;

            while (head < end)
            {
                if (!IsNumOrChar(s[head]))
                {
                    head++;
                }
                if (!IsNumOrChar(s[end]))
                {
                    end--;
                }
                if (IsNumOrChar(s[head]) && IsNumOrChar(s[end]))
                {
                    if (s[end].ToString().ToUpper() == s[head].ToString().ToUpper())
                    {
                        head++;
                        end--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            #region Method2
            //string strNoSpace = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (( (s[i]-'a')>-1&&(s[i]-'a'<27))||((s[i]-'A')>-1&&(s[i]-'A')<27)||((s[i]-'0')>-1&&(s[i]-'0')<10))
            //    {
            //        strNoSpace += s[i].ToString();
            //    }
            //}
            //int head = 0, end = strNoSpace.Length - 1;
            //for (int i = 0; i < strNoSpace.Length / 2; i++)
            //{
            //    if (strNoSpace[end].ToString().ToUpper() != strNoSpace[head].ToString().ToUpper())
            //    {
            //        return false;
            //    }
            //    head++;
            //    end--;
            //}
            #endregion
            return true;
        }

        public static bool IsNumOrChar(char c)
        {
            if (((c - 'a') > -1 && (c - 'a' < 27)) || ((c - 'A') > -1 && (c - 'A') < 27) || ((c - '0') > -1 && (c - '0') < 10))
            {
                return true;
            }
            return false;
        }
        public static ListNode GetKthFromEnd(ListNode head, int k)
        {
            #region method1
            //int listCount = 1;
            //ListNode temp = head;
            //do
            //{
            //    listCount++;
            //    temp = temp.next;
            //} while (temp.next != null);
            //int foreachTime = listCount - k;
            //ListNode temp2 = head;
            //for (int i = 0; i < foreachTime; i++)
            //{
            //    temp2 = temp2.next;
            //}
            //return temp2;
            #endregion
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode fast = head, slow = head;

            for (int i = 0; i < k - 1; i++)
            {
                fast = fast.next;
            }
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow;

        }
        public static void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;
            char temp = ' ';
            while (j > i)
            {
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;

            }
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int p = 0, q = 1;
            while (q < nums.Length)
            {
                if (nums[p] == nums[q])
                {
                    q++;
                }
                else
                {
                    nums[p + 1] = nums[q];
                    p++;
                    q++;
                }
            }
            return p + 1;
        }
        public static int[] QuickSort(ref int[] s, int l, int r)
        {
            if (l < r)
            {
                //Swap(s[l], s[(l + r) / 2]); //将中间的这个数和第一个数交换 参见注1
                int i = l, j = r, x = s[l];
                while (i < j)
                {
                    while (i < j && s[j] >= x) // 从右向左找第一个小于x的数
                        j--;
                    if (i < j)
                        s[i++] = s[j];

                    while (i < j && s[i] < x) // 从左向右找第一个大于等于x的数
                        i++;
                    if (i < j)
                        s[j--] = s[i];
                }
                s[i] = x;
                QuickSort(ref s, l, i - 1); // 递归调用 
                QuickSort(ref s, i + 1, r);
            }
            return s;
            //if (arr == null || arr.Length == 0) return null;
            //if (arr.Length == 1) return arr;

            //int middle = arr.Length / 2;
            //int  temp = arr[middle], switchNum = 0;

            //while (left<right)
            //{
            //    while (arr[right] > temp && right > middle)
            //    {
            //        right--;
            //    }
            //    while (arr[left] < temp && left < middle)
            //    {
            //        left++;
            //    }
            //    if (left<right)
            //    {
            //        switchNum = arr[right];
            //        arr[right] = arr[left];
            //        arr[left] = switchNum;
            //    }
            //}
            //arr[left] = temp;
            //if (0<right-1)
            //{
            //    QuickSort(ref arr, 0, right - 1);
            //}
            //if (right < arr.Length - 1)
            //{
            //    QuickSort(ref arr, right, arr.Length - 1);

            //}

            #region wrong
            //int left = 1, right = arr.Length - 1, temp = 0, temp2 = 0; ;
            //temp = arr[0];
            //if (arr.Length == 2)
            //{
            //    if (arr[0]>arr[1])
            //    {
            //        int temp3 = arr[1];
            //        arr[1] = arr[0];
            //        arr[0] = temp3;
            //    }
            //    return arr;
            //}
            //while (left<right)
            //{
            //    while (arr[right] > temp)
            //    {
            //        right--;
            //    }
            //    while (arr[left] < temp&&left<right)
            //    {
            //        left++;
            //    }
            //    if (left==right)
            //    {
            //        arr[0] = arr[left];
            //        arr[left] = temp;
            //        break;
            //    }
            //    temp2 = arr[right];
            //    arr[right] = arr[left];
            //    arr[left] = temp2;
            //}

            ////分割左右数组
            //int[] leftArr = new int[left];
            //int[] rightArr=new int[arr.Length-left-1];
            //for (int i = 0; i < left; i++)
            //{
            //    leftArr[i] = arr[i];
            //}
            //for (int i = right+1; i < arr.Length; i++)
            //{
            //    rightArr[i-left-1] = arr[i];
            //}
            ////递归
            // leftArr = QuickSort(leftArr);
            // rightArr = QuickSort(rightArr);

            // int[] tempArr ={temp};
            // var testArr = leftArr.Union(tempArr).Union(rightArr).ToArray();
            #endregion
            //return arr;
        }
        public static int LargestSumAfterKNegations(int[] A, int K)
        {
            if (A == null || A.Length == 0) return 0;
            List<int> negativeNumLis = new List<int>();
            List<int> posiiveNumLis = new List<int>();//包含0
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    negativeNumLis.Add(A[i]);
                }
                else
                {
                    posiiveNumLis.Add(A[i]);
                }
            }
            negativeNumLis.Sort(delegate (int a, int b)
            {
                return a.CompareTo(b);
            });
            for (int i = 0; i < negativeNumLis.Count && i < K; i++)
            {
                negativeNumLis[i] = -negativeNumLis[i];
            }
            posiiveNumLis.AddRange(negativeNumLis);
            posiiveNumLis.Sort(delegate (int a, int b)
            {
                return a.CompareTo(b);
            });
            //k=5f负数1，
            if (K - negativeNumLis.Count > 0 && (K - negativeNumLis.Count) % 2 > 0)
            {

                posiiveNumLis[0] = -posiiveNumLis[0];
            }

            int sum = 0;
            for (int i = 0; i < posiiveNumLis.Count; i++)
            {
                sum += posiiveNumLis[i];
            }

            return sum;
        }
        public static int FindContentChildren(int[] g, int[] s)
        {
            if (s == null || s.Length == 0) return 0;
            var newG = g.OrderBy(x => x).ToArray();
            var newS = s.OrderBy(x => x).ToArray();
            int fitNum = 0;
            int currJ = 0, currI = 0;

            while (currI < g.Length && currJ < s.Length)
            {
                if (newS[currJ] >= newG[currI])
                {
                    currI++;
                    fitNum++;
                }
                currJ++;
            }
            //for (int i = 0; i < newG.Length; i++)
            //{
            //    for (int j = currJ; j < newS.Length; j++)
            //    {
            //        if (newS[j] >= newG[i])
            //        {
            //            currJ++;
            //            fitNum++;
            //            break;
            //        }
            //    }
            //}
            //List<int> lisS = s.ToList();
            //List<int> lisG = g.ToList();
            //lisG.Sort(delegate(int a, int b)
            //{
            //    return a.CompareTo(b);
            //});
            //lisS.Sort(delegate(int a, int b)
            //{
            //    return a.CompareTo(b);
            //});
            //for (int i = 0; i < lisG.Count; i++)
            //{
            //    for (int j = 0; j < lisS.Count; j++)
            //    {
            //        if (lisS[j] >= lisG[i])
            //        {
            //            lisS.RemoveAt(j);
            //            fitNum++;
            //            break;
            //        }
            //    }
            //}

            return fitNum;
        }
        public static bool LemonadeChange(int[] bills)
        {
            if (bills == null || bills.Length == 0) return false;

            int temp = 0;
            int five = 0, ten = 0;
            for (int i = 0; i < bills.Length; i++)
            {
                temp = bills[i];
                if (temp == 5)
                {
                    five += 1;
                }
                else if (temp == 10)
                {
                    if (five == 0)
                        return false;
                    five -= 1;
                    ten += 1;
                }
                else
                {
                    if ((five >= 1 && ten >= 1))
                    {
                        five -= 1;
                        ten -= 1;

                    }
                    else if (five >= 3)
                    {
                        five -= 3;

                    }
                    else
                    {
                        return false;
                    }
                }

            }

            return true;
        }
        public static int TwoCitySchedCost(int[][] costs)
        {
            if (costs == null) return 0;
            var newnums = costs.OrderBy(x => x[0] - x[1]).ToArray();
            int sum = 0;
            for (int i = 0; i < newnums.Length / 2; i++)
            {
                sum += newnums[i][0] + newnums[newnums.Length / 2 + i][1];
            }
            return sum;

            //int[] dp=new int[costs.Length];
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //int sum = 0;
            //for (int i = 0; i < costs.Length; i++)
            //{
            //    sum += costs[i][1];
            //    dp[i] = costs[i][0] - costs[i][1];
            //}

            //var lis = dp.ToList();
            //lis.Sort(delegate(int a, int b)
            //{
            //    return a.CompareTo(b);
            //});

        }
        public static IList<int> MinSubsequence(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            List<int> lis = new List<int>();
            if (nums.Length == 1)
            {
                lis.Add(nums[0]);
                return lis;
            }
            List<int> lis3 = nums.ToList();
            lis3.Sort(
                        delegate (int a, int b)
                        {
                            return a.CompareTo(b);
                        });
            int temp, j;
            for (int i = 1; i < nums.Length; i++)
            {
                temp = nums[i];
                for (j = i - 1; j >= 0 && nums[j] > temp; j--)
                {
                    nums[j + 1] = nums[j];
                }
                nums[j + 1] = temp;
            }
            int biggerSum = 0;
            int originSum = 0;
            for (int g = 0; g < lis3.Count; g++)
            {
                originSum += lis3[g];
            }
            for (int i = lis3.Count - 1; i >= 0; i--)
            {
                biggerSum += lis3[i];
                lis.Add(lis3[i]);
                originSum -= lis3[i];

                //int smallerSum = 0;
                //for (int k = i - 1; k >= 0; k--)
                //{
                //    smallerSum += nums[k];
                //}
                if (biggerSum > originSum)
                {
                    break;
                }
            }
            return lis;
            //int[] nums2=new int[nums.Length];
            //nums2[0] = nums[0];

            ////冒泡
            //int temp=0;
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[j]>nums[i])
            //        {
            //            temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }    
            //}

            //插入排序

        }

        public static int MinCostToMoveChips(int[] chips)
        {
            if (chips == null || chips.Length == 0) return 0;

            int even = 0;
            int odd = 0;
            for (int i = 0; i < chips.Length; i++)
            {
                if (chips[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            return even > odd ? odd : even;
        }
        public static int MinDeletionSize2(string[] A)
        {
            if (A == null || A.Length == 0) return 0;
            int result = 0;
            for (int i = 0; i < A[0].Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j][i] > A[j + 1][i])
                    {
                        result++;
                        break;
                    }
                }
            }
            return result;
        }
        public static int maxProfit0608_Baoli(int[] prices)
        {
            return calculate0608(prices, 0);
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int[] dp = new int[prices.Length];
            dp[0] = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                dp[i] = prices[i] - prices[i - 1] > 0 ? dp[i - 1] + prices[i] - prices[i - 1] : dp[i - 1];
            }
            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                max = dp[i] > max ? dp[i] : max;
            }
            return max;
        }

        public static int MaxProfit_TanXin(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;

            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                max += prices[i] - prices[i - 1] > 0 ? prices[i] - prices[i - 1] : 0;
            }
            return max;
        }

        public static int calculate0608(int[] prices, int s)
        {
            if (s >= prices.Length)
                return 0;
            int max = 0;
            for (int start = s; start < prices.Length; start++)
            {
                int maxprofit = 0;
                for (int i = start + 1; i < prices.Length; i++)
                {
                    if (prices[start] < prices[i])
                    {
                        int profit = calculate0608(prices, i + 1) + prices[i] - prices[start];
                        if (profit > maxprofit)
                            maxprofit = profit;
                    }
                }
                if (maxprofit > max)
                    max = maxprofit;
            }
            return max;
        }
        public static int MaxProfit0607(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int[] dp = new int[prices.Length];
            dp[0] = 0;
            int minNum = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                minNum = System.Math.Min(minNum, prices[i]);
                dp[i] = prices[i] - minNum;
            }

            int max = dp[0];
            for (int i = 0; i < dp.Length; i++)
            {
                max = max > dp[i] ? max : dp[i];
            }
            return max;
        }
        public static int MaxProfit3(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int[] dp = new int[prices.Length];
            dp[0] = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int minNum = prices[0];
                for (int j = 0; j < i; j++)
                {
                    minNum = minNum > prices[j] ? prices[j] : minNum;
                }
                dp[i] = prices[i] - minNum;
            }
            int max = dp[0];
            for (int i = 0; i < dp.Length; i++)
            {
                max = max > dp[i] ? max : dp[i];
            }
            return max;
        }
        public static int MaxSubArray3(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length == 1) return nums[0];

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = (dp[i - 1] + nums[i]) > nums[i] ? (dp[i - 1] + nums[i]) : nums[i];
            }
            int max = dp[0];
            for (int i = 0; i < dp.Length; i++)
            {
                max = dp[i] > max ? dp[i] : max;
            }
            return max;
        }
        public static int MaxProduct(int[] nums)
        {
            int max = 0;
            int currMax = 0;
            int currMin = 0;
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    temp = currMax;
                    currMax = currMin;
                    currMin = temp;
                }
                currMax = System.Math.Max(currMax * nums[i], nums[i]);
                currMin = System.Math.Min(currMin * nums[i], nums[i]);

                max = System.Math.Max(max, currMax);
            }
            return max;
        }
        public static int MaxProduct1(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length == 1) return nums[0];
            int[] dp1 = new int[nums.Length];//max
            int[] dp2 = new int[nums.Length];//min

            int[] dp11 = new int[nums.Length];//test
            int[] dp22 = new int[nums.Length];//test
            dp11[0] = nums[0];
            dp22[0] = nums[0];

            dp1[0] = nums[0];
            dp2[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dp11[i] = System.Math.Max(dp11[i - 1] * nums[i], dp22[i - 1] * nums[i]);
                dp22[i] = System.Math.Min(dp11[i - 1] * nums[i], dp22[i - 1] * nums[i]);

                dp1[i] = Max3(dp1[i - 1] * nums[i], dp2[i - 1] * nums[i], nums[i]);
                dp2[i] = Min3(dp1[i - 1] * nums[i], dp2[i - 1] * nums[i], nums[i]);

            }

            int max = -0;
            for (int i = 0; i < dp1.Length; i++)
            {
                max = max > dp1[i] ? max : dp1[i];
            }
            return max;
        }

        public static int Max3(int num1, int num2, int num3)
        {
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            return max;
        }
        public static int Min3(int num1, int num2, int num3)
        {
            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            return min;
        }
        public static int Rob2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }
            int arrlen = nums.Length > 3 ? nums.Length : 3;

            int[] dp = new int[arrlen];
            dp[0] = nums.Length > 0 ? nums[0] : 0;
            dp[1] = nums.Length > 1 ? (nums[1] > nums[0] ? nums[1] : nums[0]) : 0;
            int maxtemp12 = dp[0] > dp[1] ? dp[0] : dp[1];
            //dp[2] = nums[2] > maxtemp12 ? nums[2] : maxtemp12;
            int sum1 = 0;//偷1不透i
            int sum2 = 0;//不偷i偷i
            int[] tempArr1 = new int[nums.Length - 1];
            int[] tempArr2 = new int[nums.Length - 1];
            int max = 0;
            for (int i = 2; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    tempArr1[j] = nums[j];
                }
                for (int j = 1; j < nums.Length; j++)
                {
                    tempArr2[j - 1] = nums[j];
                }
                sum1 = Rob(tempArr1);
                sum2 = Rob(tempArr2);
                dp[i] = sum1 > sum2 ? sum1 : sum2;
            }
            for (int i = 0; i < dp.Length; i++)
            {
                max = dp[i] > max ? dp[i] : max;
            }

            return max;
        }
        public static int Massage(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int arrLen = nums.Length > 2 ? nums.Length : 2;
            int[] dp = new int[arrLen];
            dp[0] = nums[0];
            dp[1] = nums[1] > nums[0] ? nums[1] : nums[0];
            for (int i = 2; i < arrLen; i++)
            {
                dp[i] = dp[i - 2] + nums[i] > dp[i - 1] ? dp[i - 2] + nums[i] : dp[i - 1];
            }

            return dp[arrLen - 1];
        }
        public static int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int arrlen = nums.Length > 2 ? nums.Length : 2;

            int[] dp = new int[arrlen];
            dp[0] = nums.Length > 0 ? nums[0] : 0;
            dp[1] = nums.Length > 1 ? (nums[0] > nums[1] ? nums[0] : nums[1]) : 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 2; i < nums.Length; i++)
            {
                sum1 = nums[i] + dp[i - 2];
                sum2 = dp[i - 1];
                dp[i] = sum1 > sum2 ? sum1 : sum2;
            }
            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                max = dp[i] > max ? dp[i] : max;
            }

            return max;
        }
        public static int WaysToStep(int n)
        {
            int arrLen = n > 3 ? n : 3;
            int[] dp = new int[arrLen];

            dp[0] = 1;
            dp[1] = 2;
            dp[2] = 4;
            for (int i = 3; i < n; i++)
            {
                dp[i] = (dp[i - 1] + (dp[i - 2] + dp[i - 3]) % 1000000007) % 1000000007;
            }
            return dp[n - 1] % 1000000007;
        }
        public static bool IsSubsequence2(string s, string t)
        {
            int sLen = s.Length, tLen = t.Length;
            if (sLen > tLen) return false;
            if (sLen == 0) return true;
            bool[,] dp = new bool[sLen + 1, tLen + 1];
            //初始化
            for (int j = 0; j < tLen; j++)
            {
                dp[0, j] = true;
            }
            //dp
            for (int i = 1; i <= sLen; i++)
            {
                for (int j = 1; j <= tLen; j++)
                {
                    if (s.Substring(i - 1, 1) == t.Substring(j - 1, 1))
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                }
            }
            return dp[sLen, tLen];
            //string strResult = "";
            //HashSet<int> hs = new HashSet<int>();
            //int nextIndex = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = nextIndex; j < t.Length; j++)
            //    {
            //        if (t[j]==s[i]&&!hs.Contains(j))
            //        {
            //            strResult += t[j];
            //            nextIndex = j;
            //            hs.Add(j);
            //            break;    
            //        }

            //    }
            //}
            //if (strResult==s)
            //{
            //    return true;
            //}

            //return false;
        }
        public static string CutByteString(string str, int len)
        {
            string result = string.Empty;// 最终返回的结果
            if (string.IsNullOrEmpty(str)) { return result; }
            int byteLen = System.Text.Encoding.Default.GetByteCount(str);// 单字节字符长度
            int charLen = str.Length;// 把字符平等对待时的字符串长度
            int byteCount = 0;// 记录读取进度
            int pos = 0;// 记录截取位置
            if (byteLen > len)
            {
                for (int i = 0; i < charLen; i++)
                {
                    if (Convert.ToInt32(str.ToCharArray()[i]) > 255)// 按中文字符计算加2
                    { byteCount += 2; }
                    else// 按英文字符计算加1
                    { byteCount += 1; }
                    if (byteCount > len)// 超出时只记下上一个有效位置
                    {
                        pos = i;
                        break;
                    }
                    else if (byteCount == len)// 记下当前位置
                    {
                        pos = i + 1;
                        break;
                    }
                }
                if (pos >= 0)
                { result = str.Substring(0, pos); }
            }
            else
            { result = str; }
            return result;
        }

        public static string CutByteString(string str, int startIndex, int len)
        {
            string result = string.Empty;// 最终返回的结果
            if (string.IsNullOrEmpty(str)) { return result; }
            int byteLen = System.Text.Encoding.Default.GetByteCount(str);// 单字节字符长度
            int charLen = str.Length;// 把字符平等对待时的字符串长度
            if (startIndex == 0)
            { return CutByteString(str, len); }
            else if (startIndex >= byteLen)
            { return result; }
            else //startIndex < byteLen
            {
                int AllLen = startIndex + len;
                int byteCountStart = 0;// 记录读取进度
                int byteCountEnd = 0;// 记录读取进度
                int startpos = 0;// 记录截取位置                
                int endpos = 0;// 记录截取位置
                for (int i = 0; i < charLen; i++)
                {
                    if (Convert.ToInt32(str.ToCharArray()[i]) > 255)// 按中文字符计算加2
                    { byteCountStart += 2; }
                    else// 按英文字符计算加1
                    { byteCountStart += 1; }
                    if (byteCountStart > startIndex)// 超出时只记下上一个有效位置
                    {
                        startpos = i;
                        AllLen = startIndex + len - 1;
                        break;
                    }
                    else if (byteCountStart == startIndex)// 记下当前位置
                    {
                        startpos = i + 1;
                        break;
                    }
                }
                if (startIndex + len <= byteLen)//截取字符在总长以内
                {
                    for (int i = 0; i < charLen; i++)
                    {
                        if (Convert.ToInt32(str.ToCharArray()[i]) > 255)// 按中文字符计算加2
                        { byteCountEnd += 2; }
                        else// 按英文字符计算加1
                        { byteCountEnd += 1; }
                        if (byteCountEnd > AllLen)// 超出时只记下上一个有效位置
                        {
                            endpos = i;
                            break;
                        }
                        else if (byteCountEnd == AllLen)// 记下当前位置
                        {
                            endpos = i + 1;
                            break;
                        }
                    }
                    endpos = endpos - startpos;
                }
                else if (startIndex + len > byteLen)//截取字符超出总长
                {
                    endpos = charLen - startpos;
                }
                if (endpos >= 0)
                { result = str.Substring(startpos, endpos); }
            }
            return result;
        }
        public static int ClimbStairs(int n)
        {
            //var result = ClimbStairs(10);

            ////int[] arr = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            int[] jumpWays = new int[n];
            if (n >= 2)
            {

                jumpWays[0] = 1;
                jumpWays[1] = 2;
                for (int i = 2; i < n; i++)
                {
                    jumpWays[i] = jumpWays[i - 1] + jumpWays[i - 2];
                }

                return jumpWays[n - 1];
            }
            else
            {
                return n == 1 ? 1 : 2;
            }
        }

        public static int MinCostClimbingStairs(int[] cost)
        {

            int[] fee = new int[cost.Length];
            fee[0] = cost[0];
            fee[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                fee[i] = (fee[i - 1] > fee[i - 2] ? fee[i - 2] : fee[i - 1]) + cost[i];
            }
            return fee[cost.Length - 1] > fee[cost.Length - 2] ? fee[cost.Length - 2] : fee[cost.Length - 1];
        }

        public int FindRepeatNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 0);
                }
                else
                {
                    return nums[i];
                }
            }
            return 0;
        }
        public static int MaxSubArray2(int[] nums)
        {
            int[] maxNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                maxNums[i] = i == 0 ? nums[i] : (maxNums[i - 1] > 0 ? maxNums[i - 1] + nums[i] : maxNums[i] = nums[i]);
            }
            int max = maxNums[0];
            for (int i = 1; i < maxNums.Length; i++)
            {
                max = System.Math.Max(maxNums[i], max);
            }
            return max;
        }

        public static int jump(int n)
        {
            //无意义的情况
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            //数组用于存储跳n阶的跳法数
            int[] value = new int[n + 1];
            value[0] = 0;
            value[1] = 1;
            value[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                value[i] = value[i - 1] + value[i - 2];
            }
            int[,,] erweiarr = new int[2, 2, 2];
            return value[n];
        }

        public static int cutting(int n)
        {
            //长度小于等等于1没办法剪
            if (n <= 1)
                return 0;
            //对于f(2)，长度为2的绳子，只有一种剪法，剪成两段长度为1的绳子，剪后的乘积为1
            if (n == 2)
                return 1;
            //对于f(3)，长度为3的绳子，只有一种剪法，剪成两段长度为1和2的绳子，但剪后的乘积为2
            if (n == 3)
                return 2;
            int max = 0;
            //数组用于存储绳子乘积最大值
            int[] value = new int[n + 1];
            value[0] = 0;
            value[1] = 1;
            //剪后的乘积为1，比自身更小；如果不是求自身的值，要求乘积最大值的话就没必要剪
            value[2] = 2;
            //剪后的乘积为2，比自身更小；如果不是求自身的值，要求乘积最大值的话也没必要剪
            value[3] = 3;
            //从f(4)开始迭代
            for (int i = 4; i <= n; i++)
            {
                max = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    int val = value[j] * value[i - j];
                    max = val > max ? val : max;
                }
                value[i] = max;
            }
            max = value[n];
            return max;
        }
        //public static int Rob(int[] nums)
        //{
        //    int sum1 = 0;
        //    int sum2 = 0;
        //    for (int i = 0; i < nums.Length; i=i+2)
        //    {
        //        sum1 += nums[i];
        //        sum2=i+1<nums.Length?sum2+ nums[i+1]:sum2;
        //    }
        //    //for (int i = 1; i < nums.Length; i = i + 2)
        //    //{
        //    //    sum2 += nums[i];
        //    //}
        //    return sum1>sum2?sum1:sum2;
        //}
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] target = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (target[index[i]] != 0)
                {
                    // target[index[i]]开始后面全部后移一位
                    for (int j = target.Length - 1; j > index[i]; j--)
                    {
                        target[j] = target[j - 1];
                    }
                    //target[index[i] + 1] = target[index[i]];
                    target[index[i]] = nums[i];
                }
                else
                {
                    target[index[i]] = nums[i];
                }

            }
            return target;
        }
        public static ListNode GetKthFromEnd2(ListNode head, int k)
        {
            int listNodeLenth = 1;
            ListNode temp = head;
            do
            {
                if (temp.next == null)
                {
                    return temp;
                }
                listNodeLenth++;
                temp = temp.next;
            } while (temp.next != null);
            int foreachTime = listNodeLenth - k;
            int currFore = 0;
            ListNode temp2 = head;
            for (int i = 0; i < foreachTime; i++)
            {
                if (temp2.next == null)
                {
                    return temp2;
                }
                temp2 = temp2.next;
            }

            return temp2;
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return dfs(nums, 0, nums.Length - 1);
        }

        private static TreeNode dfs(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = (left + right + 1) / 2;
            TreeNode ptr = new TreeNode(nums[mid]); //填充根节点
            ptr.left = dfs(nums, left, mid - 1);    //构造左子树
            ptr.right = dfs(nums, mid + 1, right);  //构造右子树
            return ptr;
        }

        public static int maxProfit2(int[] prices, int fee)
        {
            if (prices.Length < 2)
                return 0;
            int ans = 0;

            //第一天，买它，握在手里。
            int in_hand = prices[0];
            for (int i = 1; i < prices.Length; i++)
                //今天的比我手里的低价，第一种反悔
                if (prices[i] < in_hand)
                    in_hand = prices[i];
                //今天的比我手里的高价，我要卖出！
                else if (prices[i] > in_hand)
                {
                    //差额累加起来
                    ans += prices[i] - in_hand;
                    //记录一下这天的卖出价，方便我决定1.买入明天的 或者 2.第二种反悔
                    //明天比这个记录低就用上面那个if来进行买入明天的
                    //明天比这个记录高，通过这个记录来再累加差额一次达到第二种反悔的效果
                    in_hand = prices[i];
                }
            return ans;

        }

        public static int BalancedStringSplit(string s)
        {
            List<string> listStr = new List<string>();
            string strTemp = "";
            int balanceNum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string strTemp2 = s[i].ToString();
                switch (strTemp2)
                {
                    case "L":
                        balanceNum--;
                        break;
                    case "R":
                        balanceNum++;
                        break;
                    default:
                        break;
                }
                strTemp += strTemp2;
                if (balanceNum == 0)
                {
                    listStr.Add(strTemp);
                    strTemp = "";
                    continue;
                }
            }
            return listStr.Count;
        }
        public static int GetDecimalValue(ListNode head)
        {
            int sum = 0;
            do
            {
                sum = sum << 1;
                sum += head.val;
                head = head.next;

            } while (head != null);

            return sum;
            //int wei = 0;
            //int sum = 0;
            //List<int> nodeValList = new List<int>();
            //do
            //{
            //    nodeValList.Add(head.val);
            //    head= head.next;
            //    wei++;
            //} while (head!=null);
            //for (int i = 0; i < nodeValList.Count; i++)
            //{
            //    double temp=System.Math.Pow(2, wei-1);
            //    sum += nodeValList[i] * ((Int32)temp);
            //    wei--;
            //}
            //return sum;
        }
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode resultTree = new TreeNode(val);
            if (root.val == val)
            {
                //resultTree.left = root.left;
                //resultTree.right = root.right;
                //return resultTree;
                return root;

            }
            if (root.left != null)
            {

                TreeNode LeftResult = SearchBST(root.left, val);
                if (LeftResult != null)
                {
                    return LeftResult;
                }
            }
            if (root.right != null)
            {
                TreeNode RightResult = SearchBST(root.right, val);
                if (RightResult != null)
                {
                    return RightResult;
                }

            }
            return null;
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> listResult = new List<int>();
            for (int i = left; i < right + 1; i++)
            {
                int currNum = i;
                int tempNum = i;
                bool isZero = false;
                List<int> eachNum = new List<int>();
                do
                {
                    int temp = tempNum % 10;
                    if (temp == 0)
                    {
                        isZero = true;
                        break;

                    }
                    if (temp > 0)
                    {
                        eachNum.Add(temp);
                    }
                    tempNum = tempNum / 10;
                }
                while (tempNum > 0);
                if (isZero)
                {
                    continue;
                }
                bool isRightNum = true;
                foreach (var item in eachNum)
                {
                    if (currNum % item != 0)
                    {
                        isRightNum = false;
                        break;
                    }
                }

                if (isRightNum)
                {
                    listResult.Add(currNum);
                }
            }

            return listResult;
        }
        public static Stack<int> GetSumZeroArray(int n)
        {
            Stack<int> sta1 = new Stack<int>();
            int sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sta1.Push(i);
                sum += i;
            }
            sta1.Push(-sum);
            return sta1;
        }
    }


    /// <summary>
    /// 933. 最近的请求次数 https://leetcode-cn.com/problems/number-of-recent-calls/
    /// </summary>
    public class RecentCounter
    {
        Queue<int> queue;
        public RecentCounter()
        {
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);
            while (queue.First() < t - 3000)
            {
                queue.Dequeue();
            }
            return queue.Count();
        }
    }
    /// <summary>
    ///面试题 03.04. 化栈为队  https://leetcode-cn.com/problems/implement-queue-using-stacks-lcci/
    /// </summary>
    public class MyQueue
    {
        Stack<int> stPush, stPop;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stPop = new Stack<int>();
            stPush = new Stack<int>();

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stPush.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (stPop.Count == 0)
            {
                while (stPush.Count > 0)
                {
                    stPop.Push(stPush.Pop());
                }
            }
            return stPop.Pop();

        }

        /** Get the front element. */
        public int Peek()
        {
            if (stPop.Count == 0)
            {
                while (stPush.Count > 0)
                {
                    stPop.Push(stPush.Pop());
                }
            }
            return stPop.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stPop.Count == 0 && stPush.Count == 0;
        }
    }
    public class MinStack
    {
        Stack<int> stMain, stAssist;
        /** initialize your data structure here. */
        public MinStack()
        {
            stMain = new Stack<int>();
            stAssist = new Stack<int>();
        }

        public void Push(int x)
        {
            stMain.Push(x);
            if (stAssist.Count == 0 || stAssist.Peek() >= x)
            {
                stAssist.Push(x);
            }
        }

        public void Pop()
        {

            int p = stMain.Pop();
            if (stAssist.Peek() == p)
            {
                stAssist.Pop();
            }
        }

        public int Top()
        {
            return stMain.Peek();
        }

        public int GetMin()
        {
            return stAssist.Peek();
        }
    }
    public class MyHashSet
    {
        private int[] arr;
        /** Initialize your data structure here. */
        public MyHashSet()
        {
            arr = new int[1000001];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
        }

        public void Add(int key)
        {
            arr[key] = 1;
        }

        public void Remove(int key)
        {
            arr[key] = -1;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return arr[key] == 1;
        }
    }

    public class MyHashMap
    {
        private int[] arr;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            arr = new int[1000001];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            arr[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return arr[key];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            arr[key] = -1;
        }
    }

    public class Foo
    {
        /*
         * 第一种方式
        private AutoResetEvent _second = new AutoResetEvent(false);
        private AutoResetEvent _three = new AutoResetEvent(false);
        

        public Foo()
        {

        }

        public void First(Action printFirst)
        {
            printFirst();
            _second.Set();//通知第二个可以执行了
        }

        public void Second(Action printSecond)
        {
            _second.WaitOne();//等待通知
            printSecond();
            _three.Set();//通知第三个可以执行了

        }

        public void Third(Action printThird)
        {
            _three.WaitOne();//等待通知
            printThird();
        }
        */
        //第二种方式，使用自旋锁
        private SpinWait _spinWait = new SpinWait();
        private int _continueCondition = 1;

        public Foo()
        {

        }
        public void First(Action printFirst)
        {
            printFirst();
            Thread.VolatileWrite(ref _continueCondition, 2);//写栅栏
        }

        public void Second(Action printSecond)
        {

            while (Thread.VolatileRead(ref _continueCondition) != 2)
            {
                _spinWait.SpinOnce();
            }
            printSecond();
            Thread.VolatileWrite(ref _continueCondition, 3);//写栅栏
        }

        public void Third(Action printThird)
        {
            while (Thread.VolatileRead(ref _continueCondition) != 3)
            {
                _spinWait.SpinOnce();
            }
            printThird();
            Thread.VolatileWrite(ref _continueCondition, 1);//写栅栏
        }
    }

    /// <summary>
    /// 面试题 03.06. 动物收容所  https://leetcode-cn.com/problems/animal-shelter-lcci/
    /// </summary>

    public class AnimalShelf
    {
        LinkedList<int[]> queueCat;
        LinkedList<int[]> queueDog;
        public AnimalShelf()
        {
            queueCat = new LinkedList<int[]>();
            queueDog = new LinkedList<int[]>();
        }

        public void Enqueue(int[] animal)
        {
            if (animal[1] == 0)
            {
                queueCat.AddLast(animal);
            }
            else
            {
                queueDog.AddLast(animal);
            }
        }

        public int[] DequeueAny()
        {
            if (queueCat.Count > 0 && queueDog.Count > 0)
            {
                if (queueCat.First()[0] < queueDog.First()[0])
                {
                    var cat = queueCat.First();
                    queueCat.RemoveFirst();
                    return cat;
                }
                else
                {
                    var dog = queueDog.First();
                    queueDog.RemoveFirst();
                    return dog;
                }
                return new int[] { -1, -1 };
            }
            if (queueCat.Count > 0)
            {
                var cat = queueCat.First();
                queueCat.RemoveFirst();
                return cat;
            }
            if (queueDog.Count > 0)
            {
                var dog = queueDog.First();
                queueDog.RemoveFirst();
                return dog;
            }
            return new int[] { -1, -1 };
        }

        public int[] DequeueDog()
        {
            if (queueDog.Count > 0)
            {
                var dog = queueDog.First();
                queueDog.RemoveFirst();
                return dog;
            }
            return new int[] { -1, -1 };
        }

        public int[] DequeueCat()
        {
            if (queueCat.Count > 0)
            {
                var cat = queueCat.First();
                queueCat.RemoveFirst();
                return cat;
            }
            return new int[] { -1, -1 };
        }
    }

    /// <summary>
    /// 面试题 03.01. 三合一 https://leetcode-cn.com/problems/three-in-one-lcci/
    /// </summary>
    public class TripleInOne
    {
        int[] stack;
        int[] top;
        public TripleInOne(int stackSize)
        {
            stack = new int[stackSize * 3];
            top = new int[3];
            for (int i = 0; i < 3; i++)
            {
                top[i] = i;
            }
        }

        public void Push(int stackNum, int value)
        {
            if (top[stackNum] < stack.Length)
            {

                stack[top[stackNum]] = value;
                top[stackNum] += 3;
            }
        }

        public int Pop(int stackNum)
        {

            if (top[stackNum] < 3)
            {
                return -1;
            }
            top[stackNum] -= 3;
            return stack[top[stackNum]];
        }

        public int Peek(int stackNum)
        {

            if (top[stackNum] < 3)
            {
                return -1;
            }
            return stack[top[stackNum] - 3];
        }

        public bool IsEmpty(int stackNum)
        {
            return top[stackNum] - 3 < 0;
        }
    }

}

