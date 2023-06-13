namespace Practics_Work_7
{
    internal class GeomProgression
    {
        internal double iteratedNum;
        internal double step;
        internal double progressSum;
        internal GeomProgression(double iteratedNum,
                                 double step)
        {
            this.iteratedNum = iteratedNum;
            this.step = step;
        }
        internal string this[int maxIter]
        {
            get
            {
                if (maxIter > 0)
                {
                    return StringOutput(step, iteratedNum, maxIter);
                }
                else
                {
                    return "Недопустимий індекс. Повторіть спробу.";
                }
            }
        }
        internal double NumberAtIndex(double step,
                                      double iteratedNum,
                                      int maxIter)
        {
            return iteratedNum * Math.Pow(step, maxIter);
        }
        internal double ProgressSum(double step,
                                    double iteratedNum,
                                    int maxIter)
        {
            for (int i = 0; i < step; i++)
            {
                progressSum += NumberAtIndex(step, iteratedNum, maxIter);
            }
            return progressSum;
        }
        internal string StringOutput(double step,
                                      double iteratedNum,
                                      int maxIter)
        {
            string finalString = $"Число за індексом {maxIter}: " +
                   $"{NumberAtIndex(step, iteratedNum, maxIter):.000}" +
                   "\nСума елементів такої геометричної прогресії: " +
                   $"{ProgressSum(step, iteratedNum, maxIter):.000}.";
            return finalString;
        }
    }
}
