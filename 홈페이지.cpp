/*
문제
준하는 사이트에 회원가입을 하다가 joonas라는 아이디가 이미 존재하는 것을 보고 놀랐다. 준하는 놀람을 ??!로 표현한다. 준하가 가입하려고 하는 사이트에 이미 존재하는 아이디가 주어졌을 때, 놀람을 표현하는 프로그램을 작성하시오.

입력
첫째 줄에 준하가 가입하려고 하는 사이트에 이미 존재하는 아이디가 주어진다. 아이디는 알파벳 소문자로만 이루어져 있으며, 길이는 50자를 넘지 않는다.

출력
첫째 줄에 준하의 놀람을 출력한다. 놀람은 아이디 뒤에 ??!를 붙여서 나타낸다.

예제 입력 1
joonas
예제 출력 1
joonas??!

예제 입력 2
baekjoon
예제 출력 2
baekjoon??!
*/
#include<iostream>
#include<cctype>
#include<string>

using namespace std;

//배열 크기
const size_t MAX_LENGTH = 50;
//현재 배열안 size
size_t idlist_size = 2;

void Input()
{
	//배열 초기화
	string idlist[MAX_LENGTH] = { "joonas","baekjoon" };

	//아이디 입력받기
	string id;
	getline(cin, id);

	//아이디 검색
	for (size_t i = 0; i < idlist_size; i++)
	{
		if (idlist[i] == id)
		{
			cout << id << "??!" << endl;
			return;
		}
	}
	cout << id << endl;
	idlist[idlist_size] = id;
	idlist_size++;
	return;
}

int main()
{
	Input();
	return 0;
}