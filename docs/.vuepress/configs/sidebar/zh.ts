import type { SidebarConfig } from '@vuepress/theme-default'

export const zh: SidebarConfig = {
  '/guide/': [
    {
      isGroup: true,
      text: '指南',
      children: [
        '/guide/README.md',
        '/guide/getting-started.md',
        '/guide/configuration.md',
        '/guide/page.md',
        '/guide/markdown.md',
        '/guide/assets.md',
        '/guide/i18n.md',
        '/guide/deployment.md',
        '/guide/theme.md',
        '/guide/plugin.md',
        '/guide/bundler.md',
      ],
    },
  ],
  '/guide/advanced/': [
    {
      isGroup: true,
      text: '深入',
      children: [
        '/guide/advanced/markdown.md',
        '/guide/advanced/theme.md',
        '/guide/advanced/plugin.md',
      ],
    },
  ],
  '/reference/': [
    {
      isGroup: true,
      text: 'VuePress 参考',
      children: [
        '/reference/cli.md',
        '/reference/config.md',
        '/reference/frontmatter.md',
        '/reference/components.md',
        '/reference/plugin-api.md',
        '/reference/theme-api.md',
      ],
    },
  ],
  '/reference/bundler/': [
    {
      isGroup: true,
      text: '打包工具参考',
      children: [
        '/reference/bundler/webpack.md',
        '/reference/bundler/vite.md',
      ],
    },
  ],
  '/reference/default-theme/': [
    {
      isGroup: true,
      text: '默认主题参考',
      children: [
        '/reference/default-theme/config.md',
        '/reference/default-theme/frontmatter.md',
        '/reference/default-theme/components.md',
      ],
    },
  ],
}
