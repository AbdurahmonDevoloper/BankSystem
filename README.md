# BankSystem

Ushbu loyiha C# dasturlash tili va .NET platformasida Object-Oriented Programming (OOP) tamoyillari asosida yaratilgan bank hisob raqamlarini boshqarish tizimidir. Dastur konsol interfeysi orqali ishlaydi va foydalanuvchilarga turli xil bank amaliyotlarini bajarish imkoniyatini beradi.

## Loyiha tarkibi va fayllar strukturasi

Loyihaning GitHub omborida professional standartlarga muvofiq faqatgina asosiy kodlar va konfiguratsiya fayllari saqlanadi. Muvaqqat texnik fayllar (`bin`, `obj`) kuzatuvdan chiqarilgan:

* **Models/** — Loyihadagi barcha hisob turlari va asosiy biznes mantiqini o'z ichiga olgan klasslar papkasi (`BankHisobi.cs`, `JamgarmaHisobi.cs`, `KiriditHisobi.cs`).
* **Program.cs** — Dasturning kirish nuqtasi, menyular tizimi va foydalanuvchi interfeysi boshqaruvi.
* **BankTizimi.csproj** — .NET muhitining loyiha konfiguratsiyasi va bog'liqliklar fayli.
* **.gitignore** — Kompilyatsiya jarayonida hosil bo'ladigan texnik fayllarni Git ro'yxatidan cheklash qoidalari.

## Arxitektura va OOP tamoyillari

Dasturni loyihalashda ob'ektga yo'naltirilgan dasturlashning asosiy konseptlaridan to'liq foydalanilgan:

1. **Merosxo'rlik (Inheritance):** `JamgarmaHisobi` va `KiriditHisobi` klasslari yagona tayanch `BankHisobi` klassidan xususiyat va metodlarni meros qilib oladi.
2. **Polimorfizm (Polymorphism):** Pul kiritish (`Deposit`) va pul yechish (`Withdraw`) operatsiyalari har bir hisob turining o'ziga xos shartlaridan kelib chiqib, voris klasslarda qayta talqin qilingan (`override`).
3. **Inkapsulyatsiya (Encapsulation):** Hisob raqamlari xavfsizligini ta'minlash maqsadida balans va mijoz ma'lumotlari to'g'ridan-to'g'ri o'zgartirishdan himoyalangan, ma'lumotlar faqat maxsus metodlar orqali boshqariladi.

## Tizim talablari va ishga tushirish

Loyihani kompyuterda ishga tushirish uchun quyidagi dasturiy ta'minotlar talab etiladi:
* .NET SDK (v8.0 yoki undan yuqori)
* C# qo'shimchasi o'rnatilgan Visual Studio Code yoki Visual Studio IDE

Terminal orqali ishga tushirish buyruqlari:

```bash
# Loyiha papkasiga o'ting
cd BankTizimi

# Loyihani yuklang va ishga tushiring
dotnet run
