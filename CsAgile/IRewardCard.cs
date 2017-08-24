namespace CsAgile
{
    public interface IRewardCard
    {
        int RewardPoints { get; }

        void CalculateRewardPoints(decimal transactionAmount, decimal accountBalance);
    }
}