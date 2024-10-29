int[] first = { 34, 56, 12, 28, 92 }, second = { 75, 61, 83, 49, 52}, passer = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
for (int counter = 0; counter < 5; counter++)
{
passer[counter] = first[counter];
    passer[counter+5] = second[counter];
}