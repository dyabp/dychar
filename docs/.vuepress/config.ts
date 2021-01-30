import * as chokidar from 'chokidar'
import type { UserConfig } from '@vuepress/cli'
import type { DefaultThemeOptions } from '@vuepress/theme-default'
import { chalk, logger } from '@vuepress/utils'
import { navbar, sidebar } from './configs'

const config: UserConfig<DefaultThemeOptions> = {
  base: '/',

  head: [['link', { rel: 'icon', href: `/logo.png` }]],

  // site-level locales config
  locales: {
    '/': {
      lang: 'zh-CN',
      title: 'DyAbp',
      description: '助力您的Abp开发',
    },
    '/en/': {
      lang: 'en-US',
      title: 'DyAbp',
      description: 'Empowering Your Abp Development',
    },
  },

  themeConfig: {
    logo: '/logo.png',

    repo: 'dyabp/dyabp',

    //docsBranch: 'main',
    docsDir: 'docs',

    // theme-level locales config
    locales: {
      /**
       * English locale config
       *
       * As the default locale of @vuepress/theme-default is English,
       * we don't need to set all of the locale fields
       */
      '/en/': {
        // navbar
        navbar: navbar.en,

        // sidebar
        sidebar: sidebar.en,

        // page meta
        editLinkText: 'Edit this page on GitHub',
      },

      /**
       * Chinese locale config
       */
      '/': {
        // navbar
        navbar: navbar.zh,
        selectLanguageName: '简体中文',
        selectLanguageText: '选择语言',
        selectLanguageAriaLabel: '选择语言',

        // sidebar
        sidebar: sidebar.zh,

        // page meta
        editLinkText: '在 GitHub 上编辑此页',
        lastUpdatedText: '上次更新',
        contributorsText: '贡献者',

        // custom blocks
        tip: '提示',
        warning: '注意',
        danger: '警告',

        // 404 page
        notFound: [
          '这里什么都没有',
          '我们怎么到这来了？',
          '这是一个 404 页面',
          '看起来我们进入了错误的链接',
        ],
        backToHome: '返回首页',

        // other
        openInNewWindow: '在新窗口打开',
      },
    },

    themePlugins: {
      // only enable git plugin in production mode
      git: process.env.NODE_ENV === 'production',
    },
  },

  plugins: [
    // [
    //   '@vuepress/plugin-docsearch',
    //   {
    //     apiKey: '311baf7f522b70d9d8490d1dd6285b1d',
    //     indexName: 'dyabp',
    //     searchParameters: {
    //       facetFilters: ['tags:v2'],
    //     },
    //     locales: {
    //       '/en/': {
    //         placeholder: '搜索文档',
    //       },
    //       '/': {
    //         placeholder: 'Search docs',
    //       },
    //     },
    //   },
    // ],
    // ['@vuepress/plugin-pwa'],
    // [
    //   '@vuepress/plugin-pwa-popup',
    //   {
    //     locales: {
    //       '/': {
    //         message: '发现新内容可用',
    //         buttonText: '刷新',
    //       },
    //       '/en/': {
    //         message: 'New content is available.',
    //         buttonText: 'Refresh',
    //       },
    //     },
    //   },
    // ],
  ],

  evergreen: process.env.NODE_ENV !== 'production',

  onWatched: (_, restart) => {
    const watcher = chokidar.watch('configs/**/*.ts', {
      cwd: __dirname,
      ignoreInitial: true,
    })
    watcher.on('change', async (file) => {
      logger.info(`file ${chalk.magenta(file)} is modified`)
      await watcher.close()
      await restart()
    })
  },
}

export = config
