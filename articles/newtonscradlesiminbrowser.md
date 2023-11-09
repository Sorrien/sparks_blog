I've been playing around with Bevy and learning to use it recently. I'm still working on creating a game with Bevy and I hope to post here about that soon. In the meantime I've been making smaller toys that are fun to build and, hopefully, also fun to play with.

The first toy I have made in Bevy that I want to share is my Newton's Cradle Simulation. Part of what makes Bevy so interesting for projects like this is that it is simple and easy to run simple Bevy projects in the browser.

If you wanted to build this project yourself you absolutely could. The github repository for it is right [here](https://github.com/Sorrien/newtons_cradle). If I were so inclined I could also make executables available to everyone and distribute it that way. That takes some trust on your part and more effort on mine to build out pipelines for various platforms.

The beauty of Bevy's ability to compile to Web Assembly is that I don't need to worry about any of that. You have had the ability to play with my newton's cradle from this web page this whole time. That is assuming of course that you are not reading this on your phone, unfortunately.

Go ahead, click play. I'll be right below when you get bored with it, and please: turn on your sound. I spent a long time tuning the clicks and clacks.

<div class="embed-responsive embed-responsive-16by9">
  <iframe class="embed-responsive-item" src="https://sorrien.github.io/newtons_cradle/"></iframe>
</div>

I hope that was as entertaining to play with as it was to write. This version is embedded in an iframe but if you'd like to see the original page you can find it [here](https://sorrien.github.io/newtons_cradle/).

Growing up I played a lot of silly Flash games of a similar scope to this. For those that really enjoy using Javascript it may not seem like a big deal to use an HTML canvas for a game. I have never really enjoyed writing Javascript and Web Assembly will let you write your game in any language. This blog is currently running in C# with Blazor and the Newton's Cradle sim is running in Rust with Bevy. My favorite thing about this blog is that there is no scripts folder and no JS written by me whatsoever.