using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMasaBlazor();
Func<IServiceProvider, IFreeSql> fsqlFactory = r =>
{
    IFreeSql fsql = new FreeSql.FreeSqlBuilder()
        .UseConnectionString(FreeSql.DataType.Sqlite, @"Data Source=freedb.db")
        .UseMonitorCommand(cmd => Console.WriteLine($"Sql��{cmd.CommandText}"))//����SQL���
        .UseAutoSyncStructure(true) //�Զ�ͬ��ʵ��ṹ�����ݿ⣬FreeSql����ɨ����򼯣�ֻ��CRUDʱ�Ż����ɱ�
        .Build();
    return fsql;
};
builder.Services.AddSingleton<IFreeSql>(fsqlFactory);

//builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
