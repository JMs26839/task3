using taks3;


     LiquidContainer liquidContainer1 = new LiquidContainer(100.0, 100.0, 20.0, 200.0,200,true);
   //  Console.WriteLine(liquidContainer1.ToString());
     LiquidContainer liquidContainer2 = new LiquidContainer(110.0, 100.0, 20.0, 200.0,200,false);
   //  Console.WriteLine(liquidContainer2.ToString());
   // liquidContainer2.loadwithMass(185);
   // Console.WriteLine(liquidContainer2.ToString());
   // liquidContainer1.loadwithMass(185);
   // Console.WriteLine(liquidContainer1.ToString());
   GasContainer gasContainer1= new GasContainer(100.0, 100.0, 20.0, 200.0,200,200.0);
    Console.WriteLine(gasContainer1);
    gasContainer1.loadwithMass(200.0);
    gasContainer1.emptyCargo(10.5,10.5);
    Ship ship= new Ship(40.0,500,40000.0);
    ship.loadContainer(liquidContainer1);
    ship.loadContainer(liquidContainer2);
    Console.WriteLine(ship.GetTotalMass());
    ship.DisplayShipDetails();
    ship.DisplayContainersInfo();