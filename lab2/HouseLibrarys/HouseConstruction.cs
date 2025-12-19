namespace HouseLibrarys
{
    public interface IHouse
    {
        string Material { get; }
        string GetBuildReport();
    }

    public interface IHouseCompany
    {
        IHouse CreateHouse();
        string StartProject();
    }

    public class WoodenHouse : IHouse
    {
        public string Material => "Дерево (дуб/сосна)";
        public string GetBuildReport() => "Зведено екологічний будинок зі зрубу. Використано антисептик для захисту дерева.";
    }

    public class BrickHouse : IHouse
    {
        public string Material => "Цегла (червона/силікатна)";
        public string GetBuildReport() => "Зведено капітальний цегляний будинок. Проведено армування фундаменту.";
    }

    public class GlassHouse : IHouse
    {
        public string Material => "Скло та Алюміній";
        public string GetBuildReport() => "Зведено будинок у стилі Хай-тек. Встановлено енергоефективні панорамні склопакети.";
    }

    public abstract class HouseCompanyBase : IHouseCompany
    {
        public abstract IHouse CreateHouse();

        public string StartProject()
        {
            var house = CreateHouse();
            return $"[ПРОЄКТ ЗАПУЩЕНО]\nМатеріал: {house.Material}\nРезультат: {house.GetBuildReport()}";
        }
    }

    public class WoodConstructionCompany : HouseCompanyBase
    {
        public override IHouse CreateHouse() => new WoodenHouse();
    }

    public class BrickConstructionCompany : HouseCompanyBase
    {
        public override IHouse CreateHouse() => new BrickHouse();
    }

    public class GlassConstructionCompany : HouseCompanyBase
    {
        public override IHouse CreateHouse() => new GlassHouse();
    }
}
