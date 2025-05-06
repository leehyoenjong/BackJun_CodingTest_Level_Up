public class num_14503
{
    static void Mains(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        string[] input_ = Console.ReadLine().Split();
        int x = int.Parse(input_[0]);
        int y = int.Parse(input_[1]);
        int d = int.Parse(input_[2]);

        int[][] map = new int[N][];
        bool[][] chk = new bool[N][];

        for (int i = 0; i < N; i++)
        {
            string[] data = Console.ReadLine().Split();

            map[i] = new int[M];
            for (int j = 0; j < M; j++)
            {
                map[i][j] = int.Parse(data[j]);
            }
            chk[i] = new bool[M];
        }

        int[] rots_x = { -1, 0, 1, 0 };
        int[] rots_y = { 0, 1, 0, -1 };

        int clearcount = 0;
        while (true)
        {
            //현재 칸이 아직 청소되지 않은 경우, 현재 칸을 청소한다.
            if (map[x][y] == 0)
            {
                map[x][y] = 2;
                clearcount++;
                continue;
            }

            //현재 칸의 주변 4칸 중 
            bool isclear = false;
            for (int i = 0; i < 4; i++)
            {
                int tempx = x + rots_x[i];
                int tempy = y + rots_y[i];

                //바라보는 방향의 뒤쪽 칸이 벽이라 후진할 수 없다면 멈춘다
                if (Check_Map_Length(map, x, tempx, tempy))
                {
                    continue;
                }

                //벽이거나 청소했으면 다시 탐색
                if (map[tempx][tempy] != 0)
                {
                    continue;
                }
                isclear = true;
                break;
            }

            //청소되지 않은 빈 칸이 없는 경우,
            if (!isclear)
            {
                //바라보는 방향을 유지한 채로 한 칸 후진할 수 있다면 한 칸 후진하고 1번으로 돌아간다.
                int temp_rot = (d + 2) % 4;

                int tempx = x + rots_x[temp_rot];
                int tempy = y + rots_y[temp_rot];

                //바라보는 방향의 뒤쪽 칸이 벽이라 후진할 수 없다면 멈춘다
                if (Check_Map_Length(map, x, tempx, tempy))
                {
                    break;
                }

                x = tempx;
                y = tempy;
                continue;
            }


            //현재 칸의 주변 4칸 중 청소되지 않은 빈 칸이 있는 경우,
            for (int i = 0; i < 4; i++)
            {
                //반시계 방향으로 90도 회전한다
                d = (d + 3) % 4;

                //바라보는 방향을 기준으로 앞쪽 칸이 청소되지 않은 빈 칸인 경우 한 칸 전진한다.
                int tempx = x + rots_x[d];
                int tempy = y + rots_y[d];

                if (Check_Map_Length(map, x, tempx, tempy))
                {
                    continue;
                }

                if (map[tempx][tempy] == 0)
                {
                    x = tempx;
                    y = tempy;
                    break;
                }
            }
        }

        Console.WriteLine(clearcount);
    }

    static bool Check_Map_Length(int[][] map, int x, int tempx, int tempy)
    {
        return 0 > tempx || 0 > tempy || map.Length <= tempx || map[x].Length <= tempy || map[tempx][tempy] == 1;
    }


    static void Mainss(string[] args)
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        input = Console.ReadLine().Split();
        int y = int.Parse(input[0]);
        int x = int.Parse(input[1]);
        int d = int.Parse(input[2]);

        int[][] map = new int[N][];
        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split();
            map[i] = new int[M];
            for (int j = 0; j < M; j++)
            {
                map[i][j] = int.Parse(input[j]);
            }
        }

        int cnt = 0;
        int[] dy = { -1, 0, 1, 0 };  // 북, 동, 남, 서
        int[] dx = { 0, 1, 0, -1 };

        while (true)
        {
            // 현재 칸이 청소되지 않은 경우 청소
            if (map[y][x] == 0)
            {
                map[y][x] = 2;  // 청소 완료 표시
                cnt++;
            }

            bool sw = false;

            // 4방향 탐색
            for (int i = 1; i <= 4; i++)
            {
                // 반시계 방향으로 회전 (d-i+4)%4
                int nd = (d - i + 4) % 4;
                int ny = y + dy[nd];
                int nx = x + dx[nd];

                if (0 <= ny && ny < N && 0 <= nx && nx < M)
                {
                    if (map[ny][nx] == 0)
                    {
                        d = nd;
                        y = ny;
                        x = nx;
                        sw = true;
                        break;
                    }
                }
            }

            // 4방향 모두 갈 수 없는 경우
            if (!sw)
            {
                // 후진 방향 계산
                int ny = y - dy[d];
                int nx = x - dx[d];

                if (0 <= ny && ny < N && 0 <= nx && nx < M)
                {
                    if (map[ny][nx] == 1)  // 벽이면 종료
                    {
                        break;
                    }
                    else  // 벽이 아니면 후진
                    {
                        y = ny;
                        x = nx;
                    }
                }
                else  // 범위를 벗어나면 종료
                {
                    break;
                }
            }
        }

        Console.WriteLine(cnt);
    }
}