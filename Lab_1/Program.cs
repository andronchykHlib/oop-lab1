using Lab_1;

// Task 1


// SurfaceEquation seq = new SurfaceEquation(1 ,2, 1, 1);
// Console.WriteLine(string.Join(',', seq.GetAllCoefficients()));
// Console.WriteLine(seq.HasPoint(2,4,9));
// seq.GetAxisIntersection();

// Task 2

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("1 - test Disk\n2 - test Ball\n0 - exit");
ExecutionTypes executionType = (ExecutionTypes)int.Parse(Console.ReadLine()) - 1;

switch (executionType)
{
  case ExecutionTypes.Disk:
    TDisk disk = new TDisk();
    new DiskTest<TDisk>(disk).Execute();
    return;
  case ExecutionTypes.Ball:
    TBall ball = new TBall();
    new DiskTest<TBall>(ball).Execute();
    return;
}