/*
    This file is generated and updated by Sencha Cmd. You can edit this file as
    needed for your application, but these edits will have to be merged by
    Sencha Cmd when it performs code generation tasks such as generating new
    models, controllers or views and when running "sencha app upgrade".

    Ideally changes to this file would be limited and most work would be done
    in other places (such as Controllers). If Sencha Cmd cannot merge your
    changes and its generated code, it will produce a "merge conflict" that you
    will need to resolve manually.
*/

// DO NOT DELETE - this directive is required for Sencha Cmd packages to work.
//@require @packageOverrides

//<debug>
Ext.Loader.setPath({
    'Ext': 'touch/src'
});
//</debug>

Ext.application({
    name: 'MyApp',

    isIconPrecomposed: true,

    startupImage: {
        '320x460': 'resources/startup/320x460.jpg',
        '640x920': 'resources/startup/640x920.png',
        '768x1004': 'resources/startup/768x1004.png',
        '748x1024': 'resources/startup/748x1024.png',
        '1536x2008': 'resources/startup/1536x2008.png',
        '1496x2048': 'resources/startup/1496x2048.png'
    },

    launch: function() {
      // Destroy the #appLoadingIndicator element
      Ext.fly('appLoadingIndicator').destroy();

      //This creates the tab panel. The number of items is determined below.
      Ext.create('Ext.tab.Panel', {
        fullscreen: true,
        tabBarPosition: 'bottom',

        //There are three things in this array, so there are three elements in the tab bar.
        items: [
          {
            title: 'Welcome',
            iconCls: 'home',

            styleHtmlContent: true,
            scrollable: true,

            items: {
              docked: 'top',
              xtype: 'titlebar',
              title: 'Sencha Touch Demo'
            },

            html: [
                "This is a simple Sencha Touch demo. It was created with Sencha Touch 2."
            ].join("")
          },

          //The blog page
          {
            xtype: 'nestedlist',
            title: 'Blog',
            iconCls: 'star',
            displayField: 'title',

            store: {
              type: 'tree',

              fields: [
                  'title', 'link', 'author', 'contentSnippet', 'content',
                  { name: 'leaf', defaultValue: true }
              ],

              root: {
                leaf: false
              },

              proxy: {
                type: 'jsonp',
                url: 'https://ajax.googleapis.com/ajax/services/feed/load?v=1.0&q=http://feeds.feedburner.com/ericsowell',
                reader: {
                  type: 'json',
                  rootProperty: 'responseData.feed.entries'
                }
              }
            }
          },

          //The gallery page. The actual carousel is a child, setup below.
          {
            title: 'Gallery',
            iconCls: 'home',

            styleHtmlContent: false,
            scrollable: false,

            layout: {
              type: 'hbox',
              pack: 'center'
            },

            defaults: {
              height: 200,
              width: 200
            },

            items: [                  
              Ext.create('Ext.Carousel', {
                fullscreen: false,

                defaults: {
                  styleHtmlContent: false,
                  height: 200,
                  width: 200
                },

                items: [
                    {
                      html: '<img src="/content/bacon_200.jpg" />',
                    },
                    {
                      html: '<img src="/content/css_200.jpg" />',
                    },
                    {
                      html: '<img src="/content/dice_200.jpg" />',
                    }
                      
                  ]
                })
              ]
            }
          ]
        });//End of Ext.tab.Panel
    }
});
