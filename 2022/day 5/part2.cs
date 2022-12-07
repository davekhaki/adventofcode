string stacksInput = "                        [Z] [W] [Z]\r\n        [D] [M]         [L] [P] [G]\r\n    [S] [N] [R]         [S] [F] [N]\r\n    [N] [J] [W]     [J] [F] [D] [F]\r\n[N] [H] [G] [J]     [H] [Q] [H] [P]\r\n[V] [J] [T] [F] [H] [Z] [R] [L] [M]\r\n[C] [M] [C] [D] [F] [T] [P] [S] [S]\r\n[S] [Z] [M] [T] [P] [C] [D] [C] [D]\r\n 1   2   3   4   5   6   7   8   9";
string movesInput = "move 3 from 9 to 6\r\nmove 7 from 6 to 2\r\nmove 1 from 1 to 5\r\nmove 7 from 7 to 1\r\nmove 3 from 9 to 7\r\nmove 1 from 9 to 1\r\nmove 1 from 7 to 2\r\nmove 11 from 1 to 8\r\nmove 9 from 8 to 2\r\nmove 1 from 6 to 7\r\nmove 3 from 7 to 3\r\nmove 7 from 3 to 4\r\nmove 9 from 8 to 7\r\nmove 3 from 3 to 1\r\nmove 2 from 5 to 2\r\nmove 6 from 7 to 3\r\nmove 1 from 1 to 7\r\nmove 1 from 9 to 2\r\nmove 1 from 5 to 3\r\nmove 1 from 8 to 2\r\nmove 2 from 7 to 5\r\nmove 1 from 1 to 4\r\nmove 3 from 5 to 8\r\nmove 2 from 8 to 7\r\nmove 1 from 8 to 9\r\nmove 7 from 3 to 1\r\nmove 8 from 2 to 5\r\nmove 3 from 7 to 3\r\nmove 1 from 5 to 1\r\nmove 1 from 9 to 6\r\nmove 1 from 7 to 4\r\nmove 1 from 6 to 3\r\nmove 1 from 7 to 1\r\nmove 9 from 4 to 5\r\nmove 8 from 1 to 2\r\nmove 3 from 3 to 2\r\nmove 1 from 1 to 6\r\nmove 7 from 5 to 6\r\nmove 1 from 1 to 5\r\nmove 1 from 3 to 5\r\nmove 21 from 2 to 3\r\nmove 8 from 6 to 3\r\nmove 5 from 4 to 9\r\nmove 9 from 3 to 8\r\nmove 17 from 3 to 5\r\nmove 6 from 2 to 1\r\nmove 2 from 9 to 1\r\nmove 3 from 3 to 6\r\nmove 3 from 2 to 5\r\nmove 7 from 8 to 2\r\nmove 3 from 6 to 9\r\nmove 2 from 2 to 4\r\nmove 1 from 2 to 6\r\nmove 2 from 2 to 6\r\nmove 2 from 6 to 5\r\nmove 1 from 6 to 1\r\nmove 2 from 2 to 7\r\nmove 1 from 8 to 2\r\nmove 4 from 9 to 1\r\nmove 4 from 1 to 6\r\nmove 1 from 8 to 5\r\nmove 3 from 6 to 9\r\nmove 1 from 9 to 1\r\nmove 2 from 9 to 2\r\nmove 4 from 4 to 5\r\nmove 1 from 7 to 8\r\nmove 1 from 7 to 5\r\nmove 8 from 1 to 8\r\nmove 1 from 1 to 9\r\nmove 1 from 6 to 8\r\nmove 2 from 2 to 6\r\nmove 1 from 1 to 3\r\nmove 1 from 2 to 5\r\nmove 1 from 3 to 4\r\nmove 3 from 9 to 4\r\nmove 4 from 4 to 1\r\nmove 29 from 5 to 1\r\nmove 2 from 6 to 3\r\nmove 2 from 3 to 5\r\nmove 2 from 5 to 9\r\nmove 7 from 8 to 1\r\nmove 3 from 8 to 6\r\nmove 6 from 1 to 6\r\nmove 2 from 9 to 8\r\nmove 2 from 5 to 3\r\nmove 3 from 5 to 6\r\nmove 2 from 5 to 6\r\nmove 1 from 5 to 1\r\nmove 2 from 3 to 9\r\nmove 1 from 8 to 6\r\nmove 1 from 8 to 3\r\nmove 1 from 3 to 5\r\nmove 5 from 1 to 5\r\nmove 5 from 6 to 2\r\nmove 25 from 1 to 9\r\nmove 9 from 9 to 3\r\nmove 7 from 6 to 8\r\nmove 9 from 5 to 9\r\nmove 2 from 6 to 5\r\nmove 6 from 9 to 7\r\nmove 1 from 6 to 8\r\nmove 3 from 2 to 1\r\nmove 3 from 8 to 1\r\nmove 5 from 9 to 6\r\nmove 3 from 9 to 1\r\nmove 4 from 6 to 9\r\nmove 2 from 7 to 4\r\nmove 1 from 4 to 1\r\nmove 1 from 6 to 2\r\nmove 7 from 1 to 6\r\nmove 1 from 9 to 8\r\nmove 9 from 3 to 9\r\nmove 5 from 1 to 7\r\nmove 1 from 5 to 7\r\nmove 3 from 1 to 7\r\nmove 3 from 6 to 7\r\nmove 8 from 9 to 1\r\nmove 3 from 7 to 3\r\nmove 1 from 5 to 6\r\nmove 3 from 1 to 7\r\nmove 4 from 1 to 4\r\nmove 2 from 8 to 5\r\nmove 1 from 4 to 2\r\nmove 3 from 2 to 7\r\nmove 2 from 6 to 4\r\nmove 1 from 1 to 2\r\nmove 18 from 7 to 5\r\nmove 1 from 7 to 5\r\nmove 1 from 2 to 3\r\nmove 4 from 5 to 9\r\nmove 1 from 2 to 1\r\nmove 2 from 3 to 9\r\nmove 2 from 3 to 4\r\nmove 2 from 6 to 5\r\nmove 1 from 8 to 3\r\nmove 4 from 9 to 7\r\nmove 1 from 1 to 9\r\nmove 3 from 5 to 2\r\nmove 2 from 8 to 6\r\nmove 2 from 6 to 1\r\nmove 5 from 5 to 7\r\nmove 7 from 9 to 7\r\nmove 11 from 5 to 9\r\nmove 3 from 7 to 6\r\nmove 6 from 4 to 9\r\nmove 5 from 7 to 3\r\nmove 6 from 3 to 6\r\nmove 2 from 1 to 2\r\nmove 2 from 4 to 9\r\nmove 6 from 9 to 2\r\nmove 1 from 7 to 5\r\nmove 10 from 2 to 9\r\nmove 4 from 9 to 4\r\nmove 1 from 4 to 3\r\nmove 31 from 9 to 3\r\nmove 1 from 9 to 4\r\nmove 6 from 3 to 8\r\nmove 1 from 5 to 8\r\nmove 5 from 6 to 4\r\nmove 4 from 3 to 2\r\nmove 1 from 4 to 6\r\nmove 22 from 3 to 7\r\nmove 6 from 4 to 7\r\nmove 4 from 6 to 2\r\nmove 8 from 8 to 1\r\nmove 3 from 2 to 8\r\nmove 2 from 1 to 9\r\nmove 1 from 2 to 6\r\nmove 3 from 2 to 5\r\nmove 2 from 5 to 4\r\nmove 2 from 6 to 4\r\nmove 24 from 7 to 4\r\nmove 1 from 7 to 4\r\nmove 2 from 1 to 5\r\nmove 2 from 9 to 6\r\nmove 10 from 4 to 6\r\nmove 3 from 1 to 6\r\nmove 6 from 7 to 1\r\nmove 2 from 2 to 3\r\nmove 1 from 7 to 4\r\nmove 2 from 8 to 4\r\nmove 1 from 8 to 5\r\nmove 4 from 5 to 2\r\nmove 5 from 4 to 1\r\nmove 2 from 7 to 8\r\nmove 2 from 8 to 4\r\nmove 5 from 6 to 3\r\nmove 2 from 4 to 3\r\nmove 1 from 7 to 5\r\nmove 2 from 3 to 6\r\nmove 1 from 5 to 1\r\nmove 3 from 6 to 8\r\nmove 11 from 4 to 3\r\nmove 7 from 6 to 1\r\nmove 3 from 8 to 1\r\nmove 1 from 2 to 3\r\nmove 2 from 6 to 9\r\nmove 2 from 2 to 3\r\nmove 3 from 4 to 3\r\nmove 2 from 9 to 4\r\nmove 1 from 6 to 3\r\nmove 5 from 1 to 2\r\nmove 2 from 4 to 3\r\nmove 24 from 3 to 7\r\nmove 3 from 3 to 9\r\nmove 1 from 2 to 6\r\nmove 1 from 2 to 5\r\nmove 1 from 6 to 1\r\nmove 4 from 2 to 1\r\nmove 2 from 9 to 2\r\nmove 1 from 2 to 4\r\nmove 18 from 7 to 5\r\nmove 1 from 2 to 1\r\nmove 1 from 9 to 1\r\nmove 2 from 5 to 7\r\nmove 13 from 1 to 8\r\nmove 3 from 4 to 9\r\nmove 7 from 1 to 7\r\nmove 13 from 7 to 6\r\nmove 1 from 9 to 5\r\nmove 3 from 4 to 3\r\nmove 1 from 9 to 8\r\nmove 3 from 1 to 3\r\nmove 1 from 9 to 5\r\nmove 2 from 1 to 4\r\nmove 2 from 7 to 3\r\nmove 4 from 3 to 1\r\nmove 1 from 1 to 5\r\nmove 9 from 6 to 7\r\nmove 5 from 7 to 1\r\nmove 2 from 4 to 1\r\nmove 4 from 6 to 1\r\nmove 3 from 5 to 3\r\nmove 3 from 3 to 5\r\nmove 7 from 1 to 6\r\nmove 6 from 6 to 1\r\nmove 1 from 6 to 8\r\nmove 2 from 7 to 9\r\nmove 2 from 1 to 5\r\nmove 1 from 3 to 7\r\nmove 7 from 5 to 9\r\nmove 10 from 1 to 5\r\nmove 8 from 8 to 4\r\nmove 6 from 4 to 8\r\nmove 1 from 4 to 1\r\nmove 2 from 9 to 8\r\nmove 2 from 1 to 3\r\nmove 2 from 7 to 3\r\nmove 1 from 7 to 8\r\nmove 4 from 3 to 8\r\nmove 1 from 3 to 2\r\nmove 20 from 5 to 8\r\nmove 1 from 2 to 4\r\nmove 4 from 9 to 4\r\nmove 4 from 4 to 5\r\nmove 18 from 8 to 6\r\nmove 3 from 9 to 6\r\nmove 1 from 3 to 9\r\nmove 10 from 8 to 7\r\nmove 7 from 7 to 9\r\nmove 7 from 8 to 5\r\nmove 3 from 7 to 8\r\nmove 6 from 5 to 1\r\nmove 6 from 9 to 4\r\nmove 1 from 9 to 6\r\nmove 1 from 3 to 6\r\nmove 1 from 8 to 5\r\nmove 1 from 9 to 4\r\nmove 12 from 6 to 7\r\nmove 5 from 7 to 1\r\nmove 6 from 8 to 5\r\nmove 1 from 5 to 1\r\nmove 3 from 5 to 3\r\nmove 8 from 4 to 9\r\nmove 2 from 3 to 7\r\nmove 4 from 7 to 2\r\nmove 10 from 5 to 6\r\nmove 11 from 1 to 6\r\nmove 4 from 2 to 5\r\nmove 1 from 3 to 8\r\nmove 1 from 8 to 9\r\nmove 1 from 4 to 7\r\nmove 3 from 7 to 4\r\nmove 1 from 1 to 6\r\nmove 1 from 4 to 7\r\nmove 1 from 7 to 1\r\nmove 4 from 5 to 2\r\nmove 3 from 7 to 1\r\nmove 2 from 4 to 8\r\nmove 20 from 6 to 8\r\nmove 4 from 1 to 5\r\nmove 2 from 5 to 2\r\nmove 6 from 6 to 1\r\nmove 5 from 1 to 8\r\nmove 7 from 6 to 2\r\nmove 6 from 9 to 7\r\nmove 2 from 9 to 8\r\nmove 2 from 7 to 4\r\nmove 4 from 2 to 6\r\nmove 3 from 5 to 8\r\nmove 12 from 8 to 7\r\nmove 1 from 4 to 3\r\nmove 1 from 2 to 9\r\nmove 1 from 9 to 2\r\nmove 1 from 6 to 8\r\nmove 1 from 3 to 1\r\nmove 2 from 1 to 6\r\nmove 1 from 4 to 2\r\nmove 3 from 6 to 2\r\nmove 2 from 5 to 7\r\nmove 1 from 9 to 8\r\nmove 6 from 2 to 4\r\nmove 17 from 7 to 1\r\nmove 10 from 1 to 7\r\nmove 4 from 2 to 6\r\nmove 10 from 7 to 8\r\nmove 3 from 6 to 2\r\nmove 4 from 4 to 1\r\nmove 2 from 6 to 4\r\nmove 4 from 2 to 6\r\nmove 1 from 7 to 1\r\nmove 2 from 4 to 3\r\nmove 12 from 1 to 7\r\nmove 5 from 6 to 3\r\nmove 17 from 8 to 2\r\nmove 4 from 3 to 8\r\nmove 1 from 4 to 2\r\nmove 20 from 8 to 7\r\nmove 19 from 2 to 6\r\nmove 7 from 6 to 3\r\nmove 7 from 3 to 5\r\nmove 2 from 5 to 7\r\nmove 4 from 6 to 9\r\nmove 1 from 4 to 2\r\nmove 1 from 2 to 1\r\nmove 2 from 3 to 6\r\nmove 1 from 2 to 6\r\nmove 1 from 3 to 1\r\nmove 4 from 6 to 2\r\nmove 1 from 5 to 9\r\nmove 7 from 7 to 3\r\nmove 7 from 3 to 8\r\nmove 5 from 8 to 1\r\nmove 2 from 8 to 3\r\nmove 1 from 2 to 1\r\nmove 3 from 5 to 6\r\nmove 1 from 3 to 9\r\nmove 2 from 9 to 2\r\nmove 8 from 1 to 7\r\nmove 3 from 7 to 6\r\nmove 2 from 2 to 4\r\nmove 21 from 7 to 3\r\nmove 10 from 3 to 1\r\nmove 2 from 9 to 2\r\nmove 7 from 3 to 4\r\nmove 3 from 3 to 7\r\nmove 4 from 2 to 3\r\nmove 3 from 7 to 8\r\nmove 1 from 3 to 6\r\nmove 1 from 3 to 2\r\nmove 4 from 7 to 9\r\nmove 10 from 1 to 6\r\nmove 1 from 5 to 9\r\nmove 6 from 7 to 2\r\nmove 24 from 6 to 5\r\nmove 2 from 8 to 4\r\nmove 1 from 8 to 6\r\nmove 2 from 2 to 9\r\nmove 5 from 2 to 7\r\nmove 1 from 2 to 9\r\nmove 11 from 4 to 1\r\nmove 3 from 3 to 2\r\nmove 4 from 9 to 7\r\nmove 1 from 1 to 5\r\nmove 1 from 6 to 1\r\nmove 5 from 1 to 9\r\nmove 5 from 9 to 7\r\nmove 5 from 7 to 5\r\nmove 23 from 5 to 2\r\nmove 5 from 7 to 8\r\nmove 6 from 5 to 6\r\nmove 1 from 3 to 7\r\nmove 1 from 5 to 7\r\nmove 6 from 7 to 8\r\nmove 3 from 6 to 1\r\nmove 2 from 8 to 7\r\nmove 4 from 2 to 1\r\nmove 4 from 8 to 5\r\nmove 7 from 2 to 3\r\nmove 1 from 7 to 4\r\nmove 1 from 4 to 7\r\nmove 4 from 3 to 8\r\nmove 6 from 1 to 9\r\nmove 4 from 8 to 6\r\nmove 3 from 1 to 5\r\nmove 3 from 8 to 5\r\nmove 1 from 1 to 8\r\nmove 3 from 9 to 1\r\nmove 3 from 6 to 7\r\nmove 1 from 7 to 9\r\nmove 3 from 8 to 3\r\nmove 8 from 5 to 7\r\nmove 11 from 2 to 8\r\nmove 5 from 8 to 3\r\nmove 1 from 8 to 7\r\nmove 10 from 3 to 4\r\nmove 2 from 5 to 8\r\nmove 3 from 9 to 2\r\nmove 1 from 9 to 6\r\nmove 7 from 2 to 7\r\nmove 6 from 9 to 4\r\nmove 1 from 8 to 5\r\nmove 3 from 6 to 8\r\nmove 1 from 5 to 3\r\nmove 2 from 3 to 1\r\nmove 6 from 1 to 3\r\nmove 13 from 7 to 5\r\nmove 16 from 4 to 3\r\nmove 2 from 1 to 5\r\nmove 5 from 5 to 4\r\nmove 11 from 3 to 4\r\nmove 2 from 7 to 1\r\nmove 7 from 3 to 1\r\nmove 2 from 8 to 3\r\nmove 8 from 1 to 9\r\nmove 12 from 4 to 8\r\nmove 1 from 1 to 4\r\nmove 2 from 6 to 2\r\nmove 3 from 7 to 8\r\nmove 2 from 4 to 6\r\nmove 5 from 8 to 1\r\nmove 3 from 7 to 5\r\nmove 6 from 5 to 7\r\nmove 2 from 2 to 5\r\nmove 1 from 4 to 9\r\nmove 5 from 1 to 8\r\nmove 6 from 3 to 1\r\nmove 7 from 5 to 7\r\nmove 7 from 9 to 2\r\nmove 1 from 6 to 7\r\nmove 1 from 1 to 9\r\nmove 2 from 5 to 3\r\nmove 2 from 9 to 6\r\nmove 13 from 7 to 3\r\nmove 2 from 6 to 1\r\nmove 1 from 9 to 2\r\nmove 16 from 8 to 7\r\nmove 6 from 8 to 5\r\nmove 3 from 2 to 5\r\nmove 4 from 2 to 1\r\nmove 3 from 1 to 8\r\nmove 2 from 8 to 9\r\nmove 1 from 8 to 7\r\nmove 1 from 2 to 1\r\nmove 8 from 3 to 1\r\nmove 1 from 4 to 5\r\nmove 1 from 6 to 3\r\nmove 2 from 9 to 7\r\nmove 5 from 1 to 4\r\nmove 15 from 7 to 9\r\nmove 11 from 9 to 3\r\nmove 7 from 1 to 3\r\nmove 2 from 1 to 6\r\nmove 1 from 6 to 3\r\nmove 2 from 4 to 5\r\nmove 2 from 4 to 9\r\nmove 7 from 5 to 9\r\nmove 5 from 9 to 3\r\nmove 1 from 1 to 6\r\nmove 5 from 5 to 9\r\nmove 1 from 4 to 8\r\nmove 1 from 8 to 4\r\nmove 3 from 7 to 4\r\nmove 8 from 9 to 5\r\nmove 1 from 6 to 4\r\nmove 4 from 9 to 3\r\nmove 1 from 9 to 3\r\nmove 23 from 3 to 1\r\nmove 12 from 1 to 2\r\nmove 6 from 1 to 9\r\nmove 5 from 9 to 7\r\nmove 3 from 3 to 7\r\nmove 6 from 4 to 3\r\nmove 1 from 6 to 8\r\nmove 6 from 1 to 2\r\nmove 3 from 7 to 3\r\nmove 3 from 2 to 5\r\nmove 10 from 3 to 5\r\nmove 1 from 1 to 8\r\nmove 12 from 2 to 5\r\nmove 3 from 2 to 9\r\nmove 2 from 8 to 4\r\nmove 13 from 5 to 1\r\nmove 2 from 9 to 2\r\nmove 2 from 1 to 3\r\nmove 11 from 3 to 1\r\nmove 2 from 2 to 1\r\nmove 2 from 1 to 9\r\nmove 16 from 1 to 7\r\nmove 17 from 5 to 8\r\nmove 1 from 1 to 2\r\nmove 3 from 9 to 6";

int towerCount = int.Parse(stacksInput[stacksInput.Length - 1].ToString());
List<List<char>> stacks = new();

for (int i = 0; i < towerCount + 1; i++)
{
    stacks.Add(new());
}

int placeCount = 1;
void NextPlaceCount()
{
    placeCount++;
    if (placeCount > towerCount)
    {
        placeCount = 1;
    }
}
int whitespaceCount = 0;
bool placeNext = false;

foreach (var character in stacksInput)
{
    if (whitespaceCount == 4)
    {
        whitespaceCount = 0;
        NextPlaceCount();
    }
    if (character == '[')
    {
        placeNext = true;
        continue;
    }
    if (placeNext)
    {
        placeNext = false;
        whitespaceCount = 0;
        stacks[placeCount].Add(character);
        NextPlaceCount();
    }
    if (character == ' ')
    {
        whitespaceCount++;
        continue;
    }
}

for (int i = 1; i < towerCount + 1; i++)
{
    stacks[i].Reverse();
}

var moves = movesInput.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

foreach (var move in moves)
{
    var combined = move.Replace(" ", "");
    int moveCount = int.Parse(combined.Substring(combined.IndexOf('e') + 1, combined.IndexOf('f') - combined.IndexOf('e') - 1));
    int from = int.Parse(combined[combined.IndexOf('t') - 1].ToString());
    int to = int.Parse(combined.Last().ToString());

    var tempCount = stacks[from].Count;
    for (int i = 0; i < moveCount; i++)
    {
        var index = tempCount - moveCount;
        stacks[to].Add(stacks[from][index]);
        stacks[from].RemoveAt(index);
    }
}

var answer = "";
for (int i = 1; i < stacks.Count; i++)
{
    answer += stacks[i].Last();
}
Console.WriteLine(answer);
