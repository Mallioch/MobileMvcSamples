Ext.define('MyApp.view.Main', {
    extend: 'Ext.tab.Panel',
    xtype: 'main',
    requires: [
        'Ext.TitleBar',
        'Ext.Video'
    ],
    config: {
        tabBarPosition: 'bottom',

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
            {
                title: 'Item List',
                iconCls: 'action',

                items: [
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
                          url: 'https://ajax.googleapis.com/ajax/services/feed/load?v=1.0&q=http://ericsowell.com/content/rss.xml',
                          reader: {
                            type: 'json',
                            rootProperty: 'responseData.feed.entries'
                          }
                        }
                      }
                    }
                ]
            }
        ]
    }
});
