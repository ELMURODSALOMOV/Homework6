
List<string> vazifalar = new List<string>();
List<bool> bajarilganVazifalar = new List<bool>();

bool davomEtish = true;

while(davomEtish)
{
    System.Console.WriteLine("1 - Vazifa qo'shish");
    System.Console.WriteLine("2 - Vazifani o'chirish");
    System.Console.WriteLine("3 - Bajarilgan vazifani ko'rish");
    System.Console.WriteLine("4 - Dasturni to'gatish");
    System.Console.Write("Tanlangan amalni raqamini kiriting ");

    int amalRaqami;
    while(!int.TryParse(Console.ReadLine(), out amalRaqami) || amalRaqami < 1 || amalRaqami > 4)
    {
        System.Console.WriteLine("Noto'g'ri raqam kiritdingiz.Iltimos qaytadan kiriting");
        System.Console.Write("Tanlangan amal raqamini kiriting ");
    }

    switch(amalRaqami)
    {
        case 1:
        System.Console.Write("Yangi vazifani kiriting ");
        string yangiVazifa = Console.ReadLine();
        vazifalar.Add(yangiVazifa);
        bajarilganVazifalar.Add(false);
        System.Console.WriteLine("Yangi vazifa mufoqiyatli qo'shildi");
        break;

        case 2:
        System.Console.Write("O'chirish uchun kerakli vazifaning raqamini kiriting ");
        int uchirishRaqami;
        while(!int.TryParse(Console.ReadLine(), out uchirishRaqami) || uchirishRaqami < 1 || uchirishRaqami > vazifalar.Count)
        {
            System.Console.WriteLine("Noto'g'ri raqam kiritdingiz.Iltimos qaytadan kiriting");
            System.Console.Write("O'chirish uchun kerakli vazifa raqamini kiriting ");
        }
        vazifalar.RemoveAt(uchirishRaqami - 1);
        bajarilganVazifalar.RemoveAt(uchirishRaqami - 1);
        System.Console.WriteLine("Vazifa mufoqiyatli o'chirildi");
        break;

        case 3:
        System.Console.WriteLine("Bajarilgan vazifalar");
        for(int i = 0; i < vazifalar.Count; i++)
        {
            if(bajarilganVazifalar[i])
            {
                System.Console.WriteLine($"{i + 1}. {vazifalar}");
            }
        }
        break;
        case 4:
            davomEtish = false;
            System.Console.WriteLine("Dastur muvaffaqiyatli tugatildi");
            break;
    }
}