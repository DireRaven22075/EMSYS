namespace EMSYS.TowerDefence
{
    public enum TowerStatus : int
    {
        /// <summary>
        /// 평상적인 게임 필드에서의 상태
        /// </summary>
        Idle = 0,
        /// <summary>
        /// 상점 안에 있는 상태 (타워가 동작하지 않아야 한다)
        /// </summary>
        InShop = 1,
        /// <summary>
        /// 플레이어가 손에 잡고 옮기는 상태 (타워가 동작하지 않아야 한다)
        /// </summary>
        Grabbing = 2,
        /// <summary>
        /// 플레이어가 상점에서 잡아 구매하려는 상태 (타워가 동작하지 않아야 한다)
        /// </summary>
        Buying = 3,
        /// <summary>
        /// 플레이어가 타워를 손에 잡고 판매하려는 상태 (타워가 동작하지 않아야 한다)
        /// </summary>
        Selling = 4,
        /// <summary>
        /// 플레이어가 타워를 손에 잡고 합쳐 업그레이드 하려는 상태 (타워가 동작하지 않아야 한다)
        /// </summary>
        Merging = 5,
        /// <summary>
        /// 구매 도중 다시 상점으로 갖다놔 구매를 취소하려는 상태 (타워가 동작하지 않아야 한다)
        /// </summary>
        BuyingCancel = 6,

    }
}