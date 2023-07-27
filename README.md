### Выполнено по техническому заданию:
```Написать на asp .net core razor pages Календарь расписания, с функцией добавить запись прямо в ячейку. Хранить данные в базе MS SQL , общаться с базой через Dapper. Желательно использовать DevExpress.```

### Используемые технологии:
- ASP.NЕT Core Razor Pages
---
- MSSQL
Создана таблица по запросу:
```
CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[AllDay] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```
---
- Dapper
---
- AutoMapper
---
- DevExpress

Был использован шаблон расписания - [Ссылка на пример шаблона](https://demos.devexpress.com/ASPNetCore/Demo/Scheduler/BasicViews/NetCore/Light/)
Внешний вид:
![Image](https://i.ibb.co/fnYgdTJ/image.png)


