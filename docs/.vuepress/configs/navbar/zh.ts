import type { NavbarConfig } from '@vuepress/theme-default'

export const zh: NavbarConfig = [
  {
    text: '指南',
    link: '/guide/',
  },
  {
    text: '参考',
    children: [
      {
        text: 'VuePress',
        children: [
          {
            text: 'CLI',
            link: '/reference/cli.html',
          },
          '/reference/config.md',
          '/reference/frontmatter.md',
          '/reference/components.md',
          '/reference/plugin-api.md',
          '/reference/theme-api.md',
        ],
      },
      {
        text: '打包工具',
        children: [
          '/reference/bundler/webpack.md',
          '/reference/bundler/vite.md',
        ],
      },
      {
        text: '默认主题',
        children: [
          '/reference/default-theme/config.md',
          '/reference/default-theme/frontmatter.md',
          '/reference/default-theme/components.md',
        ],
      },
    ],
  },
  {
    text: '了解更多',
    children: [
      {
        text: '深入',
        children: [
          '/guide/advanced/markdown.md',
          '/guide/advanced/theme.md',
          '/guide/advanced/plugin.md',
        ],
      },
      {
        text: '其他资源',
        children: [
          '/contributing.md',
          {
            text: '更新日志',
            link:
              'https://github.com/vuepress/vuepress-next/blob/main/CHANGELOG.md',
          },
          {
            text: 'Awesome VuePress',
            link: 'https://github.com/vuepress/awesome-vuepress',
          },
          {
            text: 'v1 文档',
            link: 'https://v1.vuepress.vuejs.org/zh/',
          },
          {
            text: 'v0 文档',
            link: 'https://v0.vuepress.vuejs.org/zh/',
          },
        ],
      },
    ],
  },
]
