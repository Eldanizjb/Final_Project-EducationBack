USE [EducationDB]
GO
SET IDENTITY_INSERT [dbo].[CourseLevel] ON 

INSERT [dbo].[CourseLevel] ([Id], [Name]) VALUES (1, N'Beginner')
INSERT [dbo].[CourseLevel] ([Id], [Name]) VALUES (2, N'Intermediate')
INSERT [dbo].[CourseLevel] ([Id], [Name]) VALUES (3, N'Expert')
SET IDENTITY_INSERT [dbo].[CourseLevel] OFF
GO
SET IDENTITY_INSERT [dbo].[Instructors] ON 

INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (47, N'Lalə', N'Abbasova', N'Web Dizayner', N'Web Dizaynı mənlə öyrənin', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-02-24T15:57:14.1280000' AS DateTime2), N'b556ce88-031b-42d0-aa97-4c0a0ff7b224-20220224155714-instructor-2.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (48, N'Samir', N'Akbar', N'Web Developer', N'İT sahəsini mənlə öyrən', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-04T23:52:12.5350000' AS DateTime2), N'4e7beb33-32a0-4bf1-b4cb-323ff32add5b-20220304235212-instructor-1.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (49, N'Həcən ', N'Əkbərli', N'SMM Meniger', N'Meniger dünyasına birgə addımlayaq', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-04T23:53:38.8500000' AS DateTime2), N'9ef270af-0c4a-41b6-89c8-337ad3d1d46e-20220304235338-instructor-3.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (50, N'Lalə ', N'Azərtaş', N'İngilis dili müəlliməsi', N'Xarici dil öyrənmək zehni inkişaf etdirir', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-04T23:55:02.3460000' AS DateTime2), N'3530c2fa-9639-4cc3-9d16-7dc2a00efa3f-20220304235502-instructor-4.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (51, N'Sənəm ', N'Həsənova', N'Alman dili müəlliməsi', N'Xarici dillər zehni inkişaf etdirir', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-04T23:56:25.3520000' AS DateTime2), N'c8cbe7d0-5d9e-4dfc-9ff9-c71f7c1ca8d5-20220304235625-instructor-5.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (52, N'Kamran ', N'Əliyev', N'Web Developer', N'İT Sahəsinə birgə daxil olaq', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-04T23:58:55.3010000' AS DateTime2), N'022439c0-d6a3-4611-a30b-1308eb5d9861-20220304235855-instructor-6.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (53, N'Yaqut ', N'Şahin', N'Web Dizayner', N'3D Qrafikasına dogru', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-05T00:00:00.7540000' AS DateTime2), N'9164ddc0-da94-4588-af90-cbf8bce08e3a-20220305000000-instructor-7.jpg')
INSERT [dbo].[Instructors] ([Id], [Name], [Surname], [Position], [Title], [Content], [CreatedDate], [MainImage]) VALUES (54, N'Sahil', N'Dadaşov', N'Web Developer', N'İT sahəsində bigə addımlayaq', N'Akademik qabiliyyət — geniş və dərin biliyə malik olmaqda, elmin son nailiyyətlərini öyrənməkdə və tələbələrə çatdırmaqda ifadə olunur.

Didaktik qabiliyyət — bilikləri öyrətmə bacarığında, pedaqoji-metodik ustalığa yiyələnməkdə özünü göstərir.

Ünsiyyət (kommunikativ) qabiliyyəti — tələbələrlə, öz həmkarları ilə və valideynlərlə düzgün ünsiyyət yaratmaqda, demokratik ünsiyyət üslubunda, hər bir uşağa fərdi yanaşma bacarığında ifadə olunur.

Konstruktiv qabiliyyət — özünün və uşaqların (kollektivin) fəaliyyətini düzgün planlaşdırmaqda, çətinlikləri əvvəlcədən duyub, onları aradan qaldırmağa hazır olmaqda ifadə olunur.

İradi-emosional qabiliyyət — müəllimin özünü, hisslərini düzgün idarə etməkdə, mülayimlik və ciddiliyi uzlaşdırmaqda, səbirli olmaqda ifadə olunur.
Pedaqoji qabiliyyətlər — insana hazır verilmir; onları gündəlik fəaliyyətdə, gərgin əməklə qazanmaq olar.', CAST(N'2022-03-05T00:01:21.1180000' AS DateTime2), N'92bc48a1-9937-402e-9b01-c3f0515e01fd-20220305000121-instructor-8.jpg')
SET IDENTITY_INSERT [dbo].[Instructors] OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (35, N'Windows 2010', N'Word,Excel,
Power Point, 
Photoshop,
Corel Draw ,
C++,
AutoCad,
ArchiCad..
3D Max ', N'30', N'2 ay', N'20 Students', N'en', 80.0000, N'azn', 45.0000, N'azn', N'45', CAST(N'2022-03-26T15:58:15.3780000' AS DateTime2), N'2b9a74c0-7072-43ce-831f-fb1a3afdbd32-20220224155815-course-1.jpg', 47, 3)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (36, N'KİberTəhlükəsizlik', N'Linux şəbəkə administrasiyası. Qurulması, fayl sistemləri, qurğu, istifadəçilərin idarə olunması, giriş imkanlarının idarəedilməsi, skriptinq
Linux şəbəkə administrasiyası. Poçt, fayl və veb-serverləri. Tarazlama və monitorinq
Kompüter şəbəkələri və sistemlərinin təhlükəsizliyi. Kriptoqrafiya, autentifikasiya, avtorizasiya, sistemlərin araşdırılması, ids/ips, paket filtirlər
IT Essentials. PC-nin aparat və proqram təminatı – Cisco Networking Academy-nin kursu
Bulud texnologiyaları: VMWare, Amazon Web Services, Google Cloud Services, Microsoft Azure
DevOps: əsas alətlər
Şəbəkə administrasiyası üçün Python
CCNA R&S. Routing and Switching. Essentials
CCNA R&S. Routing and Switching. Scaling Networks
CCNA R&S. Routing and Switching. Connecting Networks
CCNA Security', N'30', N'3 ay', N'10 Students', N'az', 170.0000, N'azn', 155.0000, N'azn', N'35', CAST(N'2022-04-20T13:40:24.0760000' AS DateTime2), N'9cdb8f78-9fc9-4e1d-98ab-4a2a2bca40bd-20220228134024-course-2.jpg', 54, 2)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (37, N'İP-şəbəkələr', N'Alqoritmlər teoriyasının və məlumatların quruluşunun əsasları
C dilindən istifadə edərək proses əsaslı proqramlaşdırma
Sistem proqramlaşdırma (axınlar, proseslər, sinxronlaşdıma primitivləri, proseslər arası qarşılıqlı əlaqələr). Şəbəkə proqramlaşdırması (soketlər, məlumat mübadiləsini sinxron və asinxron mexanizmləri, protokollar)
İş stansiyaları və noutbukların aparat təminatı
Lokal şəbəkələrdə kommutasiya, protokollar, tunelləşdirmə, virtual şəbəkələr
Strukturlaşdırılmış kabel sistemlərinin layihələndirilməsi, quraşdırılması və diaqnostikası
İP-şəbəkələrdə marşrutizasiya
TCP/IP tətbiqi protokollar və xidmətlər toplusu
Windows 8.1/10 administrasiyası. Qurulması, yenilənməsi, miqrasiya, resurslara girişin idarə olunması. Təhlükəsizliyin konfiqurasiyası
Windows Server 2012/2016 administrasiyası. Şəbəkə servisləri, virtuallaşdırma, terminallara xidmət, qrup siyasəti. Active Directory
Microsoft SQL Server 2014-ün administrasiyası. Məlumat bazalarının yaradılması, SQL, ehtiyat saxlama və bərpa, təhlükəsizlik modeli, replikasiya', N'60', N'3 ay', N'10 Students', N'en', 160.0000, N'azn', 140.0000, N'azn', N'30', CAST(N'2022-03-03T15:25:29.1580000' AS DateTime2), N'3e54942a-d3ad-4d0f-8469-3de8c6fd701b-20220303152529-course-4.jpg', 49, 1)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (38, N'İngilis Dili', N'İngilis dili kurslari mərkəzimizin əsas ixtisaslaşmış sahələrindəndir. İngilis dili kursları rəsmi “British English Learning” (BEL) proqramı çərçivəsində tədris olunur. “BEL” proqramı vasitəsilə ingilis dilini klassik-ənənəvi metodlara nisbətən 4 dəfə daha sürətli öyrənmək və ən vacib 4 bacarığı – danışma, dinləmə, oxuma və yazmanı (speaking, listening, reading and writing) effektiv inkişaf etdirmək mümkündür. ', N'60 ders', N'3 ay', N'20 Students', N'en', 150.0000, N'azn', 130.0000, N'azn', N'25', CAST(N'2022-04-08T15:26:09.5230000' AS DateTime2), N'0633f100-fc17-4330-9098-930d9fb68d34-20220303152609-course-5.jpg', 53, 2)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (39, N'SEO və SMM', N'Digital Marketinq tədris proqramı Code Academy ilə İrlandiya mərkəzli Digital Marketinq İnstitutunun eksklüziv partnyorluğu əsasında tədris edilir. Fərdi tədris proqramında digital marketinqin əsasları, kontent və email marketing, SEO, display və digər rəqəmsal sahənin incəliklərini öyrənə bilərsiniz.', N'20', N'2 ay', N'10 Students', N'az', 90.0000, N'USD', 85.0000, N'USD', N'10', CAST(N'2022-03-03T15:26:48.8920000' AS DateTime2), N'1419fde9-222d-46fd-b153-25d1f5a8224f-20220303152648-course-1.jpg', 52, 1)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (40, N'3D Qrafika', N'Adobe Photoshop-da rastr qrafikasə ilə iş;
Şəkil, incəsənət tarixi, mühüm inkişaf mərhələləri və müasir dizayn stilləri
Dizayn və reklam dizaynı: yaradılması, təşviqi psixologiyası, aydentika (firma stili) və brendinq
Adobe Photoshop-da foto və rastr şəkillərin peşəkar işlənməsi
Adobe Illustrator-da vektor qrafikası ilə iş
Nəşriyyat: çap mətninin tərtibatı ənənələri, məhsulun erqonomik və stilistik dizaynı
Adobe InDesign nəşriyyat sistemi. Çap öncəsi hazırlıq
Rəqəmsal fotoqrafiya. Studiyada professional avadanlıqlarla iş təcrübəsi, portret retuşu, əşya fotoçəkilişi
Statik və dinamik veb-saytların yaradılması: HTML5 dili, CSS3, yaratma, təşviq etmə və pul qazanma vasitələri
Veb-saytlar üçün məzmunun idarəedilməsi sistemləri
Veb səhifələrin erqonomikası və istifadə üçün rahatlığı. UI/UX-dizayn
JavaScript və WebGL istifadə etməklə interaktiv animasiya', N'30', N'3 ay', N'15 Students', N'az', 100.0000, N'azn', 80.0000, N'azn', N'80', CAST(N'2022-04-29T15:27:36.1390000' AS DateTime2), N'1faf7eaa-5a99-4d96-82ac-a2625fe01462-20220303152736-course-6.jpg', 48, 3)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (41, N'Java Scripti bizlə başla', N'JavaScripi proqramlaşdırılmasına giriş
Budaqlanma operatorları, dövrlər, istisnalar
Sətrlər, siyahılar
Funksiyalar
Sıralama, axtarış
Kortejlər, çoxluqlar, lüğətlər
Tkinter
Fayllar. Paketlər
Obyekt-yönümlü proqramlaşdırma
Məlumatlar strukturu', N'20', N'2 ay', N'10 Students', N'en', 110.0000, N'azn', 90.0000, N'azn', N'70', CAST(N'2022-04-14T15:28:23.3540000' AS DateTime2), N'37a37ad6-75ef-4633-93e2-9c545ccec9c1-20220303152823-course-3.jpg', 47, 2)
INSERT [dbo].[Courses] ([Id], [Title], [Content], [Lectures], [Duration], [Enrolled], [Language], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId], [CourseLevelId]) VALUES (42, N'Pythona bizle başla', N'Python proqramlaşdırılmasına giriş
Budaqlanma operatorları, dövrlər, istisnalar
Sətrlər, siyahılar
Funksiyalar
Sıralama, axtarış
Kortejlər, çoxluqlar, lüğətlər
Tkinter
Fayllar. Paketlər
Obyekt-yönümlü proqramlaşdırma
Məlumatlar strukturu', N'30 ders', N'2 ay', N'10 Students', N'en', 150.0000, N'azn', 120.0000, N'azn', N'80', CAST(N'2022-04-07T15:29:35.1630000' AS DateTime2), N'7118482f-c041-4dee-99df-48f05ec46d37-20220303152935-course-4.jpg', 48, 1)
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2a1e87d4-90b6-4dfc-bd5f-86dd0187ec42', N'Customer', N'CUSTOMER', N'b4beeff4-7759-4eb9-9fd4-f1aff8d6a758')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3a28699d-a2c5-4e8a-b11e-477b401a3c75', N'Full Stack Developer', N'FULL STACK DEVELOPER', N'16e32c04-e8d6-4749-8fc8-bbdadbb52afe')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'72303fc3-a0b3-4b24-9698-df2d2fb1c8e5', N'QA və SEO', N'QA VƏ SEO', N'1f8e51a5-5b70-4413-aa7c-c46fe877d41c')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'79e747f6-255d-4f6a-8f5e-8774071e6e89', N'Scrum Master', N'SCRUM MASTER', N'5f11f41d-86df-4558-b2df-9bcce8ea3c68')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'98ea3db7-8a6a-4012-b0d7-dd9d6169f300', N'Moderator', N'MODERATOR', N'cbb82d59-e9fc-4588-99f1-24c18c171e69')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a09a3ff3-2264-4de1-9a96-dff0d2d30502', N'Backend Developer', N'BACKEND DEVELOPER', N'a5570944-0526-4e8b-93d8-02c20f613262')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cd2c359c-b343-4605-8253-de2c56857ecf', N' Qrafik Dizayner', N' QRAFIK DIZAYNER', N'3bd18fd6-b9fd-492f-802a-f5c9ae446a6a')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd1aa3a7d-1d7d-4c92-8540-9097ba374048', N'UI/UX Dizayner', N'UI/UX DIZAYNER', N'b2983588-78ff-4dab-88b2-dca4d0a7e225')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ee73378e-49b1-4720-858e-588a6fb180d0', N'Projects Manager', N'PROJECTS MANAGER', N'4b384cae-a263-4142-ae39-030bdbe8bb29')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Address], [Phone], [CreatedDate], [Image], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'674cf2e5-df9b-4fff-b7fa-76e0645d51a8', N'CustomUser', N'Eldaniz', N'Bashirov', NULL, NULL, CAST(N'2022-02-23T17:46:58.7293215' AS DateTime2), N'4fd50889-a983-43bf-9ffe-a2377a635bc2-28February2022-course-detail-instructor-img.jpg', N'eldanizjb@code.edu.az', N'ELDANIZJB@CODE.EDU.AZ', N'eldanizjb@code.edu.az', N'ELDANIZJB@CODE.EDU.AZ', 0, N'AQAAAAEAACcQAAAAEPAMGpLhra+bbcuYqGobyEt3I4TSFrotxhp5O2V5if8HRND3+HBow30XgG1+2oTPUg==', N'XZK7DG2ULT5IRIMN7FZNPCUNV2TOLCJ2', N'86f52d50-065f-4b4a-ba19-8d8d6032cc6a', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Address], [Phone], [CreatedDate], [Image], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7a00ea2d-2a10-4941-b245-15fb85fb6377', N'CustomUser', N'Samir', N'Babayev', NULL, NULL, CAST(N'2022-03-05T23:11:30.9791330' AS DateTime2), N'0a358c75-55ea-4f29-b685-84d2c357c778-05March2022-instructor-3.jpg', N'samir@code.edu.az', N'SAMIR@CODE.EDU.AZ', N'samir@code.edu.az', N'SAMIR@CODE.EDU.AZ', 0, N'AQAAAAEAACcQAAAAENXhhb8pr0Zrj9Fb15SljKKfYte3MQtgUgXdfKrjjVCGN+NwhdpbJexzXQ5/+pUwZw==', N'QBBQVB5JC3N2CRLCYDX5FIBFAX4RXCOA', N'31e497a5-1ba4-4d80-a3dc-632ae8586618', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[BlogCategories] ON 

INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (1, N'Business')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (2, N'Case Study ')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (3, N'Insights ')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (4, N'World ')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (5, N'Tax Solutions ')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (6, N'Creative ')
SET IDENTITY_INSERT [dbo].[BlogCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [MainImage], [BlogCategoryId], [CustomUserId]) VALUES (34, N'Tələbəmizin hazırladığı oyun Appstore’da dünya reytinqinə yüksəldim', N'Proqram Təminatının Yaradılması ixtisasımızın tələbəsi Sahib Zülfüqar bir neçə gün öncə özünün yaratdığı daha yeni bir oyununu App Store və Play Market-ə yükləyib. 



 

Oyunun adı "Cırtdan"-dır. Sahib həm oyunun tərtibatını həm də personajı Azərbaycan milli üslubunda hazıryaıb. Oyunda milli nağıl personajımız, milli attributlarımız, yəni milli bayrağımız, milli geyimimiz, milli papaq, alov məşəli  və s. yer alıb. ‘Cirtdann’ sonsuz "runner" janrında hazırlanıb, IOS ve Android platformalarında mövcuddur və minlərlə oyunun içində Appstore-un top cahrtında 1-ci yerə çıxıb. Artıq ‘Cirtdann’ oyununu Londonda, Cenevrədə , Moskvada, Hindistanda, Türkiyədə, ABŞ-da oynayırlar.

 

                                                         
 

"Cirtdan" Sahibin ilk oyunu deyil. Son illər ərzində Sahib müxtəlif platformalara 6 oyun yükləyib və uğur qazanıb. Qeyd edək ki öncə Sahib Kiçik Kompüter Akademiyamızın tələbəsi olub, karyerasını IT sahəsində davam etmək qərarına gəldikdə isə Peşəkar Kompüter Təhsilinə qəbul olunub. 

 

Sahib, biz səninlə fəxr edirik, sənin uğurlarına sevinirik! Təbriklər!', CAST(N'2022-02-26T10:50:59.5070000' AS DateTime2), N'516debb7-900f-49a4-ba19-84efa71d3f70-20220226105059-blog_2.jpeg', 2, N'674cf2e5-df9b-4fff-b7fa-76e0645d51a8')
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [MainImage], [BlogCategoryId], [CustomUserId]) VALUES (35, N'Dünyada ilk kvant prosessoru yaradıldı', N'Varşava Universitetinin Fizika fakültəsindən və Optik Kvant Texnologiyaları Mərkəzindən üç polşalı alim tərəfindən yeni bir texnoloji irəliləyiş haqqında məlumat yayılıb.

Onların kvant texnologiyalarına əsaslanan dünyanın ilk prosessoru yaratdıqları bildirilib.

Layihənin müəllifləri Mateuş Mazelanik, Adam Lesşinski və Mixal Parniakdır.

Yenilik müəllifləri iddia edirlər ki, yeni tipli prosessor telekommunikasiya həllərində istifadə oluna biləcək.

Mənbə: ferra.ru', CAST(N'2022-02-26T11:07:45.9880000' AS DateTime2), N'dccbfdf6-3c68-4211-913a-d225ca5d617b-20220226110745-blog_3.jpg', 4, N'674cf2e5-df9b-4fff-b7fa-76e0645d51a8')
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [MainImage], [BlogCategoryId], [CustomUserId]) VALUES (38, N'“WhatsApp” messencer istifadəçilərini məhdudlaşdıracaq', N'WhatsApp” messencerinin yeni beta versiyasında toplu mesajların yönləndirilməsinə məhdudiyyət qoyulub.

İndi istifadəçi “yönləndirildi” işarəsi ilə mesaj alarsa, onu eyni anda bir neçə qrup çatına yönləndirə bilməyəcək.

Məhdudiyyət “Google Play”-də yerləşdirilən “WhatsApp Beta” 2.22.7.2 versiyasında aşkar edilib.

Yeni məhdudiyyətlərin səbəbləri açıqlanmayıb.', CAST(N'2022-03-10T09:52:50.0710000' AS DateTime2), N'ce925897-5e6c-4e5d-aae4-71c85fbfecb9-20220310102008-whatsapp.jpg', 4, N'7a00ea2d-2a10-4941-b245-15fb85fb6377')
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [MainImage], [BlogCategoryId], [CustomUserId]) VALUES (39, N'Niyə məhz “Apple” brendinin M1 çipi ilə təchiz edilmiş “MacBook Air” notbuku? – FOTO', N'Notbuk seçərkən çoxsaylı modellər arasında başını itirə bilərsən. Bu halda “Apple” brendi işimizi xeyli asanlaşdırır. Belə ki, bu şirkət kəmiyyətə deyil, keyfiyyətə üstünlük verir, buna görə də onun notbukları lakonikliyi və rahatlığı ilə seçilir. 

2020-ci ildə şirkət özünün istehsalı olan M1 çipi təchiz edilmiş “MacBook Air” notbukunu təqdim etdi. 1news.az saytının “Lifestyle” rubrikasının müəllifi olan jurnalist Feliks Vişnevski 1 həftə ərzində bu modeli sınaqdan keçirdikdən sonra öz təəssüratlarını bölüşüb:

Dizayn və xüsusiyyətləri

Bir həftə ərzində M1 çipli, 7 nüvəli qrafik prosessorlu, 256 GB-lıq SSD və 8 GP yaddaşa malik “MacBook Air” versiyasını sınaqdan keçirdim. 

Mənə notbuk gündəlik işləri yerinə yetirmək üçün lazımdır. Bura internetdə səhifələrə baxış, xəbər məqalələrinin və materiallarının yazılması zamanı sənədlərlə iş, foto və videonun redaktə edilməsi və s. kimi işlər daxildir. Bu versiya belə işlər üçün idealdır. Amma əgər siz proqram tərtibatı kimi işlə məşğulsunuzsa, 16GB-lıq yaddaşa malik model seçməlisiniz.  

Mənim üçün notbukun səssiz işləməsi çox vacibdir, çünki səs-küy mənim diqqətimi yayındırır, işə köklənməyə imkan vermir. Notbuk həmçinin, eyni zamanda bir neçə işi görməyə imkan verməli, cərəyana qoşmadan işləməlidir. M1 çipi ilə təchiz edilmiş “MacBook Air” modeli bütün bu tələblərə cavab verir: o sakit işləyir, yüksək məhsuldarlıq nümayiş etdirir, böyük yaddaşa və saxlanca malikdir, avtonom rejimdə işləmək qabiliyyəti də yüksəkdir. Onun daha bir müsbət cəhəti təsvirin dəqiq və real olmasında, rəng palitrasının genişliyindədir ki, bu da fotoqraflar, videoredaktorlar və işində rənglərin dəqiqliyi tələb olunan digər peşəkarlar üçün uyğundur. 
Bu model “Touch ID” ilə sistemə giriş imkanına, 720p-lik veb-kamera genişlənməsinə, alt işıqlanmalı “Magic Keyboard” klaviaturasına və böyük “Force Touch” trekpədə malikdir.

Funksional düymələrin düzülüşü də dəyişmişdir: belə ki, artıq sistemdə və “Google”da axtarış etməyi asanlaşdıran “Spotlight” axtarış düyməsi, müəyyən işə köklənmək üçün faydalı olan “Narahat etmə”, həmçinin “Dictation” kimi düymələr var. Sonuncu düymə mətni yazmayıb səslə deyən və bununla işini asanlaşdıran və vaxtına qənaət edən mənim kimi adamlar üçün çox əlverişlidir. 

Diqqətimi cəlb edən daha bir əhəmiyyətli dəyişiklik “MacBook Air”də sərinkeşin olmamasıdır.

Yalnız alümin radiatorun olması sayəsində notbuk yüklənmə zamanı isinmir və demək olar ki, səssiz işləyir. Məsələn, “Fortnite” və onun kimi digər “ağır” oyunları oynayarkən heç bir isinmə hiss etməyəcəksiniz, bu isə əladır! 
Səmərəlilik

M1 çipinin sayəsində səmərəliliyi son dərəcə yüksəlmiş “MacBook Air” istifadəçi üçün xeyli yeni imkanlar yaradır. Eyni zamanda böyük resurs tələb edən 10-dan çox tətbiqi işlətməklə bu notbuku güclü sınaqdan keçirdim və o, bu sınağın öhdəsindən məharətlə gəldi. Məsələn, “Photoshop” və bir sıra digər oxşar fotoredaktor proqramları ilə işlədiyim bir zamanda “Teams” proqramında işlə bağlı video zəngə qoşulmuş, həmçinin “Chrome”da çoxsaylı xəbər əlavələri açmışdım. Bu azmış kimi, əlavələrin birində “YouTube”da videoya baxırdım. Bu müddət ərzində “MacBook Air” notbukunun rəvan və sabit işləməsi sanki möcüzə idi. 

Qeyd etmək istədiyim daha bir vacib fakt sonuncu “MacBook Air” modelinin batareyasının iş müddətinin əvvəlki modelə nisbətən 50 % daha çox olmasıdır. Məsələn, mən notbuku cərəyana qoşmadan fasiləsiz 10-12 saat işləyə bildim. Daha bir müsbət cəhət yuxu rejimindən ani çıxışdır.

Sınaq müddətində müşahidə etdiyim daha bir məqam “Zoom” kimi adətən çox enerji sərf edən tətbiqlərlə iş zamanı batareyanın tez boşalmamasıdır. ', CAST(N'2022-03-10T10:22:02.3363265' AS DateTime2), N'59490e03-f386-4db0-abb0-29b947b6c83c-20220310102202-apple.jpg', 2, N'7a00ea2d-2a10-4941-b245-15fb85fb6377')
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [MainImage], [BlogCategoryId], [CustomUserId]) VALUES (40, N'“Google” Rusiyada reklam satışını dayandırdı', N'“Alphabet Inc”in törəmə şirkəti olan “Google” Rusiyada onlayn reklam satışını dayandırdığını, qadağanın axtarış sisteminə, “YouTube” və xarici tərəfdaşlara şamil edildiyini bildirib.

“Fövqəladə vəziyyət fonunda biz Rusiyada “Google” reklamını dayandırırıq. Vəziyyət sürətlə inkişaf edir və lazım gəldikdə yeniləmələri paylaşmağa davam edəcəyik”, - deyə şirkətdən bildirilib.

Bundan əvvəl “Google” Rusiya dövlət mediasına öz texnologiyasından istifadə edərək reklam almağı və ya satmağı qadağan etmişdi. Şirkət etiraz və ya müharibə əleyhinə reklamlar istisna olmaqla, müharibədən faydalanmağa çalışan marketinqi qadağan edən həssas hadisələr siyasətinə istinad edib.', CAST(N'2022-03-10T10:23:18.1450602' AS DateTime2), N'87ceb994-104f-44a1-9a5c-64bb387c6c0d-20220310102318-Google.jpg', 1, N'7a00ea2d-2a10-4941-b245-15fb85fb6377')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Commenters] ON 

INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (24, NULL, N'gari', N'dqwdq', N'qdqw', N'dd', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'dd')
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (25, NULL, N'ELDANIZ', N'wefg', N'vsd', N'ascas', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'gfwer')
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (26, NULL, N'ELDANIZ', N'h45', N'45h4', N'45yh45', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'45yh')
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (27, NULL, N'hr', N'eg4e', N'her', N'her', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (28, NULL, N'wfwq', N'fw', N'fwe', N'esvf', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'wes')
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (29, NULL, N'vse', N'vsd', N'vs', N'vsd', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (30, NULL, N'gse', N'sg', N'gs', N'sgb', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (31, NULL, N'wdq', N'fwe', N'we', N'vfgsw', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (32, NULL, N'wdq', N'fwe', N'we', N'vfgsw', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (33, NULL, N'wdqwefwe', N'fwegve', N'wevber', N'vfgswber', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (34, NULL, N'ewf', N'wevf', N'vwe', N'vwe', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (35, NULL, N'ewf', N'wevf', N'vwe', N'vwe', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Commenters] ([Id], [MainImage], [Name], [Surname], [Email], [Content], [CreateDate], [Subject]) VALUES (36, NULL, N'Elvin', N'Babayev', N'elvin.babayev.2015@gmail.com', N'Salam Xəbəriniz maraqlı gəldi', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Mesaj')
SET IDENTITY_INSERT [dbo].[Commenters] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Text], [CreatedDate], [BlogId], [CommenterId], [ParentCommentId]) VALUES (18, N'45yh45', CAST(N'2022-03-04T16:35:17.0854620' AS DateTime2), 35, 26, NULL)
INSERT [dbo].[Comments] ([Id], [Text], [CreatedDate], [BlogId], [CommenterId], [ParentCommentId]) VALUES (25, N'Salam Xəbəriniz maraqlı gəldi', CAST(N'2022-03-11T20:13:51.0968573' AS DateTime2), 38, 36, NULL)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseComments] ON 

INSERT [dbo].[CourseComments] ([Id], [Text], [CreatedDate], [CommenterId], [ParentCommentId], [CourseId]) VALUES (10, N'dd', CAST(N'2022-02-24T18:14:08.6336421' AS DateTime2), 24, NULL, 35)
INSERT [dbo].[CourseComments] ([Id], [Text], [CreatedDate], [CommenterId], [ParentCommentId], [CourseId]) VALUES (11, N'ascas', CAST(N'2022-03-02T18:18:30.5079223' AS DateTime2), 25, NULL, 36)
INSERT [dbo].[CourseComments] ([Id], [Text], [CreatedDate], [CommenterId], [ParentCommentId], [CourseId]) VALUES (12, N'esvf', CAST(N'2022-03-04T16:36:28.4324028' AS DateTime2), 28, NULL, 39)
INSERT [dbo].[CourseComments] ([Id], [Text], [CreatedDate], [CommenterId], [ParentCommentId], [CourseId]) VALUES (13, N'vsd', CAST(N'2022-03-04T16:36:39.6604419' AS DateTime2), 29, NULL, 39)
INSERT [dbo].[CourseComments] ([Id], [Text], [CreatedDate], [CommenterId], [ParentCommentId], [CourseId]) VALUES (14, N'sgb', CAST(N'2022-03-04T16:37:07.9798052' AS DateTime2), 30, NULL, 39)
SET IDENTITY_INSERT [dbo].[CourseComments] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseCategories] ON 

INSERT [dbo].[CourseCategories] ([Id], [Name], [Image], [ImageBack], [SupTitle], [Title]) VALUES (1, N'Dizayn', N'99dc99bb-b722-4643-ac71-b0690c73d9e5-20220304231237-course-category-icon-1.png', N'652570f4-de0a-429c-99f9-a5b573bda244-20220304231237-course-category-icon-1-w.png', N'Əyləncəli və Çətin', N'2D 3D Qrafik və web dizayn ')
INSERT [dbo].[CourseCategories] ([Id], [Name], [Image], [ImageBack], [SupTitle], [Title]) VALUES (2, N' Programlaşdırma', N'8d63dd08-2778-406d-b3ed-ce02953a5b5f-20220304231403-course-category-icon-2.png', N'775fc139-5717-4dd5-9ddd-2df247097a66-20220304231403-course-category-icon-2-w.png', N'Frontend və Bakendi bizlə öyrən', N'İT üzrə biliklər')
INSERT [dbo].[CourseCategories] ([Id], [Name], [Image], [ImageBack], [SupTitle], [Title]) VALUES (3, N'Digital Marketing', N'c3c78c83-fbfa-40ed-b54d-55ee047b00a4-20220304231612-course-category-icon-3.png', N'90ce1c46-9ac7-432c-9518-89e2fdc2c5ae-20220304231612-course-category-icon-3-w.png', N'Marketing dünyasına birlikdə qədəm qoyaq', N'kontent və email marketing, SEO')
INSERT [dbo].[CourseCategories] ([Id], [Name], [Image], [ImageBack], [SupTitle], [Title]) VALUES (4, N'Xarici Dillər', N'acdb0c94-07ba-466c-a16a-303c5c61316c-20220304232048-course-category-icon-4.png', N'5e11cb7d-93ac-45b3-8677-144c8a8eb040-20220304232048-course-category-icon-4-w.png', N'Dünyaya birlikdə addımlayaq', N'Texniki və ümumi xarici dillər')
INSERT [dbo].[CourseCategories] ([Id], [Name], [Image], [ImageBack], [SupTitle], [Title]) VALUES (5, N'Şəbəkələr və Kibertəhlükəsizli', N'e8fde5dc-836d-4a41-8598-17671a3d3760-20220305000814-course-category-icon-5.png', N'a31ce495-b639-447d-ae03-87a32400ba1b-20220305000814-course-category-icon-5-w.png', N'Şəbəkə texnologiyaları və kibertəhlükəsizlik bizlə', N'şəbəkə və kibertəhlükəsizlik')
INSERT [dbo].[CourseCategories] ([Id], [Name], [Image], [ImageBack], [SupTitle], [Title]) VALUES (6, N'Program təminatı', N'8794ef08-3900-424f-a2ef-8046b3c01620-20220304232642-course-category-icon-6.png', N'31cb3e8d-82ea-43f0-bf41-9eb12cf0735b-20220304232642-course-category-icon-6-w.png', N'Bu günün tələblərindən biri', N'Ofis proqramları ')
SET IDENTITY_INSERT [dbo].[CourseCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseCategoryToCourses] ON 

INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (94, 41, 2)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (95, 41, 4)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (104, 35, 6)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (107, 37, 5)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (108, 39, 3)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (109, 39, 4)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (110, 42, 2)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (111, 42, 5)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (112, 38, 4)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (113, 38, 6)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (114, 36, 5)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (115, 40, 1)
INSERT [dbo].[CourseCategoryToCourses] ([Id], [CourseId], [CourseCategoryId]) VALUES (116, 40, 2)
SET IDENTITY_INSERT [dbo].[CourseCategoryToCourses] OFF
GO
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([Id], [Title], [WorkTime], [Address], [Content], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId]) VALUES (19, N'İKT və innovasiyalar mövzusunda şəbəkə tədbiri', N'2 saat', N'Nizami k. 203B, AF Business House, 2-ci mər', N'Tədbirin ən əsas məqsədi, Aİ-nin əsas qurumları tərəfindən əqli mülkiyyət hüquqları sahəsində təqdim olunan mexanizm və imkanlar ilə əlaqədar daha düzgün məlumat vermək, o cümlədən Şərqi tərəfdaşlıq ölkələrində milli patent idarələri, texnologiyaların mübadiləsi idarələri və digər innovasiya ekosistemi iştirakçılarının potensialının artırılması imkanlarını müzakirə etmək və Aİ təşkilatları ilə potensial əməkdaşlıq sahələrini nəzərdən keçirməkdir.

Avropa Komissiyasının (DG GROW) nümayəndəsi əqli mülkiyyət hüquqları sahəsində siyasətlərin gələcəyinə dair əsas nitqi ilə tədbiri açıq elan edəcək. Sonra isə Avropa əqli mülkiyyət hüquqları idarəsi tərəfindən ŞT regionunda KOM-lar və əqli mülkiyyət sahəsində çalışan mütəxəssislər üçün təklif olunan qabaqcıl alət və xidmətlər təqdim olunacaq. Daha sonra Avropa əqli mülkiyyət hüquqları üzrə dəstək xidməti dəyərli təkliflərini təqdim edərək Belarus və Moldova kimi tərəfdaş ölkələrdə Avropa əqli mülkiyyət hüquqları dəstək xidməti səfirlərinin təcrübələrini bölüşəcək. Tədbir iştirakçıları həmçinin elmi-tədqiqat müəssisələri, KOM-lar və biznesə dəstək təşkilatlarının nümayəndələri üçün İKT və innovasiyalar sahəsində əqli mülkiyyət hüquqlarının idarə edilməsi, qorunması və istismarı mövzusunda keçiriləcək xüsusi vebinara dəvət ediləcəklər.', 50.0000, N'azn', 40.0000, N'azn', N'80', CAST(N'2022-03-23T19:41:04.3810000' AS DateTime2), N'01620206-e189-4b9f-9d2c-76a6d17f469a-20220311202515-related-event-img-3.jpg', 47)
INSERT [dbo].[Events] ([Id], [Title], [WorkTime], [Address], [Content], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId]) VALUES (20, N'Buraxılış layihəsi', N'3 saat', N'Nizami k. 203B, AF Business House, 2-ci mər', N' “Code Camp Baku”daki təhsilin yekun layihəsi hesab olunur və çox önəmli rol oynayır. Təqdimat təhsil boyunca keçirilən bütün mövzuları özündə cəmləyir. Buraxılış layihəsi tədrisi bitirdikdən sonra portfolionuzu yaradan başlanğıc nöqtəsidir.

Bu zaman natiqlik və toplum önündə çıxış etmə bacarığınız ilə layihənizi auditoriyaya ətraflı nümayiş etdirərək gördüyünüz işin gedişatını ifadəli şəkildə izah edə bilirsiniz. Bu təcrübə sizi gələcək iş həyatında olan təqdimatlarda və çıxışlarda daha uğurlu olmağa hazırlayır. Nəticədə siz layihənizi bitirməklə bütün mövzulardan xəbərdar olan, şirkətlər üçün ixtisaslı işçi olduğunuzu göstərməklə yanaşı, həm də frilans olaraq layihələrdə iştirak biləcəyinizi və stresə dayanıqlı olduğunuzu sübut etmiş olursunuz.', 40.0000, N'azn', 20.0000, N'azn', N'50', CAST(N'2022-04-28T19:45:53.1980000' AS DateTime2), N'85fcb544-334b-47ad-ae23-72de1908cb0c-20220311200236-related-event-img-1.jpg', 47)
INSERT [dbo].[Events] ([Id], [Title], [WorkTime], [Address], [Content], [OldPrice], [OldDiscountPrice], [NewPrice], [NewDiscountPrice], [PricePercent], [CreatedDate], [MainImage], [InstructorId]) VALUES (21, N'Master-klass', N'2 saat', N'Nizami k. 203B, AF Business House, 2-ci mər', N'Dizayn brend və hədəf auditoriyası arasındakı vizual ünsiyyət əhatə edən bir sahədir. İndividuallığa ehtiyacın bu qədər artdığı bir dövrdə qrafik, interior, exterior dizayn və hərəkətli qrafika kimi sahələr olduqca tələbat görür. Bu tədbirə qatılaraq dizayn sahəsinin arzuladığınız istiqamətində gələcəkdə özünüz üçün yeni yeni sahələr aşılaya bilərsiniz.', 50.0000, N'azn', 20.0000, N'azn', N'60', CAST(N'2022-04-07T19:56:57.2020000' AS DateTime2), N'1f88e120-2cf0-45d0-a6b5-bfa3fbac71a6-20220311200252-related-event-img-2.jpg', 47)
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[InstructorRaitings] ON 

INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (196, 47, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (197, 47, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (198, 47, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (199, 47, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (200, 47, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (201, 47, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (202, 47, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (203, 49, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (204, 49, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (205, 49, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (206, 52, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (207, 52, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (208, 52, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (209, 49, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (210, 49, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (211, 49, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (212, 49, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (213, 48, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (214, 48, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (215, 53, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (216, 48, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (217, 48, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (218, 48, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[InstructorRaitings] ([Id], [InstructorId], [Star], [UserSurname], [EndUserId], [UserEmail], [UserName]) VALUES (219, 48, 4, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[InstructorRaitings] OFF
GO
SET IDENTITY_INSERT [dbo].[InstructorSocials] ON 

INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (41, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (42, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (43, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (44, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (45, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (46, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (47, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (48, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (49, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (50, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (51, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (52, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (53, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (54, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (55, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (56, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (57, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (58, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (59, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (60, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (61, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (62, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (63, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (64, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (65, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (66, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (67, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (68, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (69, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (70, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (71, N'twitter', N'fab fa-twitter', N'https://twitter.com/')
INSERT [dbo].[InstructorSocials] ([Id], [Name], [Icon], [Link]) VALUES (72, N'youtube ', N'fab fa-youtube', N'https://www.youtube.com/')
SET IDENTITY_INSERT [dbo].[InstructorSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[InstructorToSocials] ON 

INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (263, 47, 1)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (264, 47, 2)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (265, 47, 3)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (266, 47, 4)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (267, 48, 49)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (268, 48, 50)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (269, 48, 51)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (270, 48, 52)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (271, 49, 49)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (272, 49, 50)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (273, 49, 51)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (274, 49, 52)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (279, 50, 53)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (280, 50, 54)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (281, 50, 55)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (282, 50, 56)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (283, 51, 69)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (284, 51, 70)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (285, 51, 71)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (286, 51, 72)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (287, 52, 49)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (288, 52, 50)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (289, 52, 51)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (290, 52, 52)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (291, 53, 57)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (292, 53, 58)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (293, 53, 59)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (294, 53, 60)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (295, 54, 57)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (296, 54, 58)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (297, 54, 59)
INSERT [dbo].[InstructorToSocials] ([Id], [InstructorId], [InstructorSocialId]) VALUES (298, 54, 60)
SET IDENTITY_INSERT [dbo].[InstructorToSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'Business')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (2, N'Corporate')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'Blog')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (4, N'Marketing')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (5, N'Creative')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (6, N'Web')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (7, N'Workers')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[TagToBlogs] ON 

INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (91, 35, 3)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (92, 35, 4)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (93, 35, 6)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (94, 34, 2)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (95, 34, 3)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (96, 34, 6)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (119, 38, 3)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (120, 38, 6)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (121, 39, 2)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (122, 39, 7)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (123, 40, 1)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (124, 40, 4)
INSERT [dbo].[TagToBlogs] ([Id], [BlogId], [TagId]) VALUES (125, 40, 7)
SET IDENTITY_INSERT [dbo].[TagToBlogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Surname], [Phone], [Email], [Graduate], [CreatedDate], [CourseId]) VALUES (47, N'ELDANIZ', N'Bashicaarov', N'665464', N'wefwef', N'fqw', CAST(N'2022-03-09T13:05:00.0000000' AS DateTime2), 36)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Title], [Content], [Image], [ImageBack]) VALUES (3, N'Məzunlarımızın uğurları bizim uğurumuzdur!', N'<p>Biz dərsləri Zəmanətli Təhsil Sistemi ilə Beynəlxalq Sertifikasiya imtahanlarının kurrikulumu əsasında keçirik. Talant Mərkəzi, Mentor Sistemi kimi özəlliklər və müasir tədris metodları ilə onlara praktiki məşğələlər təklif edirik..</p>', N'99051d4a-ebd7-43a2-b11a-ef59669e2421-20220212110539-about-img.png', N'80ed1722-67c4-44fd-9807-42f76280c817-20220212110539-banner-img-bg.png')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Advices] ON 

INSERT [dbo].[Advices] ([Id], [Content]) VALUES (2, N'<b>Xüsusi texnologiya üçün bütün ilkin şərtləri müəyyən edin</b>')
INSERT [dbo].[Advices] ([Id], [Content]) VALUES (3, N'Öyrənmə prosesi üçün düzgün resursları tapın')
INSERT [dbo].[Advices] ([Id], [Content]) VALUES (5, N'<b>Öyrəndiyiniz şeyləri məşq edin</b>')
INSERT [dbo].[Advices] ([Id], [Content]) VALUES (6, N'Biliklərinizi Sınayın')
SET IDENTITY_INSERT [dbo].[Advices] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (6, N'Haqqımızda', N'About')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (7, N'Kurslarımız', N'Course')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (8, N'Kurs haqqında', N'CourseDetails')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (9, N'Tədbirlərimiz', N'Event ')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (10, N'Tədbir haqqında', N'EventDetails')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (11, N'Müəllimlərimiz', N'Instructor ')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (12, N'Müəllim haqqında', N'InstructorDetails')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (13, N'Kurs satışı', N'Pricing')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (14, N'Tez-tez verilən suallar', N'Faq')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (15, N'İKT Xəbərləri', N'Blog')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (16, N'Ətraflı', N'BlogDetails')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (17, N'Bizimlə əlaqə', N'Contact')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (22, N'Məzunlarımız', N'Student List')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[FAQs] ON 

INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (1, N'Code Camp Baku haqqında ətraflı bildirərdiniz?', N'2022-ci ildə fəaliyyətə başlayan Code Camp Baku yüksək texnologiyalar sahəsində təcrübəli mütəxəssislər hazırlayan tədris müəssisəsidir. Code Campın məqsədi Azərbaycanda bu sahədə karyera qurmaq istəyənlərin potensialını dəyərləndirmək, fərdi və peşəkar inkişafı üçün onları lazımi məlumatlarla və praktiki vərdişlərlə təmin etməkdir.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (2, N'Akademiyanı bitirdikdə diplom və ya sertifikat verirsiniz?', N'Dərsləri başa çatdıqdan sonra hər bir tələbə növbəti bir ay ərzində əvvəlcədən təyin olunmuş mövzular əsasında yekun layihə hazırlamalıdır. Tələbə tədris boyunca öyrəndiklərini layihədə həm praktiki, həm də nəzəri cəhətdən göstərməli, öz bilik və bacarıqlarını tam şəkildə əks etdirməlidir. Bu layihə əsasında tələbənin araşdırma, təqdimat, analiz bacarıqları, texniki bilikləri dəyərləndirilir və müəllim tələbənin məzun olub-olmaması barəsində qərar verir. Sonda uğurlu nəticə əldə edən tələbələrimiz Code Camp məzunu adını qazanır və tədrisi başa vurduqlarını bildirən Code Campın rəsmi diplomu verilir.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (3, N'Harada yerləşir?', N'Code Academy şəhərin mərkəzində, gediş-gəliş üçün ictimai nəqliyyat imkanlarının əlverişli olduğu bir məkanda, Nizami küçəsi 203B, AF Business House-un 2-ci mərtəbəsində yerləşir.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (4, N'Online tədris var?', N'Bəli, Code Camp daxilində bütün tədris proqramları üzrə online tədris keçirilir. Tələbələr başlayacaq qruplara online qeydiyyatdan keçərək sinifdaxili tələbələr ilə birlikdə dərsdə canlı şəkildə iştirak edirlər. Online qoşulan tələbələr tədris proqramının tərkib hissəsi olan ev tapşırıqları, quiz və test, kiçik və buraxılış layihələrini təhvil verib Code Campdan məzun ola bilərlər.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (5, N'Hansı tədris proqramları var?', N'Burada Qrafik və Veb Dizayn, Hərəkətli Qrafika və 2D animasiya, Digital Marketinq, Proqramlaşdırma, Sistem Administratorluğu, 3D Animasiya və Vizualizasiya kimi istiqamətlərdə peşəkar təhsil verilir.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (6, N'Kompüterim Niyə Sadəcə Söndü?', N'Your computer might have unexpectedly shut down because it has gathered too much dust. Your computer fans can only take so much dust in them before they start to overheat.

The best way to make sure this doesn’t happen is to regularly clean and dust your desktop or laptop.

If you can’t for some reason get it to turn back on, just give us a ring and one of our tech experts can help.

')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (7, N'E-poçtun Spam Olduğunu Necə Anlaya bilərəm?', N'E-poçtun spam olub-olmadığını müəyyən etmək bəzən çətin ola bilər, xüsusən də göndərən e-poçtu qanuni mənbədən gələn kimi göstəribsə.

Qanuni görünən, lakin şəxsi məlumatlarınızı almağa çalışan e-poçtlar "fishing" e-poçtları kimi tanınır.

E-poçtun sizə göndərildiyi vebsaytdan əmin deyilsinizsə, keçidin üzərinə gedin və onun e-poçtun sonu ilə eyni ünvana malik vebsayta keçib-keçməməsinə baxın. Nümunə: johndoe@google.com ünvanından e-poçt, e-poçt sizi google.com-dakı linkə göndərir. E-poçt ünvanı linkin domen adına uyğun gəlmirsə, ondan ehtiyatlı olun.

Spam e-poçtlar kompüterinizə zərər verə biləcək viruslarla əhatə oluna bilər, ona görə də həmişə klikləməyin təhlükəsiz olub-olmadığını yoxlayın.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (8, N'Veb saytım sındırılsa nə baş verir?', N'Veb saytınız sındırılıbsa, bu, adətən hakerlərin istifadəçi adınızı və şifrənizi tapmasıdır.

Veb saytınızın sındırılmasının qarşısını almağın ən yaxşı yolu müxtəlif saytlar və hesablar üçün unikal və güclü parollar yaratmaqdır. Heç vaxt heç bir şey üçün eyni iki parola sahib olmayın və hakerlər həmişə təhlükəsiz aktivlərinizə daxil olmaqda çətinlik çəkəcəklər.

Kimsə veb saytınıza müdaxilə edərsə, ehtiyat planın olması həmişə yaxşı təcrübədir. Gündəlik ehtiyat nüsxələri və canlı dəstək ilə təhlükəsiz, xüsusi hostinq üçün qeydiyyatdan keçməklə belə bir tədbir üçün ən yaxşı təcrübələrə malik olduğunuzdan əmin olun.')
INSERT [dbo].[FAQs] ([Id], [Question], [Answer]) VALUES (9, N'Routerimi sıfırlamaq İnternet bağlantısını düzəldirmi?', N'Onu söndürüb yenidən açmağa cəhd etmisiniz? Necə olur ki, bu düzəliş marşrutlaşdırıcınızı sıfırlamaq üçün işləyir?

Bəzən simsiz internet bağlantınız sabit olmur, bunun səbəbi avadanlıq həddindən artıq qızması və ya internet ötürmə qabiliyyətinin həddindən artıq istifadəsi ola bilər. Routerinizi sıfırlamaq tez-tez bu problemləri həll edə bilər.

Əgər belə deyilsə, bu, keçidiniz və ya firewallınızla bağlı ola bilər. Əgər əmin deyilsinizsə, sadəcə olaraq (994) 12-459-25-25 nömrəli telefon vasitəsilə dəstək komandamızla əlaqə saxlayın və ya bizə e-poçt göndərin.')
SET IDENTITY_INSERT [dbo].[FAQs] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Title], [SubTitle], [CreatedDate], [Image]) VALUES (1, N'Campus', N'Tələbələrimiz akademiyaya gələrək dərslərdə birbaşa iştirak edib tədrisə yiyələnə bilərlər.', CAST(N'2022-02-12T13:53:12.5080000' AS DateTime2), N'7809e543-ac07-4976-8a7e-a2a55f34459e-20220212135312-feature-icon-1.png')
INSERT [dbo].[Features] ([Id], [Title], [SubTitle], [CreatedDate], [Image]) VALUES (2, N'Online Campus', N'Online qeydiyyatdan keçərək sinifdaxili tələbələr ilə birlikdə dərsdə canlı şəkildə iştirak edib tədris proqramının tərkib hissələrini təhvil verib məzun ola bilərlər.', CAST(N'2022-02-12T13:53:23.6610000' AS DateTime2), N'94181c83-9326-4dfa-b72d-ca48f075894d-20220212135323-feature-icon-2.png')
INSERT [dbo].[Features] ([Id], [Title], [SubTitle], [CreatedDate], [Image]) VALUES (3, N'24x7 Program', N'İstədiyin yerdə və zamanda dərsləri öyrənə bilərsiniz. Ehtiyacınız olan tək şey internet bağlantısıdır.', CAST(N'2022-02-12T13:53:32.8040000' AS DateTime2), N'b5420a2d-d457-46bd-96d1-14b5f14224fb-20220212135332-feature-icon-3.png')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Feedbacks] ON 

INSERT [dbo].[Feedbacks] ([Id], [Fullname], [Content], [Position], [CreatedDate], [Image]) VALUES (1, N'Samir Əmirullayev', N'
"Belə bir müqayisə edə bilərəm ki, adətən Paşa Banka müraciət edən az təcrübəli bir kandidatla müsahibə aparıb işə götürəndən sonra həmin işçinin tam olaraq komandalara adaptasiyası və texnologiyanı öyrənməsi təxminən 2-3 ay vaxt aparır. Amma Bootcamp məzunlarında artıq biz görürük ki, onlara maksimum 2 həftə vaxt lazım olacaq. Bu da düşünürəm ki, həm bank üçün, həm də Code Academy üçün çox sevindirici bir haldır." ', N'Sabi Bank İnzibatı Direkror', CAST(N'2022-02-13T14:35:18.1460000' AS DateTime2), N'067636c4-b278-4299-afc6-ad3826b76580-20220213143518-recent-post-1.jpg')
INSERT [dbo].[Feedbacks] ([Id], [Fullname], [Content], [Position], [CreatedDate], [Image]) VALUES (4, N'Hakim Babayev', N'
"Code Camp Baku ilə olan uğurlu korporativ əməkdaşlığımız nəticəsində sıfırdan digital marketinq komandası qurmağa nail olduq və beləcə Havas yalnız ənənəvi deyil həm də digital həllər təklif edən aparıcı şirkətlərdən birinə çevrildi." ', N'İnzibatçı Direktorr', CAST(N'2022-02-13T14:35:38.9000000' AS DateTime2), N'c75c6819-a655-4236-8903-0986e67ed8d1-20220213143538-course-detail-instructor-img.jpg')
INSERT [dbo].[Feedbacks] ([Id], [Fullname], [Content], [Position], [CreatedDate], [Image]) VALUES (5, N'Angelina Lary', N'Xarici uyğunlaşma və daxili inteqrasiya problemlərinin öhdəsindən gəlməyi öyrənərkən müəyyən bir qrup tərəfindən icad edilən, kəşf edilən və ya inkişaf etdirilən ortaq əsas fərziyyələrin nümunəsi etibarlı sayılacaq və buna görə də yeni üzvlərə düzgün üsul kimi öyrədiləcək qədər yaxşı işləmişdir. bu problemlərə münasibətdə dərk etmək, düşünmək və hiss etmək yolu.', N'"Microsoft Compani" Aparıcı mütəxəssis', CAST(N'2022-02-13T14:35:57.3320000' AS DateTime2), N'0a342d8c-b0d1-468a-baae-4796b7b3bf1d-20220213143557-client-2.jpg')
SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (13, N'eldaniz@com.com', N'ELDANIZ', N'dqwwfcqw', CAST(N'2022-02-19T13:11:15.0560627' AS DateTime2), N'0558506179', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (14, N'eldvsdvaniz@com.com', N'PARVANA', N' fcb gerger', CAST(N'2022-02-19T13:16:15.7494106' AS DateTime2), N'05585061796', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (15, N'eldaffniz@com.com', N'ELDANIZ', N'sdvsdv evwev1', CAST(N'2022-02-19T13:18:51.3539833' AS DateTime2), N'0558506179sdggs', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (16, N'elddfdaniz@com.com', N'PARVANA', N'sdvfwevfwe2', CAST(N'2022-02-19T13:19:07.5023435' AS DateTime2), N'0558506179htf', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (17, N'gulbeniz@gvdhagv', N'Gulbeniz', N'basvhgcvasvc hwqdbqwhcvbd  qkjfcbquicb', CAST(N'2022-02-19T13:21:34.4899485' AS DateTime2), N'0556956886', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (18, N'bir@jnaks', N'bir', N'hcvuhqc nuicbh', CAST(N'2022-02-19T23:58:31.5545339' AS DateTime2), N'256', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (21, N'ELDANIZ', N'eldaniz@com.com', N'wqacc', CAST(N'2022-03-04T18:44:26.1056435' AS DateTime2), N'5545415', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (22, N'ELDANIZdfbbdf', N'eldaniz@com.com', N'wqacc', CAST(N'2022-03-04T18:44:43.3680643' AS DateTime2), N'5545415', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (23, N'ELDANIZ', N'fwef', N'csacas', CAST(N'2022-03-04T18:46:32.9167944' AS DateTime2), N'0558506179', NULL)
INSERT [dbo].[Messages] ([Id], [Fullname], [Email], [Text], [CreatedDate], [Phone], [Ready]) VALUES (24, N'ascsc', N'casascs', N'cacas', CAST(N'2022-03-11T21:46:02.6605074' AS DateTime2), N'315941', NULL)
SET IDENTITY_INSERT [dbo].[Messages] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Name], [Link], [CreatedDate], [Image]) VALUES (2, N'Rosen', N'https://www.w3schools.com/howto/howto_css_sticky_element.asp', CAST(N'2022-02-12T13:42:52.0537632' AS DateTime2), N'23a40bb2-9712-4ac1-ba69-092203f45ec8-20220212134252-brand-2.png')
INSERT [dbo].[Partners] ([Id], [Name], [Link], [CreatedDate], [Image]) VALUES (4, N'Sara', N'https://www.w3schools.com/howto/howto_css_sticky_element.asp', CAST(N'2022-02-12T13:43:05.4862807' AS DateTime2), N'7651dbc6-a0f4-406c-bc59-590b6478c90d-20220212134305-brand-3.png')
INSERT [dbo].[Partners] ([Id], [Name], [Link], [CreatedDate], [Image]) VALUES (5, N'Rosen', N'https://www.w3schools.com/howto/howto_css_sticky_element.asp', CAST(N'2022-02-12T13:42:38.1638517' AS DateTime2), N'2aa0f3b4-a553-452e-9476-824aace964a1-20220212134238-brand-1.png')
INSERT [dbo].[Partners] ([Id], [Name], [Link], [CreatedDate], [Image]) VALUES (6, N'Rosen', N'https://www.w3schools.com/howto/howto_css_sticky_element.asp', CAST(N'2022-02-12T13:43:15.1591785' AS DateTime2), N'588e3b54-91dc-456f-8641-3191fea839a4-20220212134315-brand-4.png')
INSERT [dbo].[Partners] ([Id], [Name], [Link], [CreatedDate], [Image]) VALUES (7, N'Rosen', N'https://www.w3schools.com/howto/howto_css_sticky_element.asp', CAST(N'2022-02-12T13:43:26.9256163' AS DateTime2), N'c4d3c277-d898-4178-856e-86bba79d600e-20220212134326-brand-5.png')
INSERT [dbo].[Partners] ([Id], [Name], [Link], [CreatedDate], [Image]) VALUES (8, N'Rosen', N'https://www.w3schools.com/howto/howto_css_sticky_element.asp', CAST(N'2022-02-12T13:43:37.2898331' AS DateTime2), N'5545b38a-accf-4bcc-a0f9-fcb9c330137e-20220212134337-brand-6.png')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[Pricings] ON 

INSERT [dbo].[Pricings] ([Id], [Title], [SupTitle], [Price], [Period], [Metod], [Place], [MentorTime], [Type], [Support], [CreatedDate]) VALUES (2, N'Gümüş plan', N'Kiçik qruplar üçün mükəmməldir', N'59', N'Aylıq', N'Kurs müzakirələri', N'Məzmun Kitabxanası', N'1-saat mentor', N'Onlayn', N'Dəstək 24x7', CAST(N'2002-02-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Pricings] ([Id], [Title], [SupTitle], [Price], [Period], [Metod], [Place], [MentorTime], [Type], [Support], [CreatedDate]) VALUES (3, N'Qızıl plan', N'Orta qrupları üçün mükəmməldir', N'69', N'Aylıq', N'Kurs müzakirələri', N'Məzmun Kitabxanası', N'1-saat Mentor köməyi', N'Əyani', N'Dəstək 24x7', CAST(N'2022-02-04T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Pricings] ([Id], [Title], [SupTitle], [Price], [Period], [Metod], [Place], [MentorTime], [Type], [Support], [CreatedDate]) VALUES (4, N'Almaz Planı', N'Böyülk qruplar üçün mükəmməldir', N'79', N'Aylıq', N'Kurs müzakirələri', N'Content Librar', N'1-saat Mentor köməyi', N'Onlayn', N'Dəstək 24x7', CAST(N'2002-02-20T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Pricings] OFF
GO
SET IDENTITY_INSERT [dbo].[Programs] ON 

INSERT [dbo].[Programs] ([Id], [Title], [Content], [MainImage]) VALUES (1, N'Məktəblilər və məzunlar (14-18 yaş)', N'IT mütəxəssisi olmaq xəyallarını təxirə salmadan ilk peşəsinə hazırlaşmağa başlayacaqlar', N'19cd4797-0190-4b1a-b3e0-86b65dc71aad-20220304224402-academic-1.jpg')
INSERT [dbo].[Programs] ([Id], [Title], [Content], [MainImage]) VALUES (2, N'Universitet tələbələri (18-23 yaş)', N'Universitet təhsili ilə paralel olaraq ikinci ixtisasa hazırlıq', N'b73be437-cd73-40bc-9dff-5f3a9d1b6c65-20220304224412-academic-2.jpg')
INSERT [dbo].[Programs] ([Id], [Title], [Content], [MainImage]) VALUES (3, N'Digər peşələrin nümayəndələri (23-55 yaş)', N'Mövcud karyera və maliyyə perspektivlərindən razı olmayanlar yeni ixtisas əldə etmək üçün hazırlaşa və IT sahəsində karyera qura biləcəklər.', N'08172cde-5c5f-4e37-a9ca-437eb0eb771e-20220304224422-academic-3.jpg')
INSERT [dbo].[Programs] ([Id], [Title], [Content], [MainImage]) VALUES (4, N'IT sahəsində təhsil almaq üçün təməl bilik almaq istəyən hər kəs (18-55 yaş)', N'Biliklərini sistemləşdirə və müasir IT sahəsində tələb olunan iş bacarıqlarına yiyələnirlər', N'ae854b3f-ce4e-44b2-87a8-d5341230b45c-20220304224432-academic-4.jpg')
SET IDENTITY_INSERT [dbo].[Programs] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Address], [Phone], [Email], [ContactInfo], [Logo], [EventImage], [FeatureImage], [AboutVideo], [BannerImage], [BannerImageBack], [SupTitle], [Title], [LocationOnMap]) VALUES (2, N'Nizami küç. 203B, AF Business House, 2-ci mərtəbə', N'+99412 310 0113/ +99450 444 2633', N'info@codecamp.com', N'Bizim tələbələrin aldığı bilik və bacarıqlar şirkətlərin bu günkü və gələcək tələblərinə uyğun olmalıdır. Buna görə də biz hər altı aydan bir kurs proqramlarına baxır və onları yeniləyirik.', N'819f6302-c4fc-4271-8817-ffc6665dbb98-20220310123620-logo2.png', N'2b94d25b-ac11-4350-a38c-40ee85b2b12c-20220305230205-event-img.jpg', N'8f837a02-e7fc-4a54-a59c-acb3d6ae735a-20220305230205-coure-features-img.jpg', NULL, NULL, N'8071111e-f944-4ee7-b62a-7eab92c640ba-20220305230205-about-img-bg.png', N'CodeCamp ilə kodlamağı öyrənən milyonlarla insana qoşulun', N'Ən yaxşı müəllimdən dərs alın', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2639.711861524853!2d49.85172681493181!3d40.37719806596754!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d077c61fef3%3A0xfa4594c97092ca01!2sAF%20Business%20House!5e1!3m2!1sen!2sus!4v1643432507953!5m2!1sen!2sus')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'facebook', N'fab fa-facebook-f', N'https://www.facebook.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'instagram', N'fab fa-instagram', N'https://www.instagram.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'twitter', N'fa fa-twitter', N'https://twitter.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (5, N'pinterest', N'fa fa-pinterest-p', N'https://www.pinterest.com/')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscribes] ON 

INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (37, N'elvin.babayev.2015@gmail.com', CAST(N'2022-02-24T18:01:59.5993307' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (130, N'amirovorxan@gmail.com', CAST(N'2022-03-04T17:09:16.6978339' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (131, N'amfirovorxan@gmail.com', CAST(N'2022-03-04T17:14:33.4597676' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (132, N'eldanizjb@code.edu.az', CAST(N'2022-03-04T17:50:31.7572315' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (133, N'fc', CAST(N'2022-03-10T10:51:01.7066676' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (134, N'cvü', CAST(N'2022-03-10T10:51:34.7757479' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (135, N'qaqa', CAST(N'2022-03-10T10:51:41.3338067' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (136, N'1', CAST(N'2022-03-10T11:02:05.1503123' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Subscribes] OFF
GO
