import { defineConfig, loadEnv } from 'vite'
import react from '@vitejs/plugin-react'
import tailwindcss from '@tailwindcss/vite'
import path from 'path'

export default defineConfig(({ mode }) => {
  const env = loadEnv(mode, process.cwd(), '')
  // 如果环境变量未指定，默认指向云端服务或者本地端
  const apiTarget = env.VITE_API_TARGET || 'http://47.93.192.193:8085'
  const agentTarget = 'http://127.0.0.1:5000'
  
  return {
    plugins: [
      react(),
      tailwindcss(),
    ],
    resolve: {
      alias: {
        "@": path.resolve(__dirname, "./src"),
      },
    },
    server: {
      port: 3000,
      host: '0.0.0.0',
      proxy: {
        // 请求 /api/local 的转发到本地 agent 服务
        '/api/local': {
          target: agentTarget,
          changeOrigin: true
        },
        '/ws/location': {
          target: agentTarget.replace(/^http/, 'ws'),
          ws: true,
          changeOrigin: true
        },
        // 其他匹配到的请求转发到远端 Java 后端服务器
        '/api': {
          target: apiTarget,
          changeOrigin: true
        },
        '/vehicle': {
          target: apiTarget,
          changeOrigin: true
        },
        '/poi': {
          target: apiTarget,
          changeOrigin: true
        },
        '/event': {
          target: apiTarget,
          changeOrigin: true
        },
        '/ws': {
          target: apiTarget.replace(/^http/, 'ws'),
          ws: true,
          changeOrigin: true
        }
      }
    }
  }
})
