string[] Competence = {
    "extrovert",
    "introvert",
    "monotone",
    "analytic",
    "curiosity",
    "criticism",
    "creativity",
    "control",
    "bigtask",
    "stress",
    "multitask",
    "org",
    "speaker",
    "empfthy",
    "mentor"
};
// fill compenetces
int[] MyCompetence = {2,3,5,4,5,5,2,4,4,2,2,1,0,3,0};
int[] TestCompetence = {2,2,5,3,4,3,1,3,3,2,3,1,0,3,0};
int[] ProgCompetence = {2,3,4,4,5,3,1,3,5,4,3,1,0,2,0};
int[] AnltCompetence = {3,4,3,5,4,5,3,2,4,3,3,2,1,2,0};
int[] ProjCompetence = {4,1,1,3,3,3,3,5,4,5,5,5,4,4,3};
int[] ProdCompetence = {3,2,3,3,2,3,2,4,3,4,5,4,4,4,3};
// count sum for each competence
int ProgSum = 0;
int TestSum = 0;
int AnltSum = 0;
int ProjSum = 0;
int ProdSum = 0;
int MyProgSum = 0;
int MyTestSum = 0;
int MyAnltSum = 0;
int MyProjSum = 0;
int MyProdSum = 0;
int Ncount = 15;
int count = 0;
while (count < Ncount){
    ProgSum = ProgSum + ProgCompetence[count];
    TestSum = TestSum + TestCompetence[count];
    AnltSum = AnltSum + AnltCompetence[count];
    ProjSum = ProjSum + ProjCompetence[count];
    ProdSum = ProdSum + ProdCompetence[count];
    MyProgSum = MyProgSum + Math.Min(MyCompetence[count], ProgCompetence[count]);
    MyTestSum = MyTestSum + Math.Min(MyCompetence[count], TestCompetence[count]);
    MyAnltSum = MyAnltSum + Math.Min(MyCompetence[count], AnltCompetence[count]);
    MyProjSum = MyProjSum + Math.Min(MyCompetence[count], ProjCompetence[count]);
    MyProdSum = MyProdSum + Math.Min(MyCompetence[count], ProdCompetence[count]);
    count++;
}
// print out
Console.WriteLine("Programmer:      "+MyProgSum+" from "+ProgSum);
Console.WriteLine("Tester:          "+MyTestSum+" from "+TestSum);
Console.WriteLine("Analyst:         "+MyAnltSum+" from "+AnltSum);
Console.WriteLine("Project Manager: "+MyProjSum+" from "+ProjSum);
Console.WriteLine("Product Manager: "+MyProdSum+" from "+ProdSum);
