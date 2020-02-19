namespace CountMeUpScotty {

  public class Game {

    // Constructor
    public Game(Player player) {
      this.player = player;
      CreateChallenges();
    }

    public SumChallenge NextChallenge() {
      // SumChallenge challenge = challenges[currentChallenge];
      // currentChallenge++;
      // return challenge;

      return challenges[currentChallenge++];
    }

    private void CreateChallenges() {
      for (int i = 0; i < challenges.Length; i++) {
        challenges[i] = new SumChallenge();
      }
    }

    // Attributes
    private Player player;
    private SumChallenge[] challenges = new SumChallenge[10];
    int currentChallenge = 0;
  }
}