namespace VirtualDars.DesignPatterns.TemplateMethod
{
    public abstract class HouseTemplate
    {
        protected HouseSettings _houseSettings = new();
        protected Guid _houseGuid = Guid.Empty;

        public int NumberOfFloors { get; set; }
        public int NumberOfRooms { get; set; }
        public string Location { get; set; }

        // Template method ichida bajarilishi kerak bo'lgan algorithm, ya'ni
        // ishlarning ketam-ketligi yoziladi:
        public Guid BuildHouse(HouseSettings settings)
        {
            _houseSettings = settings;
            BuildFoundation();
            if (settings.HasBasement)
            {
                BuildBasement();
            }
            BuildPillars();
            BuildWalls();
            BuildRoof();
            InstallWindows();
            InstallDoors();
            PaintWalls();
            PlaceOnMap();
            Save();
            Console.WriteLine("Uy qurilishi yakunlandi.");
            return _houseGuid;
        }

        protected virtual void BuildFoundation()
        {
            Console.WriteLine("Uyning poydevori qurilyapti...");
            // todo
        }

        protected abstract void BuildPillars();
        protected virtual void BuildBasement()
        {
            Console.WriteLine("Uyning yerto'lasi qurilyapti...");
            // todo
        }
        protected abstract void BuildWalls();
        protected abstract void BuildRoof();
        protected abstract void InstallWindows();
        protected abstract void InstallDoors();
        protected virtual void PaintWalls()
        {
            // todo
        }       
        protected virtual void PlaceOnMap()
        {
            OnBeforePlaceOnMap();
            Console.WriteLine("Uy haritaga joylanyapti...");
            // todo
            OnAfterPlaceOnMap();
        }
        protected virtual void OnBeforePlaceOnMap()
        {
            // todo
        }

        protected virtual void OnAfterPlaceOnMap()
        {
            // todo
        }
        protected virtual void Save()
        {
            Console.WriteLine("Uy ma'lumotlar omboriga saqlanyapti...");
            // todo
            _houseGuid = Guid.NewGuid();
        }
    }
}

public class HouseSettings
{
    public int NumberOfFloors { get; set; }
    public bool HasBasement { get; set; }
}