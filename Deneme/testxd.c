#include <unistd.h>

int main()
{
	int  i = open("asd.text",O_RDONLY);

	printf("%s", get_next_line(i));
	printf("%s", get_next_line(i));

				
}

static char	*next_line(int fd, char *s)
{
	char	*str;
	int		i;

	str = (char *)malloc(sizeof(char) * BUFFER_SIZE + 1);
	if (!str)
		return (NULL);
	i = 1;
	while (!ft_strchr(s, '\n') && i != 0)
	{
		i = read(fd, str, BUFFER_SIZE);
		if (i == -1)
		{
			free(str);
			return (NULL);
		}
		str[i] = '\0';
		s = ft_strjoin(s, str);
	}
	free(str);
	return (s);
}