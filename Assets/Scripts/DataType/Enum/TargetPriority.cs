namespace EMSYS.TowerDefence
{
    public enum TargetPriority
    {
        //가장 위험한 (진행도가 높은 적 우선 타격)
        Default,
        /// <summary>
        /// 가장 가까운 적 우선 타격 (진행도랑 상관 없다)
        /// </summary>
        Distance,
        /// <summary>
        /// 가장 체력이 많은 적 우선 타격 (진행도랑 상관 없다)
        /// </summary>
        HealthPoint,
        /// <summary>
        /// 무작위 적 타격 (진행도랑 상관 없다)
        /// </summary>
        Random
    }
}