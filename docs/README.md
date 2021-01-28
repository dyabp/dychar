---
home: true
title: 首页
heroImage: /hero.png
actions:
  - text: 快速上手
    link: /guide/getting-started.html
    type: primary
  - text: 项目简介
    link: /guide/
    type: secondary
features:
  - title: 开箱即用
    details: 只需安装对应包，即可接入相应模块功能，为您节省大量开发时间。
  - title: 可扩展
    details: 模块都遵循ABP最佳实践，支持对象扩展系统，以满足功能和垂直域的分层需求。
  - title: 面向未来
    details: 在满足需求的同时，我们也不会停止对新技术的探索。
footer: MIT Licensed | Copyright © 2019-present DyAbp
---

### 像数 1, 2, 3 一样容易

<CodeGroup>
  <CodeGroupItem title="YARN" active>

```bash
# 在你的项目中安装
yarn add -D vuepress@next

# 新建一个 markdown 文件
echo '# Hello VuePress' > README.md

# 开始写作
yarn vuepress dev

# 构建静态文件
yarn vuepress build
```

  </CodeGroupItem>

  <CodeGroupItem title="NPM">

```bash
# 在你的项目中安装
npm install -D vuepress@next

# 新建一个 markdown 文件
echo '# Hello VuePress' > README.md

# 开始写作
npx vuepress dev

# 构建静态文件
npx vuepress build
```

  </CodeGroupItem>
</CodeGroup>
