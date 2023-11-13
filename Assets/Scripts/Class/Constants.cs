namespace EMSYS.TowerDefence
{
    public static class Constants
    {
        public struct IntArr
        {
            public static readonly int[,] enemyX = new int[11, 2]
            { {-6, -6}, {-6, 6}, {6, 6}, {2, 6}, {2, 2}, {2, 6}, {6, 6}, {-6, 6}, {-6, -6}, {-6, -2}, {-2, -2} };

            public static readonly int[,] enemyY = new int[11, 2]
            {{2,6},{2,2},{2,6},{6,6},{-6,6},{-6,-6},{-6,-2},{-2,-2},{-6,-2},{-6,-6},{-6,7}};
        }
        public struct Path
        {
            public const string enemey = "Prefab/Enemy/Test";
        }
        public struct Errormsg
        {
            public const string pool_not_contains_key =
                "해당 이름으로 등록된 풀링 데이터가 존재하지 않습니다.";
            public const string pool_already_contains_key =
                "이미 해당 이름으로 등록된 폴링 데이터가 존재합니다.";
            public const string pool_size_error =
                "defaultCapacity는 maxSize 보다 작을 수 없습니다.";
            
        }
    }
}