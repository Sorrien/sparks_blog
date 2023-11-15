
# Starting Again

I have rewritten my blog in many different .Net technologies over the years. It's the way I usually teach myself new things that I hope to later use at work.
This rewrite is a bit different because my goal is to make the process of using and maintaining my blog as simple as I can.

# Blazor as a Static Site

Similar to the last rewrite of my blog this one will use Blazor in its WASM form. If you aren't familiar with Web Assembly it is basically a compilation target for your language of choice to run in a browser.
Practically speaking what this means is that I can avoid using Javascript and instead use whatever language I choose for clientside code. In this case we're talking about C# but I've also been experimenting with Rust and running 3D games in your browser with Bevy. More on that later. 

The difference between this and the previous rewrite of my blog is that I will be avoiding any complications or costs for running my blog. I will not be using a database or at least not one that cannot be served as a static file. There will be no APIs to call to the backend because there is no backend.
As of the writing of this article any metadata about blog posts will be stored in a JSON file to be loaded from the static site's server. The actual page you're reading now is a razor page called Post which uses the ID of a post to go load a markdown file. That markdown file is then rendered using the Markdig library as part of the initialization of this razor page.

# Markdown

This is my first article to be written in Markdown. I am much more familiar with the syntax of HTML at this point than I am with Markdown. With practice I am hoping that writing most of the content of my articles in Markdown will make writing faster and easier for me.