using Lab_1;

string userInput = "";
TDisk disk = new TDisk();
TBall ball = new TBall();

var diskTests = new DiskTest<TBall>(ball);

Dictionary<string, Action> diskMenu = new Dictionary<string, Action>
{
  { "1", diskTests.TestParamsConstructor },
  { "2", diskTests.TestCopyConstructor },
  { "3", diskTests.TestDefaultConstructor },
  { "4", diskTests.TestSetRadius },
  { "5", diskTests.TestSetCenter },
  { "6", diskTests.TestHasPoint },
  { "7", diskTests.TestMultiplication },
};

while (userInput != "0")
{
  userInput = Console.ReadLine();

  if (diskMenu.ContainsKey(userInput))
  {
    diskMenu[userInput].Invoke();
  }
}