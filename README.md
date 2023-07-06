# QuizMaker

# Lokale Datenbank anlegen

Hier inst in Screenshots festgehalten wei man die lokale Datenbank anlegt, damit das Programm Daten schreiben und entfernen kann:

![2023-07-06 14_27_20-](./misc/2023-07-06 14_27_20-.png)

![2023-07-06 14_28_37-Window](./misc/2023-07-06 14_28_37-Window.png)



Doppelklick auf die Datenbank:

![2023-07-06 14_29_16-Window](./misc/2023-07-06 14_29_16-Window.png)

![2023-07-06 14_29_36-Window](./misc/2023-07-06 14_29_36-Window.png)



Folgenden Befehl in das Feld kopieren:

```
CREATE TABLE [dbo].[QuestionsTable] (
    [Id]             INT  IDENTITY (1, 1) NOT NULL,
    [category]       TEXT NULL,
    [question]       TEXT NULL,
    [answer_correct] TEXT NULL,
    [answer_wrong1]  TEXT NULL,
    [answer_wrong2]  TEXT NULL,
    [answer_wrong3]  TEXT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

![2023-07-06 14_32_44-Window](./misc/2023-07-06 14_32_44-Window.png)

Update

![2023-07-06 14_33_19-Window](./misc/2023-07-06 14_33_19-Window.png)