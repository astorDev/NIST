class AboutShould : Test
{
    [Test]
    public async Task ReturnValidMetadata()
    {
        var about = await this.Client.GetAbout();
        about.Should().BeEquivalentTo(new About(
            "Template - my webapi",
            "1.0.0.0",
            "Development"
        ));
    }
}