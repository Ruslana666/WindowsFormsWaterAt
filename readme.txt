Для доступа к бд, нужно в папке ./WindowsFormsWaterAt найти [App.config]. В нём нужно заменить слова на свои. Пример

Вот раздел

<connectionStrings>
  <add name="WindowsFormsWaterAt.Properties.Settings.wateratrConnectionString" connectionString="Data Source=KOMPUTER\SQLEXPRESS;Initial Catalog=wateratr;Integrated Security=True;TrustServerCertificate=True" providerName="System.Data.SqlClient" />
  <add name="ModelWaterAtrEnt" connectionString="metadata=res://*/ModelWaterAtr.csdl|res://*/ModelWaterAtr.ssdl|res://*/ModelWaterAtr.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=KOMPUTER\SQLEXPRESS;initial catalog=wateratr;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>

В них есть [connectionString], где [Data Source] = [KOMPUTER\SQLEXPRESS;].
Тут нужно заменить [KOMPUTER\SQLEXPRESS;] на своё. ВЕЗДЕ!!!!!!!
В данном примере всего 2

Как узнать, как называется у меня?

1. Открываем SMSS
2. При открытии программы, будет открыто окно с соединением с сервером, там в строке имя сервера нужное нам названия имя сервера