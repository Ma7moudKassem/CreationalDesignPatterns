// Use builder pattern in client

Director director = new Director();
IBuilder carBuilder = new Car("Toyota");
IBuilder motorCycleBuilder = new MotorCycle("Yamaha");

director.Construct(carBuilder);
Product car = carBuilder.GetVehicle();
Console.WriteLine($"Car {car.Show()}");

director.Construct(motorCycleBuilder);
Product motorCycle = motorCycleBuilder.GetVehicle();
Console.WriteLine($"Motor Cycle {motorCycle.Show()}");