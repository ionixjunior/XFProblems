using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void SampleOk ()
		{
			app.Tap (e => e.Marked("btnUiTests"));
			app.EnterText (e => e.Marked("etr1"), "Valor  1");
			app.EnterText (e => e.Marked("etr2"), "Valor  2");
		}

		[Test]
		public void SampleSwitchCellError ()
		{
			app.Tap (e => e.Marked("tclSwitchCell"));
		}

		[Test]
		public void SampleSwitchCellOk ()
		{
			app.Tap (e => e.Text("Desabilitando SwitchCell"));
		}

		[Test]
		public void ToolbarItemOk()
		{
			app.Tap (e => e.Marked("tbiTest"));
			app.Tap (e => e.Text("Fechar"));
		}
	}
}

