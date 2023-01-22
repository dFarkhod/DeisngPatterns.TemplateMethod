using VirtualDars.DesignPatterns.TemplateMethod;

WoodenHouse myWoodenHouse = new ();
myWoodenHouse.BuildHouse(new HouseSettings {  NumberOfFloors = 2, HasBasement=true});