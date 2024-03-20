using taks3;


    LiquidContainer liquidContainer1 = new LiquidContainer(100.0, 100.0, 20.0, 200.0,200,true);
    Console.WriteLine(liquidContainer1.ToString());
    LiquidContainer liquidContainer2 = new LiquidContainer(110.0, 100.0, 20.0, 200.0,200,false);
    Console.WriteLine(liquidContainer2.ToString());
   liquidContainer2.loadwithMass(185);
   Console.WriteLine(liquidContainer2.ToString());
   liquidContainer1.loadwithMass(185);
   Console.WriteLine(liquidContainer1.ToString());
   // GasContainer gasContainer1= new GasContainer(100.0, 100.0, 20.0, 200.0,200);
    //Console.WriteLine(gasContainer1);