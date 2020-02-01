# Резюме

RFID

Всички фирми, които разполагат с голям брой служители се нуждаят от някакъв вид система за контрол на достъпа. Какво предлагаме ние? Създаване на система за контрол на достъп, контролирана от четци за карти и чипове, е изключително ефективен начин за управление на посещенията в сграда, както и проследяване на работното време за фирмен и хоноруван персонал. Системата изгражда ефективен пропускателен режим чрез удобна и модерна безконтактна радиочестотна технология (RFID).RFID е технология, която ни заобикаля всеки ден. Това е в нашите кредитни карти, паспорти и някои от продуктите, които купуваме. Дори и много от нашите домашни любимци имат RFID чипове в тях!

Employee-Management е проект, базиран на Arduino, чиято цел е да ограничава достъпа на външни лица до дадена сграда и да следи кой кога е влизал и колко часа е работил месечно.

Проектът може да помогне на много собственици на фирми, както малки така и големи.

# Summary

  

RFID

  

All companies that have a large number of employees need some kind of access control system. What do we offer? Creating an access control system controlled by card readers and chips is an extremely effective way to manage visits to a building, as well as track business hours for the company and part-time staff. The system builds effective bandwidth through convenient and modern contactless radio frequency (RFID) technology. RFID is a technology that surrounds us every day. This is in our credit cards, passports and some of the products we buy. Even many of our pets have RFID chips in them!

Employee-Management is an Arduino-based project that aims to limit outsiders' access to a building and keep track of who entered, and how many hours they worked, per month.

The project can help many business owners, both small and large.

# УВОД

Проектът Employee-Management, се състои от софтуер и хардуер.

  

Софтуерът е разработен на Visual Studio и на платформата UWP

(Универсалната Windows платформа) създадена от

Microsoft използвайки: C ++ , C # , VB.NET и XAML. Софтуерът има за

цел да складира в база от данни всички служители (с тяхната

информация) от една компания. Предоставя информация за всеки

служител кога е влязъл и напуснал сградата и колко часа е работил.

Също пази информация колко часа е работил служител за целия месец

(което улеснява калкулирането му на месечна заплата, особено

полезно при почасова ставка на формиране на заплатата).

  

Хардуерът се състои от RFID четец, който прочита идентифициращия

код на една карта или чип и го праща по сериен порт на софтуера. Има и

бутон, който служи за ръчно отключване на ключалката без да се

нуждае хардуера от връзка с базата от данни. За улесняването на

потребителя са включени светодиоди, които го уведомяват за наличието

на комуникация между хардуера и софтуера, кога може да влезе и кога

не може, а дисплея показва името и фамилията на човека сканирал чипа

На дисплея също се изписва информация за отваряне на ключалката при

извънредна ситуация или ръчно задействане.

  

  

# Цели на проекта:

  

1.  Ограничаване на външни лица до дадено предприятие
    
2.  Водене на дневен отчет за служители
    
3.  Складиране в база от данни
    
4.  Пресмятане на месечен отчет на работното време
    

  

# Етапи на разработка:

1.  Оформяне на основната идея на проекта
    
2.  Разпределяне на работата на отделни части
    
3.  Създаване на Софтуерът
    
4.  Схема на хардуерната част
    
5.  Реализиране на основната част от хардуера
    
6.  Създаване на база от данни
    
7.  Създаване на логиката по MVC модел
    
8.  Завършване на хардуера
    
9.  Създаване на уеб сайт
    
10.  Оформяне на документацията
    

  
  

#### Документацията е разделена на следните глави:

## Глава 1 - Проектиране и реализация на хардуера

В тази глава съм описал основните компоненти на устройството и неговата

функционална схема.

## Глава 2 - Софтуер

Тук е представен и помощният софтуер, който управлява хардуера.

## Глава 3 - Снимки и начин на работа

Представени са снимки на крайния продукт и начина му на използване в ежедневието.

## Глава 4 - Заключение

Описание на постигнатите резултати и бъдещи идеи за развитие на проекта.

# Глава 1- Проектиране и реализация на хардуера

## 1.1 Компоненти

### 1.1.1 Микроконтролер

В основата на проекта стои контролер Arduino Uno, който намира все по-голямо

приложение в различните проекти свързани с автоматизация. Всеки човек с минимални

познания по електроника може да експериментира с него без големи парични

вложения, тъй като са както евтини, така и лесни за употреба.

  
  
  

![](https://lh6.googleusercontent.com/pp803M3xkXMVNqVxnfZ7hrtEpkwp6kI305xClZhkKIVYqdEt6r6cHHXrAdMI2lFjbJcT7BEoZZglYVZ_5mjCNBvZAQST6Ui5otP8Yy4Y4ZBF9T9zx123TBgf0_6iCRES0iK8vlov)

### Arduino Uno Спецификации:

  

• Микроконтролер: ATmega328P

• Работно напрежение: 5 V

• Захранващо напрежение (препоръчително): 7-12 V

• Цифрови I/O порта: 14 (от които 6 могат да са PWM изходи)

• Аналогови входове: 6

• Максимален ток на I/O порт: 40 mA

### 1.1.2 LCD Character Display

В проекта е включен и дисплей, който служи за улесняване и насочване на служителите. На него се показват и имената на току-що пропуснатия служител.

![](https://lh5.googleusercontent.com/-z0RXO3WysLg8nmlp1_ybQfD1CDbJfnLiezXxGXfh4t-IR8DAHrq_Gep_iF6rXDeAZL0jIhJLdp1MWddZF2H3dndNhuKdccWm34Rqcqyt86PmQEdr2lcsUlQjHratZZ1aEpw7Mx9)

### Дисплей спецификации:

-   Built-in controller (SPLC780D)
    
-   4-bit or 8-bit MPU interfaces
    
-   5×8 dot characters with cursor
    
-   20 character x 4 line display
    
-   Module Size: 98.0mm(L) * 60.0mm(W)* 13.5mm(H)
    
-   Viewing Area: 76.0mm(L)* 25.5mm(W)
    
-   5V / 3.3V input models available
    

  

### 1.1.3 TS90A Servo Micro

Сервото служи за демонстрация на това как ще работи механизма за ключалката.

  

![](https://lh4.googleusercontent.com/ybJcXefb4Dh0q9aShzmnW-uo3MSsGMT8aAKFS9ACz-R8UHywyjWRtKzhWSW3-Zd4kB7lCtVqZrw5M1d196QGGWmPjz_VGKVmfT8xmma_pp91cE34qzloAwS_qEsfdIAS3BjyNuVw)

  

### Servo спецификации:

-   23.2 × 12.5 × 22 mm
    
-   Weight:9 g
    
-   Operating Speed :
    
-   110RPM (4.8V)
    
-   130RPM (6V)
    
-   Stall Torque :
    
-   1.3kg.cm/18.09oz.in(4.8V)
    

### 1.1.4 RFID Reader/Writer RC522 SPI S50

Четецът има е една от най-важните роли в проекта той препраща данните от ардуиното към софтуерът където се извършва валидацията.

![](https://lh6.googleusercontent.com/Uu3_sGeT2k1DJWZi7RDCCrDggffub8IWuMLcztocGICcrLulN14ZL4lVlM19ZsdLqbZkUClXc88kLJCu5gZNqzsCM1gSa9X-eaAAKujlsV2L-7kbDmPIEOQd6xnutMgu59SL3Gff)

-   Voltage: DC 3.3V (Do not use 5V supply)
    
-   Operating Current :13-26mA
    
-   Idle Current :10-13mA
    
-   Operating Frequency: 13.56MHz
    
-   Highly integrated analog circuitry to demodulate and decode responses
    
-   Supports ISO/IEC 14443 A/MIFARE
    
-   Typical operating distance in reading/Write mode up to 50 mm
    

  

### 1.1.5 B3F-1000 - Tactile Switch

Служи за отключване на ключалката в случай че има неустановена връзка с приложението или има посетител в сградата.

### ![](https://lh6.googleusercontent.com/CZgOkGWfAFzS6pl1tTUY8IJ0S34wlYjAec5-Lv4jqizqLrRDPP1RwygXB2oBz3T7_7awcgQj25TiCo-JtgfANkHoL1OAUZ5dHbioGq0qSGxaozbl3ooniy43iQy-qc69zNDZyjyd)

-   Extended mechanical/electrical durability
    
-   Taped radial type, vertical type and high force types are available
    

  
  
  
  

# Глава 2 - Софтуер

Софтуерът е разработен на Visual Studio и на платформата UWP

(Универсалната Windows платформа) създадена от

Microsoft използвайки: C ++ , C # , VB.NET и XAML.

  

![](https://lh3.googleusercontent.com/KaqtEHFDpe5_ors9gp-ek_r7U5ZzGwNiQ_VvgkyEh1CDb8WSo_FHp9hByAe2N8Vl0zTfFZ5UldfBmROopDjj0TWroBEGv9LqUmJro0UYGac30z4mBpFhSOlUkWFiFCAL-1zE_eik)

  

## 2.1 Основни функции.

-   Логин форма която има за цел да ограничи достъпа на потребители различни от регистрираните админи в приложението.
    
-   Регистрационна форма която служи за пазене на основни данни за служителите (егн, телефонен номер, длъжност).
    
-   Форма която показва кога е влязъл даден служител
    
-   Форма която показва всички регистрирани служители до мемента.
    
-   Опция за редактиране на служител (например ако е сменил местоположението на живеене).
    
-   За регистриране на админ в приложението е нужна Master карта.
    

# Глава 3 - Снимки и начин на работа

## 3.1 Начин на работа

## ![C:\Users\C#\AppData\Local\Microsoft\Windows\INetCache\Content.Word\Блокова схемаPNG.PNG](https://lh3.googleusercontent.com/Z_DloyolsMc_ZFudMplkwbdYuREY8sKu8PEEqh3woDgxNiRNm90IDz3pH5eHfz3TzUvteeabdx3VVhfsMiOR0e5v4iM5JyeAND_0e8HrS4q-RD5ppyASl_lnSTU886CWASvSmYvu)

## 3.1.1 Комуникация

Комуникацията между ардуиното и софтуерът се извършва по сериален порт. На софтуерът постоянно върви процес (background worker) който чака подаден сигнал от ардуиното. След като го получи идентификационният номер се проверява дали е наличен в базата от данни, съответно достъпът приет или отказан.

Комуникацията между софтуерът и базата от данни се осъществява чрез ORM (Object Related Mapping)

  

## 3.1.2 База от данни

## ![](https://lh3.googleusercontent.com/C7OiV4jSwNSeFMJu1PGNXYqfLgimopqAgHPBDgYZxpXBJvWREm-n9yL1n4kWxUDhjdXNXrpGcaxgO5ZJmsM7K5pAlugwvLg8fpbUxrHailco1VewAgKn00vW1ZUc7p8we6jmF-u4)

  

Базата от данни е написана MYSQL на MYSQL Workbench достъп до нея се извършва само от приложението в нея се съдържат следните таблици:

1.  Towns:
    

Съдържа информация за градовете.

2.  Duties:
    

Съдържа информация за длъжностите на служителите.

3.  Admins:
    

Информация за хората които имат достъп до приложението.

4.  EmployeeGraph
    

Информация кой кога се е чекирал за текущия ден.

5.  EmployeeGraphMoungth:
    

Информация колко часа е работил един служител.

6.  Employees
    

Информация за всички служители

  
  
  

## 3.1.3 Блокова схема на програмното осигуряване за хардуера

![C:\Users\C#\AppData\Local\Microsoft\Windows\INetCache\Content.Word\code2flow_sDj6uJ.PNG](https://lh6.googleusercontent.com/elEWxWsfp54jJUvJ6OAcV4bkoqZw5Xq6FbSGtuo1rAtgzwt0SFEZ5FOlyO_ZzqZtE1GGKtHRIJ5EryocEeAKIB5JSk4WtiTArej2OXHoeELOOiDkJuDEJ4C922Hca8IGNBBMJBcQ)

## 3.1.4 Електрическа схема

  

![C:\Users\C#\AppData\Local\Microsoft\Windows\INetCache\Content.Word\ProjectWires.png](https://lh5.googleusercontent.com/D9Z9kA63yFw2iW4dObAqycfLsk_VUIGKe-uGP4mGDnUMwPHm9A-IdInqcniuCVyjOnzuPn-yKqMugwBhYMuAINnUe6fSgtgeyOBxZyrC2ovAp6O3rqUBeWmmw9JEJmWfRdL1iL7_)

  

# 3.2 Снимки

![](https://lh4.googleusercontent.com/A7eaNrX36yiebUAYCFPqxkx05JKWhuF-n0xnaMR3YUG82AbfbQddnrRzG-M_EWBBgBkgcwQz5nzK7FrNQCOhyswMLF9RFzD-6Tg5Ligi3oZvtoK7ZvnajIC42qkOM3z7UvV43HEV)

![](https://lh3.googleusercontent.com/e9rfZviaOjZCUWAaZ8c-JiR93ZPe0mxAKnIpDjO-DL8HZv6sb4KHgewBn77fJNi7aXXwgwYYOhBm_jOVvtHYlrKUqgNSkMhjDt_QTKxd7Bl5Am95WfUWIvDFWYkQPYa97jIWhtHH)![](https://lh4.googleusercontent.com/vUg9YSg_BVglnNaeSF5fBBx_8pcstDBsG8Q0fGldN0W6F4PB2Jf-4dEsaMSUewkbM_aAXVrNsJLEuSDvsP0QuAlWt_IJcxst8-O4WfPtfjuTW4RLJ2AZHi7iUbfA_XaoP80KTc3_)

![](https://lh3.googleusercontent.com/ftXtpTm9ahun1YLtUsN3A-bh3bVeBN4fUGEP_1kVw7K6DiImyxPeLhVTeF3HSEFh_dvFLv3kdiw4-tmY3_fse-t87RcjWxxg-QjAse_igmZXP6mu-jXnxcGnS41waVsz8xRz2kTc)

  

![](https://lh3.googleusercontent.com/v_UsDSH84WPGyU8Rwhr2N7K-9rjB4vX8M63J9_TsLucLHl2pMSlf12RpFGJtdi7QNWTZQSjqaorSe3etuYyr5Jxt-dJoXk8cpahcRuRr64fzxpPIAz3TZufSMijZXLkG_pXQnPUM)

# Глава 4 – Заключение

## 4.1 Цел и постигане на целта

Целта на проекта е да направи достъпа ограничен на дадена фирмена сграда и да следи служителите кога влизат и излизат. Също така и да показва колко време е работил даден служител за един месец.

  

Целта е постигната посредством използване на Arduino със

софтуер направен на платформата Universal Windows Platform.

  

Основните предимства на устройството са:

  

1.  Ограничаване на достъпа.
    
2.  Изчистен дизайн на софтуерът който управлява хардуера.
    
3.  Опция за заключване на приложението.
    
4.  Използването му само от регистрирани администратори.
    
5.  LCD дисплей който улеснява служителя.
    

## 4.2 Използвани софтуерни продукти

-   За реализацията на проекта е използвана средата за разработка на Arduino
    
-   микроконтролери - Arduino IDE.
    
-   Софтуерът е разработен на платформата Universal Windows Platform
    
-   Базата от данни е написана на MYSQL на MYSQL WorkBench
    
-   Сайтът ни е разработен на WordPress
    

  

## 4.3 Бъдещо развитие

-   Преместване на Софтуера
    
-   Андроид версия
    
-   Дизайн на хардуера
    
