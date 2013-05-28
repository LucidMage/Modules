  


<!DOCTYPE html>
<html>
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# githubog: http://ogp.me/ns/fb/githubog#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Torque2D/modules/NetworkToy/1/scripts/client/chatClient.cs at master · Doc308/Torque2D</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub" />
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub" />
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png" />
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png" />
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png" />
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png" />
    <link rel="logo" type="image/svg" href="http://github-media-downloads.s3.amazonaws.com/github-logo.svg" />
    <link rel="xhr-socket" href="/_sockets" />


    <meta name="msapplication-TileImage" content="/windows-tile.png" />
    <meta name="msapplication-TileColor" content="#ffffff" />
    <meta name="selected-link" value="repo_source" data-pjax-transient />
    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="github" name="octolytics-app-id" /><meta content="4422288" name="octolytics-actor-id" /><meta content="6f7e43c85564942a373c140297e6e03edf2d12b9b04f5204215fc9a57df11c82" name="octolytics-actor-hash" />

    
    
    <link rel="icon" type="image/x-icon" href="/favicon.ico" />

    <meta content="authenticity_token" name="csrf-param" />
<meta content="MMv9v95DF3u2n0XMbXK0LW+T51q0S0TON5Ejn7fh/Yo=" name="csrf-token" />

    <link href="https://a248.e.akamai.net/assets.github.com/assets/github-aacfd01406222a8e32af6bf66a2eed1a08267178.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://a248.e.akamai.net/assets.github.com/assets/github2-30896c5685c3dd8da766a4fd3065a563107c9370.css" media="all" rel="stylesheet" type="text/css" />
    


      <script src="https://a248.e.akamai.net/assets.github.com/assets/frameworks-ec9348b8374c693b0749d0b95b215fe3f5414fd0.js" type="text/javascript"></script>
      <script src="https://a248.e.akamai.net/assets.github.com/assets/github-3a11f3836624f198d32737512fe1c445445987b3.js" type="text/javascript"></script>
      
      <meta http-equiv="x-pjax-version" content="bdd56032babb410898471b4229dd697b">

        <link data-pjax-transient rel='permalink' href='/Doc308/Torque2D/blob/1fc96a6b6b1b1018952d1a75ddee2bfdf6558798/modules/NetworkToy/1/scripts/client/chatClient.cs'>
    <meta property="og:title" content="Torque2D"/>
    <meta property="og:type" content="githubog:gitrepository"/>
    <meta property="og:url" content="https://github.com/Doc308/Torque2D"/>
    <meta property="og:image" content="https://secure.gravatar.com/avatar/81752bcbaf035648265f3e456628891d?s=420&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png"/>
    <meta property="og:site_name" content="GitHub"/>
    <meta property="og:description" content="Torque2D - MIT Licensed Open Source version of Torque 2D from GarageGames"/>
    <meta property="twitter:card" content="summary"/>
    <meta property="twitter:site" content="@GitHub">
    <meta property="twitter:title" content="Doc308/Torque2D"/>

    <meta name="description" content="Torque2D - MIT Licensed Open Source version of Torque 2D from GarageGames" />

      <meta name="robots" content="noindex, nofollow">

    <meta content="3093404" name="octolytics-dimension-user_id" /><meta content="8101974" name="octolytics-dimension-repository_id" />
  <link href="https://github.com/Doc308/Torque2D/commits/master.atom" rel="alternate" title="Recent Commits to Torque2D:master" type="application/atom+xml" />

  </head>


  <body class="logged_in page-blob windows vis-public fork env-production  ">
    <div id="wrapper">

      
      
      

      <div class="header header-logged-in true">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/">
  <span class="mega-octicon octicon-mark-github"></span>
</a>

    <div class="divider-vertical"></div>

      <a href="/notifications" class="notification-indicator tooltipped downwards" title="You have no unread notifications">
    <span class="mail-status all-read"></span>
  </a>
  <div class="divider-vertical"></div>


      <div class="command-bar js-command-bar  in-repository">
          <form accept-charset="UTF-8" action="/search" class="command-bar-form" id="top_search_form" method="get">
  <a href="/search/advanced" class="advanced-search-icon tooltipped downwards command-bar-search" id="advanced_search" title="Advanced search"><span class="octicon octicon-gear "></span></a>

  <input type="text" data-hotkey="/ s" name="q" id="js-command-bar-field" placeholder="Search or type a command" tabindex="1" autocapitalize="off"
    data-username="LucidMage"
      data-repo="Doc308/Torque2D"
      data-branch="master"
      data-sha="6ffd761b7297ea0700297dfdc3f61b2d4cf7ed2d"
  >

    <input type="hidden" name="nwo" value="Doc308/Torque2D" />

    <div class="select-menu js-menu-container js-select-menu search-context-select-menu">
      <span class="minibutton select-menu-button js-menu-target">
        <span class="js-select-button">This repository</span>
      </span>

      <div class="select-menu-modal-holder js-menu-content js-navigation-container">
        <div class="select-menu-modal">

          <div class="select-menu-item js-navigation-item selected">
            <span class="select-menu-item-icon octicon octicon-check"></span>
            <input type="radio" class="js-search-this-repository" name="search_target" value="repository" checked="checked" />
            <div class="select-menu-item-text js-select-button-text">This repository</div>
          </div> <!-- /.select-menu-item -->

          <div class="select-menu-item js-navigation-item">
            <span class="select-menu-item-icon octicon octicon-check"></span>
            <input type="radio" name="search_target" value="global" />
            <div class="select-menu-item-text js-select-button-text">All repositories</div>
          </div> <!-- /.select-menu-item -->

        </div>
      </div>
    </div>

  <span class="octicon help tooltipped downwards" title="Show command bar help">
    <span class="octicon octicon-question"></span>
  </span>


  <input type="hidden" name="ref" value="cmdform">

  <div class="divider-vertical"></div>

</form>
        <ul class="top-nav">
            <li class="explore"><a href="/explore">Explore</a></li>
            <li><a href="https://gist.github.com">Gist</a></li>
            <li><a href="/blog">Blog</a></li>
          <li><a href="http://help.github.com">Help</a></li>
        </ul>
      </div>

    

  

    <ul id="user-links">
      <li>
        <a href="/LucidMage" class="name">
          <img height="20" src="https://secure.gravatar.com/avatar/20e85a8574d5c754b5e8f77729fbcfc9?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="20" /> LucidMage
        </a>
      </li>

        <li>
          <a href="/new" id="new_repo" class="tooltipped downwards" title="Create a new repo">
            <span class="octicon octicon-repo-create"></span>
          </a>
        </li>

        <li>
          <a href="/settings/profile" id="account_settings"
            class="tooltipped downwards"
            title="Account settings ">
            <span class="octicon octicon-tools"></span>
          </a>
        </li>
        <li>
          <a class="tooltipped downwards" href="/logout" data-method="post" id="logout" title="Sign out">
            <span class="octicon octicon-log-out"></span>
          </a>
        </li>

    </ul>


<div class="js-new-dropdown-contents hidden">
  <ul class="dropdown-menu">
    <li>
      <a href="/new"><span class="octicon octicon-repo-create"></span> New repository</a>
    </li>
    <li>
        <a href="/Doc308/Torque2D/issues/new"><span class="octicon octicon-issue-opened"></span> New issue</a>
    </li>
    <li>
    </li>
    <li>
      <a href="/organizations/new"><span class="octicon octicon-list-unordered"></span> New organization</a>
    </li>
  </ul>
</div>


    
  </div>
</div>

      

      


            <div class="site hfeed" itemscope itemtype="http://schema.org/WebPage">
      <div class="hentry">
        
        <div class="pagehead repohead instapaper_ignore readability-menu ">
          <div class="container">
            <div class="title-actions-bar">
              

<ul class="pagehead-actions">


    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="authenticity_token" type="hidden" value="MMv9v95DF3u2n0XMbXK0LW+T51q0S0TON5Ejn7fh/Yo=" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="8101974" />

    <div class="select-menu js-menu-container js-select-menu">
      <span class="minibutton select-menu-button js-menu-target">
        <span class="js-select-button">
          <span class="octicon octicon-eye-watch"></span>
          Watch
        </span>
      </span>

      <div class="select-menu-modal-holder js-menu-content">
        <div class="select-menu-modal">
          <div class="select-menu-header">
            <span class="select-menu-title">Notification status</span>
            <span class="octicon octicon-remove-close js-menu-close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container">

            <div class="select-menu-item js-navigation-item selected">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">You only receive notifications for discussions in which you participate or are @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye-watch"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">You receive notifications for all discussions in this repository.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye-unwatch"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">You do not receive any notifications for discussions in this repository.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

    <li class="js-toggler-container js-social-container starring-container ">
      <a href="/Doc308/Torque2D/unstar" class="minibutton js-toggler-target star-button starred upwards" title="Unstar this repo" data-remote="true" data-method="post" rel="nofollow">
        <span class="octicon octicon-star-delete"></span>
        <span class="text">Unstar</span>
      </a>
      <a href="/Doc308/Torque2D/star" class="minibutton js-toggler-target star-button unstarred upwards" title="Star this repo" data-remote="true" data-method="post" rel="nofollow">
        <span class="octicon octicon-star"></span>
        <span class="text">Star</span>
      </a>
      <a class="social-count js-social-count" href="/Doc308/Torque2D/stargazers">0</a>
    </li>

        <li>
          <a href="/Doc308/Torque2D/fork" class="minibutton js-toggler-target fork-button lighter upwards" title="Fork this repo" rel="nofollow" data-method="post">
            <span class="octicon octicon-git-branch-create"></span>
            <span class="text">Fork</span>
          </a>
          <a href="/Doc308/Torque2D/network" class="social-count">227</a>
        </li>


</ul>

              <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
                <span class="repo-label"><span>public</span></span>
                <span class="mega-octicon octicon-repo-forked"></span>
                <span class="author vcard">
                  <a href="/Doc308" class="url fn" itemprop="url" rel="author">
                  <span itemprop="title">Doc308</span>
                  </a></span> /
                <strong><a href="/Doc308/Torque2D" class="js-current-repository">Torque2D</a></strong>
                  <span class="fork-flag">
                    <span class="text">forked from <a href="/GarageGames/Torque2D">GarageGames/Torque2D</a></span>
                  </span>
              </h1>
            </div>

            
  <ul class="tabs">
    <li class="pulse-nav"><a href="/Doc308/Torque2D/pulse" class="js-selected-navigation-item " data-selected-links="pulse /Doc308/Torque2D/pulse" rel="nofollow"><span class="octicon octicon-pulse"></span></a></li>
    <li><a href="/Doc308/Torque2D" class="js-selected-navigation-item selected" data-selected-links="repo_source repo_downloads repo_commits repo_tags repo_branches /Doc308/Torque2D">Code</a></li>
    <li><a href="/Doc308/Torque2D/network" class="js-selected-navigation-item " data-selected-links="repo_network /Doc308/Torque2D/network">Network</a></li>
    <li><a href="/Doc308/Torque2D/pulls" class="js-selected-navigation-item " data-selected-links="repo_pulls /Doc308/Torque2D/pulls">Pull Requests <span class='counter'>0</span></a></li>


      <li><a href="/Doc308/Torque2D/wiki" class="js-selected-navigation-item " data-selected-links="repo_wiki /Doc308/Torque2D/wiki">Wiki</a></li>


    <li><a href="/Doc308/Torque2D/graphs" class="js-selected-navigation-item " data-selected-links="repo_graphs repo_contributors /Doc308/Torque2D/graphs">Graphs</a></li>


  </ul>
  
<div class="tabnav">

  <span class="tabnav-right">
    <ul class="tabnav-tabs">
          <li><a href="/Doc308/Torque2D/tags" class="js-selected-navigation-item tabnav-tab" data-selected-links="repo_tags /Doc308/Torque2D/tags">Tags <span class="counter blank">0</span></a></li>
    </ul>
  </span>

  <div class="tabnav-widget scope">


    <div class="select-menu js-menu-container js-select-menu js-branch-menu">
      <a class="minibutton select-menu-button js-menu-target" data-hotkey="w" data-ref="master">
        <span class="octicon octicon-branch"></span>
        <i>branch:</i>
        <span class="js-select-button">master</span>
      </a>

      <div class="select-menu-modal-holder js-menu-content js-navigation-container">

        <div class="select-menu-modal">
          <div class="select-menu-header">
            <span class="select-menu-title">Switch branches/tags</span>
            <span class="octicon octicon-remove-close js-menu-close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-filters">
            <div class="select-menu-text-filter">
              <input type="text" id="commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
            </div>
            <div class="select-menu-tabs">
              <ul>
                <li class="select-menu-tab">
                  <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
                </li>
                <li class="select-menu-tab">
                  <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
                </li>
              </ul>
            </div><!-- /.select-menu-tabs -->
          </div><!-- /.select-menu-filters -->

          <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket css-truncate" data-tab-filter="branches">

            <div data-filterable-for="commitish-filter-field" data-filterable-type="substring">

                <div class="select-menu-item js-navigation-item ">
                  <span class="select-menu-item-icon octicon octicon-check"></span>
                  <a href="/Doc308/Torque2D/blob/development/modules/NetworkToy/1/scripts/client/chatClient.cs" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="development" rel="nofollow" title="development">development</a>
                </div> <!-- /.select-menu-item -->
                <div class="select-menu-item js-navigation-item selected">
                  <span class="select-menu-item-icon octicon octicon-check"></span>
                  <a href="/Doc308/Torque2D/blob/master/modules/NetworkToy/1/scripts/client/chatClient.cs" class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target" data-name="master" rel="nofollow" title="master">master</a>
                </div> <!-- /.select-menu-item -->
            </div>

              <div class="select-menu-no-results">Nothing to show</div>
          </div> <!-- /.select-menu-list -->


          <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket css-truncate" data-tab-filter="tags">
            <div data-filterable-for="commitish-filter-field" data-filterable-type="substring">

            </div>

            <div class="select-menu-no-results">Nothing to show</div>

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

  </div> <!-- /.scope -->

  <ul class="tabnav-tabs">
    <li><a href="/Doc308/Torque2D" class="selected js-selected-navigation-item tabnav-tab" data-selected-links="repo_source /Doc308/Torque2D">Files</a></li>
    <li><a href="/Doc308/Torque2D/commits/master" class="js-selected-navigation-item tabnav-tab" data-selected-links="repo_commits /Doc308/Torque2D/commits/master">Commits</a></li>
    <li><a href="/Doc308/Torque2D/branches" class="js-selected-navigation-item tabnav-tab" data-selected-links="repo_branches /Doc308/Torque2D/branches" rel="nofollow">Branches <span class="counter ">2</span></a></li>
  </ul>

</div>

  
  
  


            
          </div>
        </div><!-- /.repohead -->

        <div id="js-repo-pjax-container" class="container context-loader-container" data-pjax-container>
          


<!-- blob contrib key: blob_contributors:v21:4804f9b9c322d7f766f5cbabee18a02d -->
<!-- blob contrib frag key: views10/v8/blob_contributors:v21:4804f9b9c322d7f766f5cbabee18a02d -->


<div id="slider">
    <div class="frame-meta">

      <p title="This is a placeholder element" class="js-history-link-replace hidden"></p>

        <div class="breadcrumb">
          <span class='bold'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Doc308/Torque2D" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">Torque2D</span></a></span></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Doc308/Torque2D/tree/master/modules" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">modules</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Doc308/Torque2D/tree/master/modules/NetworkToy" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">NetworkToy</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Doc308/Torque2D/tree/master/modules/NetworkToy/1" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">1</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Doc308/Torque2D/tree/master/modules/NetworkToy/1/scripts" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">scripts</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Doc308/Torque2D/tree/master/modules/NetworkToy/1/scripts/client" class="js-slide-to" data-branch="master" data-direction="back" itemscope="url"><span itemprop="title">client</span></a></span><span class="separator"> / </span><strong class="final-path">chatClient.cs</strong> <span class="js-zeroclipboard zeroclipboard-button" data-clipboard-text="modules/NetworkToy/1/scripts/client/chatClient.cs" data-copied-hint="copied!" title="copy to clipboard"><span class="octicon octicon-clippy"></span></span>
        </div>

      <a href="/Doc308/Torque2D/find/master" class="js-slide-to" data-hotkey="t" style="display:none">Show File Finder</a>


        <div class="commit commit-loader file-history-tease js-deferred-content" data-url="/Doc308/Torque2D/contributors/master/modules/NetworkToy/1/scripts/client/chatClient.cs">
          Fetching contributors…

          <div class="participation">
            <p class="loader-loading"><img alt="Octocat-spinner-32-eaf2f5" height="16" src="https://a248.e.akamai.net/assets.github.com/images/spinners/octocat-spinner-32-EAF2F5.gif?1338956357" width="16" /></p>
            <p class="loader-error">Cannot retrieve contributors at this time</p>
          </div>
        </div>

    </div><!-- ./.frame-meta -->

    <div class="frames">
      <div class="frame" data-permalink-url="/Doc308/Torque2D/blob/1fc96a6b6b1b1018952d1a75ddee2bfdf6558798/modules/NetworkToy/1/scripts/client/chatClient.cs" data-title="Torque2D/modules/NetworkToy/1/scripts/client/chatClient.cs at master · Doc308/Torque2D · GitHub" data-type="blob">

        <div id="files" class="bubble">
          <div class="file">
            <div class="meta">
              <div class="info">
                <span class="icon"><b class="octicon octicon-file-text"></b></span>
                <span class="mode" title="File Mode">file</span>
                  <span>221 lines (175 sloc)</span>
                <span>5.749 kb</span>
              </div>
              <div class="actions">
                <div class="button-group">
                        <a class="minibutton tooltipped leftwards"
                           title="Clicking this button will automatically fork this project so you can edit the file"
                           href="/Doc308/Torque2D/edit/master/modules/NetworkToy/1/scripts/client/chatClient.cs"
                           data-method="post" rel="nofollow">Edit</a>
                  <a href="/Doc308/Torque2D/raw/master/modules/NetworkToy/1/scripts/client/chatClient.cs" class="button minibutton " id="raw-url">Raw</a>
                    <a href="/Doc308/Torque2D/blame/master/modules/NetworkToy/1/scripts/client/chatClient.cs" class="button minibutton ">Blame</a>
                  <a href="/Doc308/Torque2D/commits/master/modules/NetworkToy/1/scripts/client/chatClient.cs" class="button minibutton " rel="nofollow">History</a>
                </div><!-- /.button-group -->
              </div><!-- /.actions -->

            </div>
                <div class="blob-wrapper data type-c js-blob-data">
      <table class="file-code file-diff">
        <tr class="file-code-line">
          <td class="blob-line-nums">
            <span id="L1" rel="#L1">1</span>
<span id="L2" rel="#L2">2</span>
<span id="L3" rel="#L3">3</span>
<span id="L4" rel="#L4">4</span>
<span id="L5" rel="#L5">5</span>
<span id="L6" rel="#L6">6</span>
<span id="L7" rel="#L7">7</span>
<span id="L8" rel="#L8">8</span>
<span id="L9" rel="#L9">9</span>
<span id="L10" rel="#L10">10</span>
<span id="L11" rel="#L11">11</span>
<span id="L12" rel="#L12">12</span>
<span id="L13" rel="#L13">13</span>
<span id="L14" rel="#L14">14</span>
<span id="L15" rel="#L15">15</span>
<span id="L16" rel="#L16">16</span>
<span id="L17" rel="#L17">17</span>
<span id="L18" rel="#L18">18</span>
<span id="L19" rel="#L19">19</span>
<span id="L20" rel="#L20">20</span>
<span id="L21" rel="#L21">21</span>
<span id="L22" rel="#L22">22</span>
<span id="L23" rel="#L23">23</span>
<span id="L24" rel="#L24">24</span>
<span id="L25" rel="#L25">25</span>
<span id="L26" rel="#L26">26</span>
<span id="L27" rel="#L27">27</span>
<span id="L28" rel="#L28">28</span>
<span id="L29" rel="#L29">29</span>
<span id="L30" rel="#L30">30</span>
<span id="L31" rel="#L31">31</span>
<span id="L32" rel="#L32">32</span>
<span id="L33" rel="#L33">33</span>
<span id="L34" rel="#L34">34</span>
<span id="L35" rel="#L35">35</span>
<span id="L36" rel="#L36">36</span>
<span id="L37" rel="#L37">37</span>
<span id="L38" rel="#L38">38</span>
<span id="L39" rel="#L39">39</span>
<span id="L40" rel="#L40">40</span>
<span id="L41" rel="#L41">41</span>
<span id="L42" rel="#L42">42</span>
<span id="L43" rel="#L43">43</span>
<span id="L44" rel="#L44">44</span>
<span id="L45" rel="#L45">45</span>
<span id="L46" rel="#L46">46</span>
<span id="L47" rel="#L47">47</span>
<span id="L48" rel="#L48">48</span>
<span id="L49" rel="#L49">49</span>
<span id="L50" rel="#L50">50</span>
<span id="L51" rel="#L51">51</span>
<span id="L52" rel="#L52">52</span>
<span id="L53" rel="#L53">53</span>
<span id="L54" rel="#L54">54</span>
<span id="L55" rel="#L55">55</span>
<span id="L56" rel="#L56">56</span>
<span id="L57" rel="#L57">57</span>
<span id="L58" rel="#L58">58</span>
<span id="L59" rel="#L59">59</span>
<span id="L60" rel="#L60">60</span>
<span id="L61" rel="#L61">61</span>
<span id="L62" rel="#L62">62</span>
<span id="L63" rel="#L63">63</span>
<span id="L64" rel="#L64">64</span>
<span id="L65" rel="#L65">65</span>
<span id="L66" rel="#L66">66</span>
<span id="L67" rel="#L67">67</span>
<span id="L68" rel="#L68">68</span>
<span id="L69" rel="#L69">69</span>
<span id="L70" rel="#L70">70</span>
<span id="L71" rel="#L71">71</span>
<span id="L72" rel="#L72">72</span>
<span id="L73" rel="#L73">73</span>
<span id="L74" rel="#L74">74</span>
<span id="L75" rel="#L75">75</span>
<span id="L76" rel="#L76">76</span>
<span id="L77" rel="#L77">77</span>
<span id="L78" rel="#L78">78</span>
<span id="L79" rel="#L79">79</span>
<span id="L80" rel="#L80">80</span>
<span id="L81" rel="#L81">81</span>
<span id="L82" rel="#L82">82</span>
<span id="L83" rel="#L83">83</span>
<span id="L84" rel="#L84">84</span>
<span id="L85" rel="#L85">85</span>
<span id="L86" rel="#L86">86</span>
<span id="L87" rel="#L87">87</span>
<span id="L88" rel="#L88">88</span>
<span id="L89" rel="#L89">89</span>
<span id="L90" rel="#L90">90</span>
<span id="L91" rel="#L91">91</span>
<span id="L92" rel="#L92">92</span>
<span id="L93" rel="#L93">93</span>
<span id="L94" rel="#L94">94</span>
<span id="L95" rel="#L95">95</span>
<span id="L96" rel="#L96">96</span>
<span id="L97" rel="#L97">97</span>
<span id="L98" rel="#L98">98</span>
<span id="L99" rel="#L99">99</span>
<span id="L100" rel="#L100">100</span>
<span id="L101" rel="#L101">101</span>
<span id="L102" rel="#L102">102</span>
<span id="L103" rel="#L103">103</span>
<span id="L104" rel="#L104">104</span>
<span id="L105" rel="#L105">105</span>
<span id="L106" rel="#L106">106</span>
<span id="L107" rel="#L107">107</span>
<span id="L108" rel="#L108">108</span>
<span id="L109" rel="#L109">109</span>
<span id="L110" rel="#L110">110</span>
<span id="L111" rel="#L111">111</span>
<span id="L112" rel="#L112">112</span>
<span id="L113" rel="#L113">113</span>
<span id="L114" rel="#L114">114</span>
<span id="L115" rel="#L115">115</span>
<span id="L116" rel="#L116">116</span>
<span id="L117" rel="#L117">117</span>
<span id="L118" rel="#L118">118</span>
<span id="L119" rel="#L119">119</span>
<span id="L120" rel="#L120">120</span>
<span id="L121" rel="#L121">121</span>
<span id="L122" rel="#L122">122</span>
<span id="L123" rel="#L123">123</span>
<span id="L124" rel="#L124">124</span>
<span id="L125" rel="#L125">125</span>
<span id="L126" rel="#L126">126</span>
<span id="L127" rel="#L127">127</span>
<span id="L128" rel="#L128">128</span>
<span id="L129" rel="#L129">129</span>
<span id="L130" rel="#L130">130</span>
<span id="L131" rel="#L131">131</span>
<span id="L132" rel="#L132">132</span>
<span id="L133" rel="#L133">133</span>
<span id="L134" rel="#L134">134</span>
<span id="L135" rel="#L135">135</span>
<span id="L136" rel="#L136">136</span>
<span id="L137" rel="#L137">137</span>
<span id="L138" rel="#L138">138</span>
<span id="L139" rel="#L139">139</span>
<span id="L140" rel="#L140">140</span>
<span id="L141" rel="#L141">141</span>
<span id="L142" rel="#L142">142</span>
<span id="L143" rel="#L143">143</span>
<span id="L144" rel="#L144">144</span>
<span id="L145" rel="#L145">145</span>
<span id="L146" rel="#L146">146</span>
<span id="L147" rel="#L147">147</span>
<span id="L148" rel="#L148">148</span>
<span id="L149" rel="#L149">149</span>
<span id="L150" rel="#L150">150</span>
<span id="L151" rel="#L151">151</span>
<span id="L152" rel="#L152">152</span>
<span id="L153" rel="#L153">153</span>
<span id="L154" rel="#L154">154</span>
<span id="L155" rel="#L155">155</span>
<span id="L156" rel="#L156">156</span>
<span id="L157" rel="#L157">157</span>
<span id="L158" rel="#L158">158</span>
<span id="L159" rel="#L159">159</span>
<span id="L160" rel="#L160">160</span>
<span id="L161" rel="#L161">161</span>
<span id="L162" rel="#L162">162</span>
<span id="L163" rel="#L163">163</span>
<span id="L164" rel="#L164">164</span>
<span id="L165" rel="#L165">165</span>
<span id="L166" rel="#L166">166</span>
<span id="L167" rel="#L167">167</span>
<span id="L168" rel="#L168">168</span>
<span id="L169" rel="#L169">169</span>
<span id="L170" rel="#L170">170</span>
<span id="L171" rel="#L171">171</span>
<span id="L172" rel="#L172">172</span>
<span id="L173" rel="#L173">173</span>
<span id="L174" rel="#L174">174</span>
<span id="L175" rel="#L175">175</span>
<span id="L176" rel="#L176">176</span>
<span id="L177" rel="#L177">177</span>
<span id="L178" rel="#L178">178</span>
<span id="L179" rel="#L179">179</span>
<span id="L180" rel="#L180">180</span>
<span id="L181" rel="#L181">181</span>
<span id="L182" rel="#L182">182</span>
<span id="L183" rel="#L183">183</span>
<span id="L184" rel="#L184">184</span>
<span id="L185" rel="#L185">185</span>
<span id="L186" rel="#L186">186</span>
<span id="L187" rel="#L187">187</span>
<span id="L188" rel="#L188">188</span>
<span id="L189" rel="#L189">189</span>
<span id="L190" rel="#L190">190</span>
<span id="L191" rel="#L191">191</span>
<span id="L192" rel="#L192">192</span>
<span id="L193" rel="#L193">193</span>
<span id="L194" rel="#L194">194</span>
<span id="L195" rel="#L195">195</span>
<span id="L196" rel="#L196">196</span>
<span id="L197" rel="#L197">197</span>
<span id="L198" rel="#L198">198</span>
<span id="L199" rel="#L199">199</span>
<span id="L200" rel="#L200">200</span>
<span id="L201" rel="#L201">201</span>
<span id="L202" rel="#L202">202</span>
<span id="L203" rel="#L203">203</span>
<span id="L204" rel="#L204">204</span>
<span id="L205" rel="#L205">205</span>
<span id="L206" rel="#L206">206</span>
<span id="L207" rel="#L207">207</span>
<span id="L208" rel="#L208">208</span>
<span id="L209" rel="#L209">209</span>
<span id="L210" rel="#L210">210</span>
<span id="L211" rel="#L211">211</span>
<span id="L212" rel="#L212">212</span>
<span id="L213" rel="#L213">213</span>
<span id="L214" rel="#L214">214</span>
<span id="L215" rel="#L215">215</span>
<span id="L216" rel="#L216">216</span>
<span id="L217" rel="#L217">217</span>
<span id="L218" rel="#L218">218</span>
<span id="L219" rel="#L219">219</span>
<span id="L220" rel="#L220">220</span>

          </td>
          <td class="blob-line-code">
                  <div class="highlight"><pre><div class='line' id='LC1'><span class="c1">//-----------------------------------------------------------------------------</span></div><div class='line' id='LC2'><span class="c1">// Copyright (c) 2013 GarageGames, LLC</span></div><div class='line' id='LC3'><span class="c1">//</span></div><div class='line' id='LC4'><span class="c1">// Permission is hereby granted, free of charge, to any person obtaining a copy</span></div><div class='line' id='LC5'><span class="c1">// of this software and associated documentation files (the &quot;Software&quot;), to</span></div><div class='line' id='LC6'><span class="c1">// deal in the Software without restriction, including without limitation the</span></div><div class='line' id='LC7'><span class="c1">// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or</span></div><div class='line' id='LC8'><span class="c1">// sell copies of the Software, and to permit persons to whom the Software is</span></div><div class='line' id='LC9'><span class="c1">// furnished to do so, subject to the following conditions:</span></div><div class='line' id='LC10'><span class="c1">//</span></div><div class='line' id='LC11'><span class="c1">// The above copyright notice and this permission notice shall be included in</span></div><div class='line' id='LC12'><span class="c1">// all copies or substantial portions of the Software.</span></div><div class='line' id='LC13'><span class="c1">//</span></div><div class='line' id='LC14'><span class="c1">// THE SOFTWARE IS PROVIDED &quot;AS IS&quot;, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR</span></div><div class='line' id='LC15'><span class="c1">// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,</span></div><div class='line' id='LC16'><span class="c1">// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE</span></div><div class='line' id='LC17'><span class="c1">// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER</span></div><div class='line' id='LC18'><span class="c1">// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING</span></div><div class='line' id='LC19'><span class="c1">// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS</span></div><div class='line' id='LC20'><span class="c1">// IN THE SOFTWARE.</span></div><div class='line' id='LC21'><span class="c1">//-----------------------------------------------------------------------------</span></div><div class='line' id='LC22'><br/></div><div class='line' id='LC23'><span class="n">function</span> <span class="nf">onConnect</span><span class="p">()</span></div><div class='line' id='LC24'><span class="p">{</span></div><div class='line' id='LC25'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="n">waitingForServer</span><span class="p">.</span><span class="n">isAwake</span><span class="p">())</span></div><div class='line' id='LC26'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">canvas</span><span class="p">.</span><span class="n">popDialog</span><span class="p">(</span><span class="n">waitingForServer</span><span class="p">);</span></div><div class='line' id='LC27'><br/></div><div class='line' id='LC28'>&nbsp;&nbsp;&nbsp;<span class="n">MessageBoxOK</span><span class="p">(</span><span class="s">&quot;Connection Established...&quot;</span><span class="p">,</span> <span class="s">&quot;Connection Established with the server!&quot;</span><span class="p">,</span> <span class="s">&quot;&quot;</span><span class="p">);</span></div><div class='line' id='LC29'><span class="p">}</span></div><div class='line' id='LC30'><br/></div><div class='line' id='LC31'><span class="c1">//--------------------------------------------------</span></div><div class='line' id='LC32'><span class="c1">// callbacks for getting a connection/name list of all clients</span></div><div class='line' id='LC33'><span class="c1">//--------------------------------------------------</span></div><div class='line' id='LC34'><span class="n">function</span> <span class="nf">clientCmdPassConnectionList</span><span class="p">(%</span><span class="n">connectionList</span><span class="p">)</span></div><div class='line' id='LC35'><span class="p">{</span></div><div class='line' id='LC36'>&nbsp;&nbsp;<span class="err">$</span><span class="n">clientConnectionsList</span> <span class="p">=</span> <span class="k">new</span> <span class="n">ScriptObject</span><span class="p">(</span><span class="n">clientConnectionsList</span><span class="p">);</span></div><div class='line' id='LC37'><br/></div><div class='line' id='LC38'>	<span class="p">%</span><span class="n">list</span> <span class="p">=</span> <span class="n">explode</span><span class="p">(%</span><span class="n">connectionList</span><span class="p">,</span> <span class="s">&quot;|&quot;</span><span class="p">);</span></div><div class='line' id='LC39'>	<span class="p">%</span><span class="n">count</span> <span class="p">=</span> <span class="err">$</span><span class="n">clientConnectionCount</span><span class="p">;</span></div><div class='line' id='LC40'><br/></div><div class='line' id='LC41'>	<span class="k">for</span><span class="p">(%</span><span class="n">i</span><span class="p">=</span><span class="m">0</span><span class="p">;%</span><span class="n">i</span><span class="p">&lt;%</span><span class="n">count</span><span class="p">;%</span><span class="n">i</span><span class="p">++)</span></div><div class='line' id='LC42'>	<span class="p">{</span></div><div class='line' id='LC43'>		<span class="err">$</span><span class="n">clientConnectionsList</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">]</span> <span class="p">=</span> <span class="p">%</span><span class="n">list</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">];</span></div><div class='line' id='LC44'>	<span class="p">}</span>	</div><div class='line' id='LC45'><span class="p">}</span></div><div class='line' id='LC46'><br/></div><div class='line' id='LC47'><span class="n">function</span> <span class="nf">clientCmdPassNameList</span><span class="p">(%</span><span class="n">nameList</span><span class="p">)</span></div><div class='line' id='LC48'><span class="p">{</span></div><div class='line' id='LC49'>	<span class="err">$</span><span class="n">clientNamesList</span> <span class="p">=</span> <span class="k">new</span> <span class="n">ScriptObject</span><span class="p">(</span><span class="n">clientNamesList</span><span class="p">);</span></div><div class='line' id='LC50'><br/></div><div class='line' id='LC51'>	<span class="p">%</span><span class="n">list</span> <span class="p">=</span> <span class="n">explode</span><span class="p">(%</span><span class="n">nameList</span><span class="p">,</span> <span class="s">&quot;|&quot;</span><span class="p">);</span></div><div class='line' id='LC52'>	<span class="p">%</span><span class="n">count</span> <span class="p">=</span> <span class="err">$</span><span class="n">clientConnectionCount</span><span class="p">;</span></div><div class='line' id='LC53'>	<span class="k">for</span><span class="p">(%</span><span class="n">i</span><span class="p">=</span><span class="m">0</span><span class="p">;%</span><span class="n">i</span><span class="p">&lt;%</span><span class="n">count</span><span class="p">;%</span><span class="n">i</span><span class="p">++)</span></div><div class='line' id='LC54'>	<span class="p">{</span></div><div class='line' id='LC55'>		<span class="err">$</span><span class="n">clientNamesList</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">]</span> <span class="p">=</span> <span class="p">%</span><span class="n">list</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">];</span></div><div class='line' id='LC56'>	<span class="p">}</span>	</div><div class='line' id='LC57'><span class="p">}</span></div><div class='line' id='LC58'><br/></div><div class='line' id='LC59'><span class="n">function</span> <span class="nf">clientCmdPassConnectionCount</span><span class="p">(%</span><span class="n">connectionCount</span><span class="p">)</span></div><div class='line' id='LC60'><span class="p">{</span></div><div class='line' id='LC61'>	<span class="err">$</span><span class="n">clientConnectionCount</span> <span class="p">=</span> <span class="p">%</span><span class="n">connectionCount</span><span class="p">;</span></div><div class='line' id='LC62'><span class="p">}</span></div><div class='line' id='LC63'><br/></div><div class='line' id='LC64'><br/></div><div class='line' id='LC65'><span class="c1">//----------------------------------------------------</span></div><div class='line' id='LC66'><br/></div><div class='line' id='LC67'><span class="n">function</span> <span class="nf">clientCmdPassChatConnectionList</span><span class="p">(%</span><span class="n">connectionList</span><span class="p">)</span></div><div class='line' id='LC68'><span class="p">{</span></div><div class='line' id='LC69'>	<span class="err">$</span><span class="n">clientChatConnectionsList</span> <span class="p">=</span> <span class="k">new</span> <span class="n">ScriptObject</span><span class="p">(</span><span class="n">clientChatConnectionsList</span><span class="p">);</span></div><div class='line' id='LC70'><br/></div><div class='line' id='LC71'>	<span class="p">%</span><span class="n">list</span> <span class="p">=</span> <span class="n">explode</span><span class="p">(%</span><span class="n">connectionList</span><span class="p">,</span> <span class="s">&quot;|&quot;</span><span class="p">);</span></div><div class='line' id='LC72'>	<span class="p">%</span><span class="n">count</span> <span class="p">=</span> <span class="err">$</span><span class="n">clientChatConnectionCount</span><span class="p">;</span></div><div class='line' id='LC73'>	<span class="k">for</span><span class="p">(%</span><span class="n">i</span><span class="p">=</span><span class="m">0</span><span class="p">;%</span><span class="n">i</span><span class="p">&lt;%</span><span class="n">count</span><span class="p">;%</span><span class="n">i</span><span class="p">++)</span></div><div class='line' id='LC74'>	<span class="p">{</span></div><div class='line' id='LC75'>		<span class="err">$</span><span class="n">clientChatConnectionsList</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">]</span> <span class="p">=</span> <span class="p">%</span><span class="n">list</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">];</span></div><div class='line' id='LC76'>	<span class="p">}</span>	</div><div class='line' id='LC77'><span class="p">}</span></div><div class='line' id='LC78'><br/></div><div class='line' id='LC79'><span class="n">function</span> <span class="nf">clientCmdPassChatNameList</span><span class="p">(%</span><span class="n">nameList</span><span class="p">)</span></div><div class='line' id='LC80'><span class="p">{</span></div><div class='line' id='LC81'>	<span class="err">$</span><span class="n">clientChatNamesList</span> <span class="p">=</span> <span class="k">new</span> <span class="n">ScriptObject</span><span class="p">(</span><span class="n">clientChatNamesList</span><span class="p">);</span></div><div class='line' id='LC82'><br/></div><div class='line' id='LC83'>	<span class="p">%</span><span class="n">list</span> <span class="p">=</span> <span class="n">explode</span><span class="p">(%</span><span class="n">nameList</span><span class="p">,</span> <span class="s">&quot;|&quot;</span><span class="p">);</span></div><div class='line' id='LC84'>	<span class="p">%</span><span class="n">count</span> <span class="p">=</span> <span class="err">$</span><span class="n">clientChatConnectionCount</span><span class="p">;</span></div><div class='line' id='LC85'>	<span class="k">for</span><span class="p">(%</span><span class="n">i</span><span class="p">=</span><span class="m">0</span><span class="p">;%</span><span class="n">i</span><span class="p">&lt;%</span><span class="n">count</span><span class="p">;%</span><span class="n">i</span><span class="p">++)</span></div><div class='line' id='LC86'>	<span class="p">{</span></div><div class='line' id='LC87'>		<span class="err">$</span><span class="n">clientChatNamesList</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">]</span> <span class="p">=</span> <span class="p">%</span><span class="n">list</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">i</span><span class="p">];</span></div><div class='line' id='LC88'>	<span class="p">}</span>	</div><div class='line' id='LC89'><br/></div><div class='line' id='LC90'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="err">$</span><span class="n">waitingForList</span><span class="p">)</span></div><div class='line' id='LC91'>&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC92'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">chatGui</span><span class="p">::</span><span class="n">onGetList</span><span class="p">();</span></div><div class='line' id='LC93'>&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC94'><span class="p">}</span></div><div class='line' id='LC95'><br/></div><div class='line' id='LC96'><span class="n">function</span> <span class="nf">clientCmdPassChatConnectionCount</span><span class="p">(%</span><span class="n">connectionCount</span><span class="p">)</span></div><div class='line' id='LC97'><span class="p">{</span></div><div class='line' id='LC98'>	<span class="err">$</span><span class="n">clientChatConnectionCount</span> <span class="p">=</span> <span class="p">%</span><span class="n">connectionCount</span><span class="p">;</span></div><div class='line' id='LC99'><span class="p">}</span></div><div class='line' id='LC100'><span class="c1">//----------------------------------------------------</span></div><div class='line' id='LC101'><br/></div><div class='line' id='LC102'><br/></div><div class='line' id='LC103'><br/></div><div class='line' id='LC104'><br/></div><div class='line' id='LC105'><span class="n">function</span> <span class="nf">clientCmdupdateChatText</span><span class="p">(%</span><span class="n">clientName</span><span class="p">,</span> <span class="p">%</span><span class="n">text</span><span class="p">)</span></div><div class='line' id='LC106'><span class="p">{</span></div><div class='line' id='LC107'>&nbsp;&nbsp;&nbsp;<span class="p">%</span><span class="kt">string</span> <span class="p">=</span> <span class="p">%</span><span class="n">clientName</span> <span class="err">@</span> <span class="s">&quot;: &quot;</span> <span class="err">@</span> <span class="p">%</span><span class="n">text</span><span class="p">;</span></div><div class='line' id='LC108'>&nbsp;&nbsp;&nbsp;<span class="n">chatVectorText</span><span class="p">.</span><span class="n">pushBackLine</span><span class="p">(%</span><span class="kt">string</span><span class="p">,</span> <span class="m">0</span><span class="p">);</span></div><div class='line' id='LC109'><span class="p">}</span></div><div class='line' id='LC110'><br/></div><div class='line' id='LC111'><br/></div><div class='line' id='LC112'><span class="n">function</span> <span class="nf">clientCmdupdateChatClient</span><span class="p">(%</span><span class="n">clientName</span><span class="p">)</span></div><div class='line' id='LC113'><span class="p">{</span></div><div class='line' id='LC114'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(!</span><span class="n">isObject</span><span class="p">(</span><span class="n">clientChatInfo</span><span class="p">))</span></div><div class='line' id='LC115'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">new</span> <span class="nf">SimSet</span><span class="p">(</span><span class="n">clientChatInfo</span><span class="p">);</span></div><div class='line' id='LC116'><br/></div><div class='line' id='LC117'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="n">clientChatInfo</span><span class="p">.</span><span class="n">clientCount</span> <span class="err">$</span><span class="p">=</span> <span class="s">&quot;&quot;</span><span class="p">)</span></div><div class='line' id='LC118'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">clientChatInfo</span><span class="p">.</span><span class="n">clientCount</span> <span class="p">=</span> <span class="m">0</span><span class="p">;</span></div><div class='line' id='LC119'><br/></div><div class='line' id='LC120'>&nbsp;&nbsp;<span class="c1">// clientChatInfo.add(%clientName);</span></div><div class='line' id='LC121'>&nbsp;&nbsp;&nbsp;<span class="n">chatClientList</span><span class="p">.</span><span class="n">addRow</span><span class="p">(</span><span class="n">clientChatInfo</span><span class="p">.</span><span class="n">clientCount</span><span class="p">,</span> <span class="p">%</span><span class="n">clientName</span><span class="p">);</span></div><div class='line' id='LC122'>&nbsp;&nbsp;&nbsp;<span class="err">$</span><span class="n">chat</span><span class="p">::</span><span class="n">clientCount</span><span class="p">++;</span></div><div class='line' id='LC123'><span class="p">}</span></div><div class='line' id='LC124'><br/></div><div class='line' id='LC125'><span class="n">function</span> <span class="nf">clientCmdremoveChatClient</span><span class="p">(%</span><span class="n">clientName</span><span class="p">)</span></div><div class='line' id='LC126'><span class="p">{</span></div><div class='line' id='LC127'>&nbsp;&nbsp;&nbsp;<span class="n">clientChatInfo</span><span class="p">.</span><span class="k">remove</span><span class="p">(%</span><span class="n">clientName</span><span class="p">);</span></div><div class='line' id='LC128'>&nbsp;&nbsp;&nbsp;<span class="n">chatClientList</span><span class="p">.</span><span class="n">removeRow</span><span class="p">(</span><span class="n">chatClientList</span><span class="p">.</span><span class="n">findTextIndex</span><span class="p">(%</span><span class="n">clientName</span><span class="p">));</span></div><div class='line' id='LC129'>&nbsp;&nbsp;&nbsp;<span class="err">$</span><span class="n">chat</span><span class="p">::</span><span class="n">clientCount</span><span class="p">--;</span></div><div class='line' id='LC130'><span class="p">}</span></div><div class='line' id='LC131'><br/></div><div class='line' id='LC132'><span class="n">function</span> <span class="nf">loadChat</span><span class="p">()</span></div><div class='line' id='LC133'><span class="p">{</span></div><div class='line' id='LC134'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="err">$</span><span class="n">serverConnected</span><span class="p">)</span></div><div class='line' id='LC135'>&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC136'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="err">$</span><span class="n">serverLocal</span><span class="p">)</span></div><div class='line' id='LC137'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC138'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//First lets start the chat system</span></div><div class='line' id='LC139'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">initChat</span><span class="p">();</span></div><div class='line' id='LC140'><br/></div><div class='line' id='LC141'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//This is called if the server is initiating a chat, lets load it</span></div><div class='line' id='LC142'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">Canvas</span><span class="p">.</span><span class="n">pushDialog</span><span class="p">(</span><span class="n">chatGui</span><span class="p">);</span></div><div class='line' id='LC143'><br/></div><div class='line' id='LC144'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//Now we send messaged out to the clients saying that the server has established a chat</span></div><div class='line' id='LC145'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">sendChatLoaded</span><span class="p">();</span></div><div class='line' id='LC146'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span> <span class="k">else</span></div><div class='line' id='LC147'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC148'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">commandToServer</span><span class="p">(</span><span class="err">&#39;</span><span class="n">isChatLoaded</span><span class="err">&#39;</span><span class="p">);</span></div><div class='line' id='LC149'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">canvas</span><span class="p">.</span><span class="n">pushDialog</span><span class="p">(</span><span class="n">waitingForServer</span><span class="p">);</span></div><div class='line' id='LC150'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC151'>&nbsp;&nbsp;&nbsp;<span class="p">}</span> <span class="k">else</span></div><div class='line' id='LC152'>&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC153'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">MessageBoxOK</span><span class="p">(</span><span class="s">&quot;Loading Chat...&quot;</span><span class="p">,</span> <span class="s">&quot;Loading chat failed: No Server Connection Exists.&quot;</span><span class="p">,</span> <span class="s">&quot;&quot;</span><span class="p">);</span></div><div class='line' id='LC154'>&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC155'><span class="p">}</span></div><div class='line' id='LC156'><br/></div><div class='line' id='LC157'><br/></div><div class='line' id='LC158'><br/></div><div class='line' id='LC159'><span class="n">function</span> <span class="nf">clientCmdisChatLoaded</span><span class="p">(%</span><span class="n">isChatLoaded</span><span class="p">)</span></div><div class='line' id='LC160'><span class="p">{</span></div><div class='line' id='LC161'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="n">waitingForServer</span><span class="p">.</span><span class="n">isAwake</span><span class="p">())</span></div><div class='line' id='LC162'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">canvas</span><span class="p">.</span><span class="n">popDialog</span><span class="p">(</span><span class="n">waitingForServer</span><span class="p">);</span></div><div class='line' id='LC163'>&nbsp;&nbsp;&nbsp;<span class="c1">//This is called if you are not the server and are trying to connect to the chat</span></div><div class='line' id='LC164'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(%</span><span class="n">isChatLoaded</span><span class="p">)</span></div><div class='line' id='LC165'>&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC166'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//If the chat is loaded then you open the gui</span></div><div class='line' id='LC167'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">mainScreenGui</span><span class="p">.</span><span class="k">add</span><span class="p">(</span><span class="n">chatGui</span><span class="p">);</span></div><div class='line' id='LC168'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div><div class='line' id='LC169'>&nbsp;&nbsp;&nbsp;<span class="p">}</span> <span class="k">else</span></div><div class='line' id='LC170'>&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC171'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//If the chat isn&#39;t loaded we send an error box</span></div><div class='line' id='LC172'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">MessageBoxOK</span><span class="p">(</span><span class="s">&quot;Loading Chat...&quot;</span><span class="p">,</span> <span class="s">&quot;Loading chat failed: No Chat Loaded on Server.&quot;</span><span class="p">,</span> <span class="s">&quot;&quot;</span><span class="p">);</span></div><div class='line' id='LC173'>&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC174'><span class="p">}</span></div><div class='line' id='LC175'><br/></div><div class='line' id='LC176'><span class="n">function</span> <span class="nf">clientCmdChatClosed</span><span class="p">()</span></div><div class='line' id='LC177'><span class="p">{</span></div><div class='line' id='LC178'>&nbsp;&nbsp;&nbsp;<span class="n">serverData</span><span class="p">.</span><span class="n">chatLoaded</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></div><div class='line' id='LC179'><br/></div><div class='line' id='LC180'>&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(!</span><span class="err">$</span><span class="n">serverLocal</span><span class="p">)</span></div><div class='line' id='LC181'>&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC182'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="n">chatGui</span><span class="p">.</span><span class="n">isAwake</span><span class="p">())</span></div><div class='line' id='LC183'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">{</span></div><div class='line' id='LC184'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="n">mainScreenGui</span><span class="p">.</span><span class="k">remove</span><span class="p">(</span><span class="n">chatGui</span><span class="p">);</span></div><div class='line' id='LC185'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC186'>&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC187'><span class="p">}</span></div><div class='line' id='LC188'><br/></div><div class='line' id='LC189'><br/></div><div class='line' id='LC190'><br/></div><div class='line' id='LC191'><br/></div><div class='line' id='LC192'><span class="n">function</span> <span class="nf">explode</span><span class="p">(%</span><span class="kt">string</span><span class="p">,</span> <span class="p">%</span><span class="kt">char</span><span class="p">)</span></div><div class='line' id='LC193'><span class="p">{</span></div><div class='line' id='LC194'>	<span class="k">if</span><span class="p">(!</span><span class="n">isObject</span><span class="p">(</span><span class="n">explode</span><span class="p">))</span></div><div class='line' id='LC195'>		<span class="k">new</span> <span class="nf">ScriptObject</span><span class="p">(</span><span class="n">explode</span><span class="p">);</span></div><div class='line' id='LC196'><br/></div><div class='line' id='LC197'>	<span class="p">%</span><span class="n">explodeCount</span> <span class="p">=</span> <span class="m">0</span><span class="p">;</span></div><div class='line' id='LC198'>	<span class="p">%</span><span class="n">lastFound</span> <span class="p">=</span> <span class="m">0</span><span class="p">;</span></div><div class='line' id='LC199'><br/></div><div class='line' id='LC200'>	<span class="p">%</span><span class="n">endChar</span> <span class="p">=</span> <span class="n">strLen</span><span class="p">(%</span><span class="kt">string</span><span class="p">);</span>	</div><div class='line' id='LC201'>	<span class="p">%</span><span class="n">charLen</span> <span class="p">=</span> <span class="n">strLen</span><span class="p">(%</span><span class="kt">char</span><span class="p">);</span></div><div class='line' id='LC202'><br/></div><div class='line' id='LC203'>	<span class="k">for</span><span class="p">(%</span><span class="n">i</span><span class="p">=</span><span class="m">0</span><span class="p">;%</span><span class="n">i</span><span class="p">&lt;%</span><span class="n">endChar</span><span class="p">;%</span><span class="n">i</span><span class="p">++)</span></div><div class='line' id='LC204'>	<span class="p">{</span></div><div class='line' id='LC205'>		<span class="p">%</span><span class="n">charToCheck</span> <span class="p">=</span> <span class="n">getSubStr</span><span class="p">(%</span><span class="kt">string</span><span class="p">,</span> <span class="p">%</span><span class="n">i</span><span class="p">,</span> <span class="p">%</span><span class="n">charLen</span><span class="p">);</span></div><div class='line' id='LC206'>		<span class="k">if</span><span class="p">(%</span><span class="n">charToCheck</span> <span class="err">$</span><span class="p">=</span> <span class="p">%</span><span class="kt">char</span><span class="p">)</span></div><div class='line' id='LC207'>		<span class="p">{</span></div><div class='line' id='LC208'>			<span class="n">explode</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">explodeCount</span><span class="p">]</span> <span class="p">=</span> <span class="n">getSubStr</span><span class="p">(%</span><span class="kt">string</span><span class="p">,</span> <span class="p">%</span><span class="n">lastFound</span><span class="p">,</span> <span class="p">(%</span><span class="n">i</span><span class="p">-%</span><span class="n">lastFound</span><span class="p">));</span> </div><div class='line' id='LC209'>			<span class="p">%</span><span class="n">lastFound</span> <span class="p">=</span> <span class="p">%</span><span class="n">i</span> <span class="p">+</span> <span class="p">%</span><span class="n">charLen</span><span class="p">;</span></div><div class='line' id='LC210'>			<span class="p">%</span><span class="n">explodeCount</span><span class="p">++;</span></div><div class='line' id='LC211'>		<span class="p">}</span>	</div><div class='line' id='LC212'>	<span class="p">}</span></div><div class='line' id='LC213'><br/></div><div class='line' id='LC214'><br/></div><div class='line' id='LC215'>	<span class="n">explode</span><span class="p">.</span><span class="n">contents</span><span class="p">[%</span><span class="n">explodeCount</span><span class="p">]</span> <span class="p">=</span> <span class="n">getSubStr</span><span class="p">(%</span><span class="kt">string</span><span class="p">,</span> <span class="p">%</span><span class="n">lastFound</span><span class="p">,</span> <span class="p">(%</span><span class="n">i</span><span class="p">-%</span><span class="n">lastFound</span><span class="p">));</span> </div><div class='line' id='LC216'>	<span class="n">explode</span><span class="p">.</span><span class="n">count</span> <span class="p">=</span> <span class="p">%</span><span class="n">explodeCount</span> <span class="p">+</span> <span class="m">1</span><span class="p">;</span>	</div><div class='line' id='LC217'><br/></div><div class='line' id='LC218'>	<span class="k">return</span> <span class="n">explode</span><span class="p">;</span></div><div class='line' id='LC219'><span class="p">}</span></div><div class='line' id='LC220'><br/></div></pre></div>
          </td>
        </tr>
      </table>
  </div>

          </div>
        </div>

        <a href="#jump-to-line" rel="facebox" data-hotkey="l" class="js-jump-to-line" style="display:none">Jump to Line</a>
        <div id="jump-to-line" style="display:none">
          <h2>Jump to Line</h2>
          <form accept-charset="UTF-8" class="js-jump-to-line-form">
            <input class="textfield js-jump-to-line-field" type="text">
            <div class="full-button">
              <button type="submit" class="button">Go</button>
            </div>
          </form>
        </div>

      </div>
    </div>
</div>

<div id="js-frame-loading-template" class="frame frame-loading large-loading-area" style="display:none;">
  <img class="js-frame-loading-spinner" src="https://a248.e.akamai.net/assets.github.com/images/spinners/octocat-spinner-128.gif?1347543528" height="64" width="64">
</div>


        </div>
      </div>
      <div class="modal-backdrop"></div>
    </div>

      <div id="footer-push"></div><!-- hack for sticky footer -->
    </div><!-- end of wrapper - hack for sticky footer -->

      <!-- footer -->
      <div id="footer">
  <div class="container clearfix">

      <dl class="footer_nav">
        <dt>GitHub</dt>
        <dd><a href="/about">About us</a></dd>
        <dd><a href="/blog">Blog</a></dd>
        <dd><a href="/contact">Contact &amp; support</a></dd>
        <dd><a href="http://enterprise.github.com/">GitHub Enterprise</a></dd>
        <dd><a href="http://status.github.com/">Site status</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Applications</dt>
        <dd><a href="http://mac.github.com/">GitHub for Mac</a></dd>
        <dd><a href="http://windows.github.com/">GitHub for Windows</a></dd>
        <dd><a href="http://eclipse.github.com/">GitHub for Eclipse</a></dd>
        <dd><a href="http://mobile.github.com/">GitHub mobile apps</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Services</dt>
        <dd><a href="http://get.gaug.es/">Gauges: Web analytics</a></dd>
        <dd><a href="http://speakerdeck.com">Speaker Deck: Presentations</a></dd>
        <dd><a href="https://gist.github.com">Gist: Code snippets</a></dd>
        <dd><a href="http://jobs.github.com/">Job board</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Documentation</dt>
        <dd><a href="http://help.github.com/">GitHub Help</a></dd>
        <dd><a href="http://developer.github.com/">Developer API</a></dd>
        <dd><a href="http://github.github.com/github-flavored-markdown/">GitHub Flavored Markdown</a></dd>
        <dd><a href="http://pages.github.com/">GitHub Pages</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>More</dt>
        <dd><a href="http://training.github.com/">Training</a></dd>
        <dd><a href="/edu">Students &amp; teachers</a></dd>
        <dd><a href="http://shop.github.com">The Shop</a></dd>
        <dd><a href="/plans">Plans &amp; pricing</a></dd>
        <dd><a href="http://octodex.github.com/">The Octodex</a></dd>
      </dl>

      <hr class="footer-divider">


    <p class="right">&copy; 2013 <span title="0.27919s from fe1.rs.github.com">GitHub</span>, Inc. All rights reserved.</p>
    <a class="left" href="/">
      <span class="mega-octicon octicon-mark-github"></span>
    </a>
    <ul id="legal">
        <li><a href="/site/terms">Terms of Service</a></li>
        <li><a href="/site/privacy">Privacy</a></li>
        <li><a href="/security">Security</a></li>
    </ul>

  </div><!-- /.container -->

</div><!-- /.#footer -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-fullscreen-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="js-fullscreen-contents" placeholder="" data-suggester="fullscreen_suggester"></textarea>
          <div class="suggester-container">
              <div class="suggester fullscreen-suggester js-navigation-container" id="fullscreen_suggester"
                 data-url="/Doc308/Torque2D/suggestions/commit">
              </div>
          </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped leftwards" title="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped leftwards"
      title="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      Something went wrong with that request. Please try again.
      <a href="#" class="octicon octicon-remove-close ajax-error-dismiss"></a>
    </div>

    
    <span id='server_response_time' data-time='0.27965' data-host='fe1'></span>
    
  </body>
</html>

