import type { NavbarConfig } from '@vuepress/theme-default'

export const en: NavbarConfig = [
  {
    text: 'Guide',
    link: '/en/guide/',
  },
  {
    text: 'Reference',
    children: [
      {
        text: 'VuePress',
        children: [
          '/en/reference/cli.md',
          '/en/reference/config.md',
          '/en/reference/frontmatter.md',
          '/en/reference/components.md',
          '/en/reference/plugin-api.md',
          '/en/reference/theme-api.md',
        ],
      },
      {
        text: 'Bundler',
        children: [
          '/en/reference/bundler/webpack.md',
          '/en/reference/bundler/vite.md',
        ],
      },
      {
        text: 'Default Theme',
        children: [
          '/en/reference/default-theme/config.md',
          '/en/reference/default-theme/frontmatter.md',
          '/en/reference/default-theme/components.md',
        ],
      },
    ],
  },
  {
    text: 'Learn More',
    children: [
      {
        text: 'Advanced',
        children: [
          '/en/guide/advanced/markdown.md',
          '/en/guide/advanced/theme.md',
          '/en/guide/advanced/plugin.md',
        ],
      },
      {
        text: 'Resources',
        children: [
          '/en/contributing.md',
          {
            text: 'Changelog',
            link:
              'https://github.com/vuepress/vuepress-next/blob/main/CHANGELOG.md',
          },
          {
            text: 'Awesome VuePress',
            link: 'https://github.com/vuepress/awesome-vuepress',
          },
          {
            text: 'v1 docs',
            link: 'https://v1.vuepress.vuejs.org',
          },
          {
            text: 'v0 docs',
            link: 'https://v0.vuepress.vuejs.org',
          },
        ],
      },
    ],
  },
]
