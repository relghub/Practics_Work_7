namespace Practics_Work_7
{
    internal class SquareEquation
    {
        internal int coeffA;
        internal int coeffB;
        internal int coeffC;
        internal float Discr;
        internal bool RealNumPresence;
        public SquareEquation(int coeffA, int coeffB, int coeffC)
        {
            this.coeffA = coeffA;
            this.coeffB = coeffB;
            this.coeffC = coeffC;
            Discr = DiscriminantEval(coeffA, coeffB, coeffC);
            RealNumPresence = (Discr >= 0);
        }
        internal static float DiscriminantEval(int coeffA,
                                int coeffB,
                                int coeffC)
        {
            return coeffB * coeffB - 4 * coeffA * coeffC;
        }
        internal double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return EvalFirstRoot(coeffA, 
                                         coeffB,
                                         Discr,
                                         RealNumPresence);
                }
                else if (i == 1)
                {
                    return EvalSecondRoot(coeffA,
                                          coeffB,
                                          Discr,
                                          RealNumPresence);
                }
                else
                {
                    Console.WriteLine("Неможлива операція: " +
                      "індекс більший за кількість коренів.");
                    return -1;
                }
            }
        }
        internal static double EvalFirstRoot(int A,
                                            int B,
                                            float D,
                                            bool Real)
        {
            if (Real)
            {
                return (-B - Math.Sqrt(D)) / 2 * A;
            }
            else
            {
                Console.WriteLine("Не існує.");
                return -1;
            }
        }
        internal static double EvalSecondRoot(int A,
                                             int B,
                                             float D,
                                             bool Real)
        {
            if (Real)
            {
                return (-B + D) / 2 * A;
            }
            else
            {
                Console.WriteLine("Не існує.");
                return -1;
            }
        }
    }
}
