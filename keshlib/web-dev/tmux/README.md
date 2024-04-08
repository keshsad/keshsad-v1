This document is the essentials of using tmux, a terminal multiplexer.

tmux is just one example of very useful technology built by the developer community. I believe it is a crucial tool for
developers to use because it is one good solution to keeping both local and ssh sessions organized and intact. This is just one tool though. Vim motions, NVIM configuration, netrw, and terminal commands are very important. This is a good area to write about as well.

### Using tmux

- start tmux by running `tmux` at the terminal
- create new windows with `ctrl+b` => `c`
- switch between windows with `ctrl+b` => `n` (next) or `p` (previous) or `<window num>`
- split into horizontal panes with `ctrl+b` => `%`
- split into vertical panes with `ctrl+b` => `"`
- navigate panes with `ctrl+b` => `<arrow key>`
- detach from tmux with `ctrl+b` => `d` 
- reattach to tmux session with `tmux a` at the terminal
- list sessions with `tmux ls`
- attach to specific session with `tmux attach -t <session name/num>`
- customize tmux within `~/.tmux.conf`
- close pane/window with `ctrl+b` => `x`

