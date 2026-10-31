//task 1
//Merosdihi dar c# yak prinsipi oop meboshad. Mo uro bisyor dar holate istifoda mebarem ki yagon chizhoi classho takror meshavad misol mo mesozem classi dog va yak classi Cat mesozem ki hardu atributhoi name, age dorand mo dar daruni har yak class inhoro namenavisem. mo yak classi bazoviy class mesozem ki nom dorad Animal nom dorad va dar daruni on atributhoi age , name hast mo dar classhoi Dog va Cat az classi base meros megirem va chize ki dar daruni hamon clasi base hast dar inhoram dastupni meshavad. yane inheritance yak shokhai oop buda ba mo imkoniyat medihad ki yak class method va polyahoi clasi digarro girad :)
//Polimorfism inham yak shokhai oop buda ba mo imkoniyat medihad ki dar vaqti mehtod sokhtan dar digar classhoe ki meros megirand ivaz kunem. Polimorfism asosan gunogun shakli meboshad yane dar yak class digar korro ijro kunad dar digarash digarkhel.misol mo bazoviy class shape dorem ki classhoi Circle va Rectangle az on meros megirand.mo dar daruni classi Shape methodi public virtual void Conculate area dorem ki dar mo uro dar classi Circle override mekunem va daruni onro logikai khudro memonem va dar classi Rectangle boshad boz override karda logikai khudro memonem!





//task 2
//sttic class classe meboshad. mo nametavonem objecti uro sozem ki uro bo nomi class faryod mekunem.



//task 3
// Yak classe meboshad ki baroi nabori tipho meboshad ki mo ba u chi tipe dokhil kunem hamon tipe mewavand misol. List<T> megirad ki T dar injo muayan mekunad ki bo kadom tip kor kunad;


//task 4
//structura hamon class meboshad faqat u velue type meboshad ki bo copiya kor mekunad 


//task 5
// var a=new MyQueue<int>();



//task 6
// IStudentService service = new StudentService();

// while (true)
// {

//     Console.Write("Choose: ");

//     try
//     {
//         int choice = int.Parse(Console.ReadLine());

//         switch (choice)
//         {
//             case 1:
//                 Student student = new Student();

//                 Console.Write("Enter ID: ");
//                 student.Id = int.Parse(Console.ReadLine());

//                 Console.Write("Enter Name: ");
//                 student.FullName = Console.ReadLine();

//                 Console.Write("Enter Age: ");
//                 student.Age = int.Parse(Console.ReadLine());

//                 Console.Write("Enter Group: ");
//                 student.Group = Console.ReadLine();

//                 service.AddStudent(student);
//                 break;

//             case 2:
//                 service.DisplayStudents();
//                 break;

//             case 3:
//                 Console.Write("Enter ID: ");
//                 int updateId = int.Parse(Console.ReadLine());

//                 service.UpdateStudent(updateId);
//                 break;

//             case 4:
//                 Console.Write("Enter ID: ");
//                 int deleteId = int.Parse(Console.ReadLine());

//                 service.DeleteStudent(deleteId);
//                 break;

//             case 5:
//                 Console.Write("Enter Name: ");
//                 string name = Console.ReadLine();

//                 service.SearchByName(name);
//                 break;

//             case 6:
//                 Console.Write("Enter Group: ");
//                 string group = Console.ReadLine();

//                 service.SearchByGroup(group);
//                 break;

//             case 7:
//                 Console.WriteLine("Goodbye!");
//                 return;

//             default:
//                 Console.WriteLine("Invalid choice!");
//                 break;
//         }
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Please enter a valid number!");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }