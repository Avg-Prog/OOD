using DI_Spaceship;

FuelEngine firstEngine = new FuelEngine(850);
FuelEngine secondEngine = new FuelEngine(1500);
WarpEngine warpEngine = new WarpEngine();

Spaceship myShip = new Spaceship();

myShip.Engine = firstEngine;
myShip.Fly();
myShip.Engine = secondEngine;
myShip.Fly();
myShip.Engine = warpEngine;
myShip.Fly();