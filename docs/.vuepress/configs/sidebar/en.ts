import type { SidebarConfig } from '@vuepress/theme-default'

export const en: SidebarConfig = {
  '/en/guide/': [
    {
      isGroup: true,
      text: 'Guide',
      children: [
        '/en/guide/README.md',
        '/en/guide/getting-started.md',
        '/en/guide/configuration.md',
        '/en/guide/page.md',
        '/en/guide/markdown.md',
        '/en/guide/assets.md',
        '/en/guide/i18n.md',
        '/en/guide/deployment.md',
        '/en/guide/theme.md',
        '/en/guide/plugin.md',
        '/en/guide/bundler.md',
      ],
    },
  ],
  '/en/guide/advanced/': [
    {
      isGroup: true,
      text: 'Advanced',
      children: [
        '/en/guide/advanced/markdown.md',
        '/en/guide/advanced/theme.md',
        '/en/guide/advanced/plugin.md',
      ],
    },
  ],
  '/en/reference/': [
    {
      isGroup: true,
      text: 'VuePress Reference',
      children: [
        '/en/reference/cli.md',
        '/en/reference/config.md',
        '/en/reference/frontmatter.md',
        '/en/reference/components.md',
        '/en/reference/plugin-api.md',
        '/en/reference/theme-api.md',
      ],
    },
  ],
  '/en/reference/bundler/': [
    {
      isGroup: true,
      text: 'Bundler Reference',
      children: ['/en/reference/bundler/webpack.md', '/en/reference/bundler/vite.md'],
    },
  ],
  '/en/reference/default-theme/': [
    {
      isGroup: true,
      text: 'Default Theme Reference',
      children: [
        '/en/reference/default-theme/config.md',
        '/en/reference/default-theme/frontmatter.md',
        '/en/reference/default-theme/components.md',
      ],
    },
  ],
}
